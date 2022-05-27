using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SoenderBoP
{
    internal class SetUpDataGridViews
    {
        public static DataGridView SetUpDGV(DataGridView dgvSource, string sqlcom)
        {
            DataGridView dgvView = dgvSource;
            dgvView.DataSource = FillDataSource.GetDataSource(sqlcom);
            DataGridView DGV = dgvView;
            GetDGVStyle.GetStyle(DGV);
            return dgvView;
        }
    }
}
