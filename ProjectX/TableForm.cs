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
        public TableForm(int tableNum)
        {
            InitializeComponent();
            Text = (tableNum + 1).ToString() + " стол";
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
    }
}
