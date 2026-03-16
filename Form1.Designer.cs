namespace Elauncher
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btnPath = new System.Windows.Forms.Button();
            this.cmbFilter = new System.Windows.Forms.ComboBox();
            this.cmbVersions = new System.Windows.Forms.ComboBox();
            this.lblRam = new System.Windows.Forms.Label();
            this.numRam = new System.Windows.Forms.NumericUpDown();
            this.lblWindows = new System.Windows.Forms.Label();
            this.numWindows = new System.Windows.Forms.NumericUpDown();
            this.btnMultiName = new System.Windows.Forms.Button();
            this.btnLaunch = new System.Windows.Forms.Button();
            this.btnDownload = new System.Windows.Forms.Button();
            this.pbDownload = new System.Windows.Forms.ProgressBar();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtConsole = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numRam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWindows)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(20, 20);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(565, 29);
            this.txtPath.TabIndex = 16;
            // 
            // btnPath
            // 
            this.btnPath.Location = new System.Drawing.Point(591, 18);
            this.btnPath.Name = "btnPath";
            this.btnPath.Size = new System.Drawing.Size(166, 25);
            this.btnPath.TabIndex = 15;
            this.btnPath.Text = "Path For Games";
            this.btnPath.Click += new System.EventHandler(this.btnPath_Click);
            // 
            // cmbFilter
            // 
            this.cmbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilter.Items.AddRange(new object[] {
            "All",
            "Installed",
            "Remote"});
            this.cmbFilter.Location = new System.Drawing.Point(20, 55);
            this.cmbFilter.Name = "cmbFilter";
            this.cmbFilter.Size = new System.Drawing.Size(267, 26);
            this.cmbFilter.TabIndex = 14;
            // 
            // cmbVersions
            // 
            this.cmbVersions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVersions.Location = new System.Drawing.Point(293, 55);
            this.cmbVersions.Name = "cmbVersions";
            this.cmbVersions.Size = new System.Drawing.Size(464, 26);
            this.cmbVersions.TabIndex = 13;
            // 
            // lblRam
            // 
            this.lblRam.Location = new System.Drawing.Point(20, 100);
            this.lblRam.Name = "lblRam";
            this.lblRam.Size = new System.Drawing.Size(40, 20);
            this.lblRam.TabIndex = 12;
            this.lblRam.Text = "RAM:";
            // 
            // numRam
            // 
            this.numRam.Location = new System.Drawing.Point(65, 98);
            this.numRam.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numRam.Name = "numRam";
            this.numRam.Size = new System.Drawing.Size(70, 29);
            this.numRam.TabIndex = 11;
            this.numRam.Value = new decimal(new int[] {
            2048,
            0,
            0,
            0});
            // 
            // lblWindows
            // 
            this.lblWindows.Location = new System.Drawing.Point(145, 100);
            this.lblWindows.Name = "lblWindows";
            this.lblWindows.Size = new System.Drawing.Size(65, 20);
            this.lblWindows.TabIndex = 10;
            this.lblWindows.Text = "Windows:";
            // 
            // numWindows
            // 
            this.numWindows.Location = new System.Drawing.Point(215, 98);
            this.numWindows.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numWindows.Name = "numWindows";
            this.numWindows.Size = new System.Drawing.Size(160, 29);
            this.numWindows.TabIndex = 9;
            this.numWindows.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnMultiName
            // 
            this.btnMultiName.Location = new System.Drawing.Point(136, 239);
            this.btnMultiName.Name = "btnMultiName";
            this.btnMultiName.Size = new System.Drawing.Size(100, 25);
            this.btnMultiName.TabIndex = 8;
            this.btnMultiName.Text = "Set Names";
            this.btnMultiName.Click += new System.EventHandler(this.btnMultiName_Click);
            // 
            // btnLaunch
            // 
            this.btnLaunch.Location = new System.Drawing.Point(200, 145);
            this.btnLaunch.Name = "btnLaunch";
            this.btnLaunch.Size = new System.Drawing.Size(175, 40);
            this.btnLaunch.TabIndex = 7;
            this.btnLaunch.Text = "Launch";
            this.btnLaunch.Click += new System.EventHandler(this.btnLaunch_Click);
            // 
            // btnDownload
            // 
            this.btnDownload.Location = new System.Drawing.Point(20, 145);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(175, 40);
            this.btnDownload.TabIndex = 6;
            this.btnDownload.Text = "Download";
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // pbDownload
            // 
            this.pbDownload.Location = new System.Drawing.Point(20, 195);
            this.pbDownload.Name = "pbDownload";
            this.pbDownload.Size = new System.Drawing.Size(355, 15);
            this.pbDownload.TabIndex = 5;
            // 
            // lblStatus
            // 
            this.lblStatus.Location = new System.Drawing.Point(20, 215);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(355, 20);
            this.lblStatus.TabIndex = 4;
            this.lblStatus.Text = "Ready";
            // 
            // txtConsole
            // 
            this.txtConsole.BackColor = System.Drawing.Color.Black;
            this.txtConsole.Font = new System.Drawing.Font("Consolas", 8F);
            this.txtConsole.ForeColor = System.Drawing.Color.Lime;
            this.txtConsole.Location = new System.Drawing.Point(381, 87);
            this.txtConsole.Multiline = true;
            this.txtConsole.Name = "txtConsole";
            this.txtConsole.ReadOnly = true;
            this.txtConsole.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtConsole.Size = new System.Drawing.Size(386, 300);
            this.txtConsole.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(20, 240);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Clear Log";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(20, 269);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Log Font Color";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(20, 298);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(110, 23);
            this.button3.TabIndex = 0;
            this.button3.Text = "Log Bg Color";
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(136, 270);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 25);
            this.button4.TabIndex = 17;
            this.button4.Text = "About";
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(779, 402);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtConsole);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.pbDownload);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.btnLaunch);
            this.Controls.Add(this.btnMultiName);
            this.Controls.Add(this.numWindows);
            this.Controls.Add(this.lblWindows);
            this.Controls.Add(this.numRam);
            this.Controls.Add(this.lblRam);
            this.Controls.Add(this.cmbVersions);
            this.Controls.Add(this.cmbFilter);
            this.Controls.Add(this.btnPath);
            this.Controls.Add(this.txtPath);
            this.Name = "Form1";
            this.Text = "Elauncher";
            ((System.ComponentModel.ISupportInitialize)(this.numRam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWindows)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button btnPath;
        private System.Windows.Forms.ComboBox cmbFilter;
        private System.Windows.Forms.ComboBox cmbVersions;
        private System.Windows.Forms.Label lblRam;
        private System.Windows.Forms.NumericUpDown numRam;
        private System.Windows.Forms.Label lblWindows;
        private System.Windows.Forms.NumericUpDown numWindows;
        private System.Windows.Forms.Button btnMultiName;
        private System.Windows.Forms.Button btnLaunch;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.ProgressBar pbDownload;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtConsole;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}