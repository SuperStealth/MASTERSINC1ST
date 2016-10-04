using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProjectX
{
    class Sql
    {
        public static string _connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\ProjectX\MASTERSINC1ST\ProjectX\Drinks.mdf;Integrated Security=True";
        public void FillDataGridViewByQuery(DataGridView dgv, string query)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = _connectionString;
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = query;
            DataTable dataTable = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(dataTable);
            dgv.DataSource = dataTable;
        }
    }
}
