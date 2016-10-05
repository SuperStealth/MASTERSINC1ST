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
            string[] text = System.IO.File.ReadAllLines(@"../../Settings.cfg");
            int.TryParse(text[0], out tablesQuantity);
            int.TryParse(text[1], out currentOrderNumber);

            InitializeComponent();
            for (int i = 0; i < tablesQuantity; i++)
            {
                orderNumbers.Add(0);
            }

            for (int i = 0; i < tablesQuantity; i++)
            {
                Button button = new Button();
                button.BackColor = Color.Gray;
                button.Location = new Point(10 + 100*i - 500*(i/5), 80 * (i/5) + 50);
                button.Text = (i+1).ToString();
                button.Click += new EventHandler(ButtonClickOneEvent);
                button.Tag = i;
                Controls.Add(button);
            }
        }

        private void ButtonClickOneEvent(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button != null)
            {
                if (orderNumbers[(int)button.Tag] == 0)
                {
                    orderNumbers[(int)button.Tag] = currentOrderNumber;
                    currentOrderNumber++;
                }
                TableForm tableForm = new TableForm((int)button.Tag);
                tableForm.Show();
            }
        }

        private void выдатьРасчетToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SummForm summForm = new SummForm();
            summForm.Show();
        }

        

        private void настройкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm();
            settingsForm.Show();
        }

        public DateTime openingTime = DateTime.Now;

        public static int currentOrderNumber;
        public static List<int> orderNumbers = new List<int>();
        public int tablesQuantity;

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.IO.File.WriteAllText(@"../../Settings.cfg", tablesQuantity + Environment.NewLine +
                        currentOrderNumber.ToString());
        }
    }
}
