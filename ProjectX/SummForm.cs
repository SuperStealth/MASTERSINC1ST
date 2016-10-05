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
    public partial class SummForm : Form
    {
        private Sql _sqlWork = new Sql();


        public SummForm()
        {
            InitializeComponent();
            _sqlWork.FillDataGridViewByQuery(summDataGridView, "SELECT d.DrinkType, s.Count, d.Price, s.DateTime FROM SummTable s JOIN DrinksTable d ON s.DrinkID = d.Id WHERE s.DateTime > '" + MainForm.openingTime.ToString("yyyy-MM-dd HH:mm") + "'");

        }
    }
}
