using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace SoenderBoP
{
    public class FillDataSource
    {
        //Skaber DataTable
        // Vi gemmer vores DataSource i en string: sqlcom. Denne bruger vi til alle de forskellige SQL queries vi bruger i vores DataGridViews.
        public static DataTable GetDataSource(string sqlcom)
        {
            //Åbner forbindelsen med query'en fra strconn. Vi kalder den forbindelse for conn

            SqlConnection conn = Database.Conn;
            //Kører derefter kommandoen med Sql query'en og forbindelsen. Vi kalden comm
            SqlCommand cmd = new SqlCommand(sqlcom, conn);

            //Der bruges en funktion kaldet SqlDataAdapter for at C# og WinForms kan læse kommandoen. Vi kalder den adapter
            using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
            {
                //Endelig laves DataTable.
                DataTable dt = new DataTable();
                //Den fyldes med SQL informationerne
                adapter.Fill(dt);
                //og returnes derefter
                return dt;
            }

        }
        public static DataGridView SetUpDGV(DataGridView dgvSource, string sqlcom)
        {
            DataGridView DGV = dgvSource;
            DGV.DataSource = FillDataSource.GetDataSource(sqlcom);
            GetDGVStyle.GetStyle(DGV);
            return DGV;
        }
    }
}
