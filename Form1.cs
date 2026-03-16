using CmlLib.Core;
using CmlLib.Core.Auth;
using CmlLib.Core.Installers;
using CmlLib.Core.ProcessBuilder;
using CmlLib.Core.Version;
using CmlLib.Core.VersionMetadata;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elauncher
{
    public partial class Form1 : Form
    {
        private MinecraftLauncher _launcher;
        private List<IVersionMetadata> _allVersions = new List<IVersionMetadata>();
        public List<string> MultiPlayerNames = new List<string>();

        public Form1()
        {
            InitializeComponent();
            cmbFilter.SelectedIndex = 0;
            cmbFilter.SelectedIndexChanged += (s, e) => RefreshDisplayList();
            cmbVersions.SelectedIndexChanged += (s, e) => UpdateButtonStates();
        }

        private async void btnPath_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    txtPath.Text = fbd.SelectedPath;
                    await LoadAllVersions(fbd.SelectedPath);
                }
            }
        }

        private async Task LoadAllVersions(string path, string lastSelected = "")
        {
            var lp = new MinecraftPath(path);
            _launcher = new MinecraftLauncher(lp);
            lblStatus.Text = "Updating versions...";

            var versions = await _launcher.GetAllVersionsAsync();
            _allVersions = versions.ToList();

            RefreshDisplayList(lastSelected);
            lblStatus.Text = "Ready";
        }

        private void RefreshDisplayList(string lastSelected = "")
        {
            if (_launcher == null) return;
            var lp = new MinecraftPath(txtPath.Text);
            cmbVersions.Items.Clear();

            int selectIndex = 0;
            foreach (var v in _allVersions)
            {
                bool isLocal = File.Exists(lp.GetVersionJsonPath(v.Name));
                if (cmbFilter.SelectedIndex == 1 && !isLocal) continue;
                if (cmbFilter.SelectedIndex == 2 && isLocal) continue;

                string name = v.Name + (isLocal ? " (Installed)" : "");
                int idx = cmbVersions.Items.Add(name);
                if (v.Name == lastSelected) selectIndex = idx;
            }

            if (cmbVersions.Items.Count > 0) cmbVersions.SelectedIndex = selectIndex;
            UpdateButtonStates();
        }

        private void UpdateButtonStates()
        {
            if (cmbVersions.SelectedItem == null) return;
            bool isInstalled = cmbVersions.SelectedItem.ToString().Contains("(Installed)");
            btnDownload.Text = isInstalled ? "Update" : "Download";
        }

        private void btnMultiName_Click(object sender, EventArgs e)
        {
            using (var f2 = new Form2(this, (int)numWindows.Value))
            {
                f2.ShowDialog();
            }
        }

        private async void btnDownload_Click(object sender, EventArgs e)
        {
            if (_launcher == null || cmbVersions.SelectedItem == null) return;

            string rawName = cmbVersions.SelectedItem.ToString().Replace(" (Installed)", "");
            btnDownload.Enabled = false;
            btnLaunch.Enabled = false;

            try
            {
                var progress = new Progress<InstallerProgressChangedEventArgs>(ev =>
                {
                    this.Invoke(new Action(() =>
                    {
                        lblStatus.Text = $"{ev.Name}: {ev.ProgressedTasks}/{ev.TotalTasks}";
                        pbDownload.Maximum = ev.TotalTasks > 0 ? ev.TotalTasks : 100;
                        pbDownload.Value = ev.ProgressedTasks;
                    }));
                });

                await _launcher.InstallAsync(rawName, progress, null, CancellationToken.None);
                await LoadAllVersions(txtPath.Text, rawName);
                MessageBox.Show("Download successful.");
            }
            catch (Exception ex) { MessageBox.Show("Download Error: " + ex.Message); }
            finally
            {
                btnDownload.Enabled = true;
                btnLaunch.Enabled = true;
                lblStatus.Text = "Ready";
                pbDownload.Value = 0;
            }
        }

        private async void btnLaunch_Click(object sender, EventArgs e)
        {
            if (_launcher == null || cmbVersions.SelectedItem == null) return;

            string rawName = cmbVersions.SelectedItem.ToString().Replace(" (Installed)", "");
            bool isInstalled = cmbVersions.SelectedItem.ToString().Contains("(Installed)");

            if (!isInstalled)
            {
                MessageBox.Show("Please download this version first.");
                return;
            }

            if (MultiPlayerNames.Count == 0)
            {
                MessageBox.Show("Please set player names first.");
                return;
            }

            btnLaunch.Enabled = false;
            btnDownload.Enabled = false;

            try
            {
                int count = (int)numWindows.Value;
                for (int i = 0; i < count; i++)
                {
                    string pName = (MultiPlayerNames.Count > i && !string.IsNullOrEmpty(MultiPlayerNames[i])) ? MultiPlayerNames[i] : "Player";
                    var session = MSession.CreateOfflineSession(pName);
                    var launchOption = new MLaunchOption
                    {
                        Session = session,
                        MaximumRamMb = (int)numRam.Value
                    };

                    var process = await _launcher.CreateProcessAsync(rawName, launchOption);
                    process.StartInfo.UseShellExecute = false;
                    process.StartInfo.RedirectStandardOutput = true;
                    process.StartInfo.RedirectStandardError = true;
                    process.OutputDataReceived += (s, ev) => AppendLog(ev.Data);
                    process.ErrorDataReceived += (s, ev) => AppendLog(ev.Data);

                    process.Start();
                    process.BeginOutputReadLine();
                    process.BeginErrorReadLine();
                }
            }
            catch (Exception ex) { MessageBox.Show("Launch Error: " + ex.Message); }
            finally
            {
                btnLaunch.Enabled = true;
                btnDownload.Enabled = true;
                lblStatus.Text = "Ready";
            }
        }

        private void AppendLog(string text)
        {
            if (text == null) return;
            this.Invoke(new Action(() =>
            {
                txtConsole.AppendText(text + Environment.NewLine);
            }));
        }

        private void button1_Click(object sender, EventArgs e) => txtConsole.Clear();

        private void button2_Click(object sender, EventArgs e)
        {
            using (ColorDialog cd = new ColorDialog())
            {
                if (cd.ShowDialog() == DialogResult.OK) txtConsole.ForeColor = cd.Color;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (ColorDialog cd = new ColorDialog())
            {
                if (cd.ShowDialog() == DialogResult.OK) txtConsole.BackColor = cd.Color;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Made By inecraftm84 , Thanks For Download.");
        }
    }
}