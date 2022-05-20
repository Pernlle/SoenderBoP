using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoenderBoP
{
    public partial class Available : Form
    {
        public Available()
        {
            InitializeComponent();
        }

        private void Available_Load(object sender, EventArgs e)
        {
            string sqlcom = "SELECT * FROM Bolig WHERE loebenummer IS NULL";
            aDGV.DataSource = FillDataSource.GetDataSource(sqlcom);
            DataGridView DGV = aDGV;
            GetDGVStyle.GetStyle(DGV);
        }
    }
}
