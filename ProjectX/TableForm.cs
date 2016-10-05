using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProjectX
{
    public partial class TableForm : Form
    {
        private Sql _sqlWork = new Sql();


        private void RefreshAll()
        {
            _sqlWork.FillDataGridViewByQuery(tableDataGridView, "SELECT s.Id, d.DrinkType, d.Price, s.Count FROM SummTable s JOIN DrinksTable d ON s.DrinkID = d.Id WHERE s.OrderNum = " + MainForm.orderNumbers[tableNumber]);
            int sum = 0;
            if (tableDataGridView.RowCount - 1 > 0)
                for (int i = 0; i < tableDataGridView.RowCount - 1; i++)
                {
                    int price, count;
                    int.TryParse(tableDataGridView[2, i].Value.ToString(), out price);
                    int.TryParse(tableDataGridView[3, i].Value.ToString(), out count);
                    sum += price * count;
                }
            sumLabel.Text = "Сумма: " + sum.ToString() + "руб.";
        }

        public TableForm(int tableNum)
        {
            InitializeComponent();
            tableNumber = tableNum;
            Text = (tableNum + 1).ToString() + " стол";
            RefreshAll();
            tableDataGridView.Columns[0].Visible = false;
            tableDataGridView.Columns[1].HeaderText = "Напиток";
            tableDataGridView.Columns[2].HeaderText = "Цена";
            tableDataGridView.Columns[3].HeaderText = "Количество";
            
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            _sqlWork.FillDataGridViewByQuery(overallDataGridView, "SELECT * FROM DrinksTable WHERE DrinkType LIKE N'%" + searchTextBox.Text + "%'");
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(Sql._connectionString);
            connection.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandText = "INSERT INTO [SummTable] (DrinkID, DateTime, Count, OrderNum) VALUES("
                   + overallDataGridView[0, overallDataGridView.CurrentCell.RowIndex].Value + ",N'" 
                   + DateTime.Now.ToString("yyyy-MM-dd HH:mm") + "', 1," 
                   + MainForm.orderNumbers[tableNumber] +")";
            cmd.ExecuteNonQuery();
            connection.Close();
            cmd.Dispose();

            RefreshAll();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            int row = tableDataGridView.CurrentRow.Index;
            string x1 = tableDataGridView[0, row].Value.ToString();

            SqlConnection conn = new SqlConnection(Sql._connectionString);
            conn.Open(); //Устанавливаем соединение с базой данных.
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "DELETE FROM [SummTable] WHERE SummTable.Id='" + x1 + "'";
            cmd.ExecuteNonQuery();
            conn.Close();
            RefreshAll();
        }

        private void closeTableButton_Click(object sender, EventArgs e)
        {
            MainForm.orderNumbers[tableNumber] = 0;
            Close();
        }

        private void TableForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "drinksDataSet.DrinksTable". При необходимости она может быть перемещена или удалена.
            this.drinksTableTableAdapter.Fill(this.drinksDataSet.DrinksTable);
        }

        private int tableNumber;
    }
}
