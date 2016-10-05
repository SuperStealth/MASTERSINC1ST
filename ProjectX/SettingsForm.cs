using System;
using System.Windows.Forms;

namespace ProjectX
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            int tablesCount;
            if (int.TryParse(textBox1.Text, out tablesCount))
            {
                if ((tablesCount > 0) && (tablesCount < 40))
                {
                    System.IO.File.WriteAllText(@"../../Settings.cfg", textBox1.Text + Environment.NewLine +
                        MainForm.currentOrderNumber.ToString());
                    MessageBox.Show("Перезапустите программу чтобы изменения вступили в силу!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Неправильно введены данные!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }    
                
            }
            else
                MessageBox.Show("Неправильно введены данные!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
    }
}
