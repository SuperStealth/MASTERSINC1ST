using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                // now you know the button that was clicked
                switch ((int)button.Tag)
                {
                    case 0:
                        Debug.Write("0");
                        break;
                    case 1:

                        break;
                    case 2:

                        break;
                    case 3:

                        break;
                    case 4:

                        break;
                    case 5:

                        break;
                    case 6:

                        break;
                    case 7:

                        break;
                    case 8:

                        break;
                    case 9:

                        break;
                }
            }
        }

        private void выдатьРасчетToolStripMenuItem_Click(object sender, EventArgs e)
        {

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
