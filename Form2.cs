using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Elauncher
{
    public partial class Form2 : Form
    {
        private Form1 main;
        private TableLayoutPanel tlp;

        public Form2(Form1 parent, int count)
        {
            InitializeComponent();
            this.main = parent;
            this.Text = "Player Names Configuration";
            this.Size = new System.Drawing.Size(350, 500);
            this.StartPosition = FormStartPosition.CenterParent;

            tlp = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                AutoScroll = true,
                ColumnCount = 2
            };

            tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65F));

            this.Controls.Add(tlp);

            for (int i = 0; i < count; i++)
            {
                tlp.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));

                Label lbl = new Label
                {
                    Text = $"Window {i + 1}:",
                    TextAlign = System.Drawing.ContentAlignment.MiddleLeft,
                    Dock = DockStyle.Fill,
                    Margin = new Padding(10, 5, 0, 5)
                };

                TextBox tb = new TextBox
                {
                    Name = "tb" + i,
                    Dock = DockStyle.Fill,
                    Margin = new Padding(0, 5, 15, 5)
                };

                if (main.MultiPlayerNames.Count > i) tb.Text = main.MultiPlayerNames[i];

                tlp.Controls.Add(lbl, 0, i);
                tlp.Controls.Add(tb, 1, i);
            }

            tlp.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlp.Controls.Add(new Label { Text = "" }, 0, count);

            Button btnSave = new Button
            {
                Text = "Save & Close",
                Dock = DockStyle.Bottom,
                Height = 50
            };

            btnSave.Click += (s, e) =>
            {
                main.MultiPlayerNames.Clear();
                for (int i = 0; i < count; i++)
                {
                    Control[] ctrls = tlp.Controls.Find("tb" + i, true);
                    if (ctrls.Length > 0 && ctrls[0] is TextBox t)
                        main.MultiPlayerNames.Add(t.Text);
                }
                this.Close();
            };
            this.Controls.Add(btnSave);
        }
    }
}