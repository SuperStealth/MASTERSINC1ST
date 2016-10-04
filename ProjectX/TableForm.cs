using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectX
{
    public partial class TableForm : Form
    {
        private Sql _sqlWork = new Sql();


        public TableForm(int tableNum)
        {
            InitializeComponent();
            Text = (tableNum + 1).ToString() + " стол";
            _sqlWork.FillDataGridViewByQuery(tableDataGridView, "SELECT d.DrinkType, d.Price, s.DrinkID, s.Count FROM SummTable s JOIN DrinksTable d ON s.DrinkID = d.Id");
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            //сделоть тут
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            //сделоть тут
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            //сделоть тут
        }

        private void closeTableButton_Click(object sender, EventArgs e)
        {
            //сделоть тут
        }

        private void TableForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "drinksDataSet.DrinksTable". При необходимости она может быть перемещена или удалена.
            this.drinksTableTableAdapter.Fill(this.drinksDataSet.DrinksTable);

        }
    }
}
