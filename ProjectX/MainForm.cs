using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ProjectX
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            string text = System.IO.File.ReadAllText(@"../../Settings.cfg");
            int.TryParse(text, out tablesQuantity);
            InitializeComponent();
            List<Button> buttons = new List<Button>();
            for (int i = 0; i < tablesQuantity; i++)
            {
                Button button = new Button();
                button.BackColor = Color.Gray;
                button.Location = new Point(10 + 100*i - 500*(i/5), 80 * (i/5) + 50);
                button.Text = (i+1).ToString();
                button.Click += new EventHandler(ButtonClickOneEvent);
                button.Tag = i;
                this.Controls.Add(button);
            }
        }

        private void ButtonClickOneEvent(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button != null)
            {
                TableForm tableForm = new TableForm((int)button.Tag);
                tableForm.Show();
            }
        }

        private void выдатьРасчетToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SummForm summForm = new SummForm();
            summForm.Show();
        }

        public int tablesQuantity;

        private void настройкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm();
            settingsForm.Show();
        }

        public DateTime openingTime = DateTime.Now;
    }
}
