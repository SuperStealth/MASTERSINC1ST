using System;
using System.Windows.Forms;

namespace ProjectX
{
    public partial class TableForm : Form
    {
        private Sql _sqlWork = new Sql();


        private void RefreshSum()
        {
            int sum = 0;
            if (tableDataGridView.RowCount - 1 > 0)
                for (int i = 0; i < tableDataGridView.RowCount - 1; i++)
                {
                    int price, count;
                    int.TryParse(tableDataGridView[1, i].Value.ToString(), out price);
                    int.TryParse(tableDataGridView[2, i].Value.ToString(), out count);
                    sum += price * count;
                }
            sumLabel.Text = "Сумма: " + sum.ToString() + "руб.";
        }

        public TableForm(int tableNum)
        {
            InitializeComponent();
            Text = (tableNum + 1).ToString() + " стол";
            _sqlWork.FillDataGridViewByQuery(tableDataGridView, "SELECT d.DrinkType, d.Price, s.Count FROM SummTable s JOIN DrinksTable d ON s.DrinkID = d.Id");
            tableDataGridView.Columns[0].HeaderText = "Напиток";
            tableDataGridView.Columns[1].HeaderText = "Цена";
            tableDataGridView.Columns[2].HeaderText = "Количество";
            RefreshSum();
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            _sqlWork.FillDataGridViewByQuery(overallDataGridView, "SELECT * FROM DrinksTable WHERE DrinkType LIKE N'%" + searchTextBox.Text + "%'");
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            //сделоть тут
            RefreshSum();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            //сделоть тут
            RefreshSum();
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
