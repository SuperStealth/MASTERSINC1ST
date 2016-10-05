using System;
using System.Windows.Forms;
using System.IO;
using System.Reflection;
using Word = Microsoft.Office.Interop.Word;

namespace ProjectX
{
    public partial class SummForm : Form
    {
        private Sql _sqlWork = new Sql();


        public SummForm()
        {
            InitializeComponent();
            _sqlWork.FillDataGridViewByQuery(summDataGridView, "SELECT d.DrinkType, s.Count, d.Price, s.DateTime FROM SummTable s JOIN DrinksTable d ON s.DrinkID = d.Id WHERE s.DateTime > '" + MainForm.openingTime.ToString("yyyy-MM-dd HH:mm") + "'");

        }

        private void печать_button1_Click(object sender, System.EventArgs e)
        {
            SaveDialog.InitialDirectory = Application.StartupPath;
            SaveDialog.Filter = "Microsoft Word 2007-2010 (*.docx)|*.docx";
            SaveDialog.FilterIndex = 3;
            SaveDialog.RestoreDirectory = true;
            SaveDialog.FileName = "Личная карточка (" + textBox1.Text + ' ' + textBox2.Text + ' ' + textBox3.Text + ")";
            if (SaveDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // currdirect + "\\temp.docx" - путь к документу-шаблону
                    // В данном случае программа будет искать его в корне программы (папка Debug)
                    string currdirect = Application.StartupPath;
                    File.Copy(currdirect + "\\Личная карточка несовершеннолетнего.docx", SaveDialog.FileName, true);
                    object missing = Missing.Value;
                    Word.Application wordApp = new Word.Application();
                    Word.Document Doc = null;
                    object filename = SaveDialog.FileName;

                    if (File.Exists((string)filename))
                    {
                        object readOnly = false;
                        object isVisible = false;
                        wordApp.Visible = false; // Выключаем видимость ворда
                        Doc = wordApp.Documents.Open(ref filename, ref missing, ref readOnly, ref missing,
                                                      ref missing, ref missing, ref missing, ref missing,
                                                      ref missing, ref missing, ref missing, ref isVisible,
                                                      ref missing, ref missing, ref missing, ref missing);
                        Doc.Activate();
                        // Вот собственно 
                        this.FindAndReplace(wordApp, "[1]", textBox1.Text); 
                        this.FindAndReplace(wordApp, "[2]", textBox2.Text);  
                        this.FindAndReplace(wordApp, "[3]", textBox3.Text);  
                        this.FindAndReplace(wordApp, "[4]", comboBox1.Text);  //cb1
                        this.FindAndReplace(wordApp, "[5]", dateTimePicker1.Value.ToString("dd.MM.yyyy"));  //dtp1
                        this.FindAndReplace(wordApp, "[6]", textBox9.Text);
                        this.FindAndReplace(wordApp, "[7]", textBox10.Text);
                        this.FindAndReplace(wordApp, "[8]", textBox8.Text);
                        this.FindAndReplace(wordApp, "[9]", textBox4.Text); //++
                        this.FindAndReplace(wordApp, "[10]", textBox6.Text);
                        this.FindAndReplace(wordApp, "[11]", comboBox3.Text); //cb3
                        this.FindAndReplace(wordApp, "[12]", textBox14.Text);
                        this.FindAndReplace(wordApp, "[13]", textBox15.Text);
                        this.FindAndReplace(wordApp, "[14]", textBox13.Text);
                        this.FindAndReplace(wordApp, "[15]", textBox17.Text);
                        this.FindAndReplace(wordApp, "[16]", textBox16.Text);
                        this.FindAndReplace(wordApp, "[17]", textBox18.Text);
                        this.FindAndReplace(wordApp, "[18]", textBox7.Text);
                        this.FindAndReplace(wordApp, "[19]", comboBox4.Text); //cb4
                        this.FindAndReplace(wordApp, "[20]", textBox12.Text);
                        this.FindAndReplace(wordApp, "[21]", comboBox5.Text); //cb5
                        this.FindAndReplace(wordApp, "[22]", comboBox2.Text); //cb2
                        this.FindAndReplace(wordApp, "[23]", textBox21.Text);
                        this.FindAndReplace(wordApp, "[24]", textBox22.Text);
                        this.FindAndReplace(wordApp, "[25]", textBox23.Text);
                        this.FindAndReplace(wordApp, "[26]", dateTimePicker2.Value.ToString("dd.MM.yyyy")); //dtp2
                        this.FindAndReplace(wordApp, "[27]", dateTimePicker3.Value.ToString("dd.MM.yyyy")); //dtp3
                        this.FindAndReplace(wordApp, "[28]", textBox20.Text);
                        this.FindAndReplace(wordApp, "[29]", textBox24.Text);
                        this.FindAndReplace(wordApp, "[30]", dateTimePicker4.Value.ToString("dd.MM.yyyy"));  //dtp4
                        this.FindAndReplace(wordApp, "[31]", textBox25.Text);
                        this.FindAndReplace(wordApp, "[32]", dateTimePicker5.Value.ToString("dd.MM.yyyy"));  //dtp5
                        this.FindAndReplace(wordApp, "[33]", textBox26.Text);
                        this.FindAndReplace(wordApp, "[34]", textBox27.Text);
                        this.FindAndReplace(wordApp, "[35]", textBox28.Text);
                        this.FindAndReplace(wordApp, "[36]", textBox29.Text);
                        this.FindAndReplace(wordApp, "[37]", textBox30.Text);
                        Doc.Save();
                    }
                    else
                        MessageBox.Show("Файл не найден.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    wordApp.Visible = true; // И включаем видимость, это для того чтоб не видеть как там все дергается и меняется
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }
    }
}
