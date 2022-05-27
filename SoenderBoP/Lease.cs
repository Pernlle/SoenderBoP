﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SoenderBoP
{
    public partial class Lease : Form
    {
        string strconn = @"Server=den1.mssql7.gear.host; Database=soenderbodb; User ID=soenderbodb; Password=password!";

        public Lease()
        {
            InitializeComponent();
            string sqlcom = $"SELECT lNr AS 'Løbenummer', adr AS 'Adresse',  lDato AS 'Indflytter', fNavn AS 'Fornavn', eNavn AS 'Efternavn', email AS 'Email', mId AS 'ID' FROM Lejekontrakt, Bolig, Medlem WHERE lNr = mLNr AND lNr = bLNr";
            leaseDGV.DataSource = FillDataSource.GetDataSource(sqlcom);

            DataGridView DGV = leaseDGV;
            GetDGVStyle.GetStyle(DGV);
        }

        private void CreateLease_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(strconn);

            string mId = mIdTxt.Text; //Få den til at ændre det til mmid når email er valgt :)
            string bId = bIdTxt.Text; // få den til at vælge bid når adresse er valgt :)
            string dato = leaseDTP.Value.ToString("dd-MM-yyyy");

            //string insertInto = "Lejekontrakt";
            //object[] data = { dato };
            ////Det er vigtigt at disse er adskildt med [,] og ikke [, ] og at de står i samme rækkefølge i både object, add og value.
            //string add = "lDato";
            //// lav en values add for hver value? så det kun er add der skal bruges ovre i create via foreach - genbrugelighed.
            //string values = "@lDato";

            //CRUD.Create(insertInto, add, values, data);

            string sqlCom = $"INSERT INTO Lejekontrakt(lDato) VALUES(@lDato)";


            //Sql Command
            SqlCommand cmd = new SqlCommand(sqlCom, conn);

            cmd.Parameters.AddWithValue("@lDato", dato);
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
            }

            catch (Exception ecx) { MessageBox.Show(ecx.ToString()); }
            finally { if (conn.State == ConnectionState.Open) { conn.Close(); } }

            try
            {
                conn.Open();
                string sqlLoebeNr = $"SELECT TOP 1 * FROM Lejekontrakt ORDER BY lNr DESC";
                SqlCommand cmdd = new SqlCommand(sqlLoebeNr, conn);


                var loebeNr = (Int32)cmdd.ExecuteScalar();
                //Test om de rigtige værdier kan puttes i db
                MessageBox.Show($"Værdier: Id: {mId} | Løbenummer: {loebeNr} | date: {dato}");

                string sqlComUpdateM = $"UPDATE Medlem SET mLNr={loebeNr} WHERE mId = {mId}";
                SqlCommand cmdUpdateM = new SqlCommand(sqlComUpdateM, conn);

                cmdUpdateM.Parameters.AddWithValue("@mLNr", loebeNr);
                cmdUpdateM.ExecuteNonQuery();
                MessageBox.Show("Update medlem done");

                string sqlComUpdateB = $"UPDATE Bolig SET bLNr={loebeNr} WHERE bId = {bId}";
                SqlCommand cmdUpdateB = new SqlCommand(sqlComUpdateB, conn);
                cmdUpdateB.Parameters.AddWithValue("@bLNr", loebeNr);
                cmdUpdateB.ExecuteNonQuery();
                MessageBox.Show("Update bolig done");

                string sqlComDeleteV = $"DELETE FROM Venteliste WHERE vMid = {mId}";
                SqlCommand cmdDeleteV = new SqlCommand(sqlComDeleteV, conn);
                cmdDeleteV.ExecuteNonQuery();
                MessageBox.Show("Delete venteliste done");
            }
            catch (Exception ecx) { MessageBox.Show(ecx.ToString()); }
            finally { if (conn.State == ConnectionState.Open) { conn.Close(); } }
            
        }

        private void emailCBX_Click(object sender, EventArgs e)
        {
            string sqlcom = "SELECT email FROM Medlem";
            emailCBX.DataSource = FillDataSource.GetDataSource(sqlcom);
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            this.leaseDGV.Refresh();
            this.leaseDGV.Update();
        }

        private void Lease_Load(object sender, EventArgs e)
        {

        }

        private void leaseAdresseCBX_Click(object sender, EventArgs e)
        {
            string sqlcom = "SELECT adr FROM Bolig";
            leaseAdresseCBX.DataSource = FillDataSource.GetDataSource(sqlcom);
        }
    }
}
