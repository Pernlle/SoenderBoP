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
    internal class FillDataSource
    {
        //Putter connection ind i string: strconn
        static string strconn = @"Server=den1.mssql7.gear.host; Database=soenderbodb; User ID=soenderbodb; Password=password!";
        //Skaber DataTable
        // Vi gemmer vores DataSource i en string: sqlcom. Denne bruger vi til alle de forskellige SQL queries vi bruger i vores DataGridViews.
        public static DataTable GetDataSource(string sqlcom)
        {
            //Åbner forbindelsen med query'en fra strconn. Vi kalder den forbindelse for conn
            using (SqlConnection conn = new SqlConnection(strconn))
            {
                //Kører derefter kommandoen med Sql query'en og forbindelsen. Vi kalden comm
                using (SqlCommand cmd = new SqlCommand(sqlcom, conn))
                {
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
            }
        }
    }
}
