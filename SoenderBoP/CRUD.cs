﻿using System;
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
    internal class CRUD
    {
       // Lige nu har vi meget memoryleak, da vi åbner en ny connection HVER evig eneste gang at vi laver/opdatere eller sletter fra databasen med disse input.
       
        public static void Create(string insertInto, string add, string values, object[] data)
        {
            string strconn = @"Server=den1.mssql7.gear.host; Database=soenderbodb; User ID=soenderbodb; Password=Ju7XZj_8pI2_";
            //Sql Connection
            SqlConnection conn = new SqlConnection(strconn);
            //Sql sætning
            string sqlCom = $"INSERT INTO {insertInto}({add}, loebeNr) VALUES ({values}, @loebeNr);";
            //Sql Command
            SqlCommand cmd = new SqlCommand(sqlCom, conn);


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

            cmd.Parameters.Add("@loebeNr", System.Data.SqlDbType.Int);
            cmd.Parameters["@loebeNr"].Value = DBNull.Value;


            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show($"{insertInto} oprettet");
                //MessageBox.Show(sqlCom);
            }
            catch (Exception ecx) { MessageBox.Show(ecx.ToString()); }

        }
        public static void Update(string insertInto, string add, string where, string values, object[] data)
        {
            string strconn = @"Server=den1.mssql7.gear.host; Database=soenderbodb; User ID=soenderbodb; Password=Ju7XZj_8pI2_";


            string[] valuess = values.Split(',');
            string[] adds = add.Split(',');

            string set = "";

            for (int i = 0; i < valuess.Length; i++)
            {
                // Tilføj til string set [ += ]
                set += adds[i] + "=" + valuess[i] + ",";
            }
            //Fjerner det sidste komma, fra sætningen. Da det er illegal SQL.
            set = set.Remove(set.Length - 1, 1);
            
            SqlConnection conn = new SqlConnection(strconn);
            string sqlCom = $"UPDATE {insertInto} set {set} WHERE {where};";
            //MessageBox.Show(sqlCom);

            SqlCommand cmd = new SqlCommand(sqlCom, conn);

            //Splitter values op, da values består af flere forskellige values, som i denne command skal findes individuelt
           
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
                MessageBox.Show($"{insertInto} opdateret");
                //MessageBox.Show(sqlCom);
            }
            catch (Exception ecx) { MessageBox.Show(ecx.ToString()); }
        }
        public static void Delete(string insertInto, string delete, string cellValue)
        {
            string strconn = @"Server=den1.mssql7.gear.host; Database=soenderbodb; User ID=soenderbodb; Password=Ju7XZj_8pI2_";

            SqlConnection conn = new SqlConnection(strconn);
            string sqlCom = $"DELETE Venteliste WHERE medlemId = {cellValue}; DELETE {insertInto} WHERE {delete};";

            SqlCommand cmd = new SqlCommand(sqlCom, conn);

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery(); //SqlDataReader reader = command.ExecuteReader();
                conn.Close();
                MessageBox.Show($"{insertInto} slettet");
                //MessageBox.Show(sqlCom);
            }
            catch (Exception ecx) { MessageBox.Show(ecx.ToString()); }
        }
    }
}
