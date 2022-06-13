using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace SoenderBoP
{
    public class Database
    {
        private readonly static string strconn = @"Server=den1.mssql7.gear.host; Database=soenderbodb; User ID=soenderbodb; Password=password!";
        private static SqlConnection conn = null;

        //Singleton :)
        public static SqlConnection Conn
        {
            get
            {
                if (conn == null)
                {
                    conn = new SqlConnection(strconn);
                }
                return conn;
            }
        }

    }
    public class CRUD
    {
        public static void Create(string tabel, string add, object[] data)
        {

            string[] adds = add.Split(',');
            // lav en values add for hver value, som er det samme add men med '@' på.
            string values = "";

            for (int i = 0; i < add.Length; i++)
            {
                // Tilføj til string set [ += ]
                values += "@" + add[i];
            }

            SqlConnection conn = Database.Conn;
            //Sql sætning
            string sqlcom = $"INSERT INTO {tabel}({add}) VALUES ({values})";
            //Sql Command
            SqlCommand cmd = new SqlCommand(sqlcom, conn);

            //Splitter values op, da values består af flere forskellige values, som i denne command skal findes individuelt
            string[] valuess = values.Split(',');

            //add parametre til sql commanden (for hver value i valuess lav en parameter.Add
            //Parametrene finder selv ud af hvilken [string, int, mm.] som skal bruges
            for (int i = 0; i < valuess.Length; i++)
            {
                cmd.Parameters.AddWithValue(valuess[i], data[i]);
            }

            // Parametre at sætte ind i databasen - De to metoder
            /*
            //indsæt parametre med values - her finder den selv ud af, via typen, om det er string int mm.
            cmd.Parameters.AddWithValue("@navn", name);
            // indsæt values hard coded - med valuetype 
            cmd.Parameters.Add("@tlf", System.Data.SqlDbType.Int);
            cmd.Parameters["@tlf"].Value = Convert.ToInt32(phone);
            */

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show($"{tabel} oprettet");
                //MessageBox.Show(sqlCom);
            }
            catch (Exception ecx) { MessageBox.Show(ecx.ToString()); }
            finally { if (conn.State == ConnectionState.Open) { conn.Close(); } }
        }
        public static void Update(string tabel, string add, string where, object[] data)
        {
            string[] adds = add.Split(',');
            // lav en values add for hver value, som er det samme add men med '@' på.
            string values = "";

            for (int i = 0; i < add.Length; i++)
            {
                // Tilføj til string set [ += ]
                values += "@" + add[i];
            }
            SqlConnection conn = Database.Conn;
            //Splitter values op, da values består af flere forskellige values, som i denne command skal findes individuelt
            string[] valuess = values.Split(',');

            string set = "";

            for (int i = 0; i < valuess.Length; i++)
            {
                // Tilføj til string set [ += ]
                set += adds[i] + "=" + valuess[i] + ",";
            }
            //Fjerner det sidste komma, fra sætningen. Da det er illegal SQL.
            set = set.Remove(set.Length - 1, 1);

            string sqlCom = $"UPDATE {tabel} set {set} WHERE {where}";
            //MessageBox.Show(sqlCom);

            SqlCommand cmd = new SqlCommand(sqlCom, Database.Conn);

            //add parametre til sql commanden (for hver value i valuess lav en parameter.Add
            //Parametrene finder selv ud af hvilken [string, int, mm.] som skal bruges
            for (int i = 0; i < valuess.Length; i++)
            {
                cmd.Parameters.AddWithValue(valuess[i], data[i]);
            }

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery(); //SqlDataReader reader = command.ExecuteReader();
                conn.Close();
                MessageBox.Show($"{tabel} opdateret");
                //MessageBox.Show(sqlCom);
            }
            catch (Exception ecx) { MessageBox.Show(ecx.ToString()); }
            finally { if (conn.State == ConnectionState.Open) { conn.Close(); } }
        }
        public static void Delete(string tabel, string delete)
        {
            SqlConnection conn = Database.Conn;
            string sqlCom = $"DELETE {tabel} WHERE {delete}";
            SqlCommand cmd = new SqlCommand(sqlCom, conn);

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery(); //SqlDataReader reader = command.ExecuteReader();
                conn.Close();
                MessageBox.Show($"{tabel} slettet");
                //MessageBox.Show(sqlCom);
            }
            catch (Exception ecx) { MessageBox.Show(ecx.ToString()); }
            finally { if (conn.State == ConnectionState.Open) { conn.Close(); } }
        }
    }
}
