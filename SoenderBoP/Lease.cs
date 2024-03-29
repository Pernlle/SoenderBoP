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
        public Lease()
        {
            InitializeComponent();
            FillDataSource.SetUpDGV(leaseDGV, GetSqlComL());
            FillDataSource.SetUpDGV(readBoligDGV, GetSqlComB());
            FillDataSource.SetUpDGV(readMedlemDGV, GetSqlComM());
        }

        //Knap = Opret
        private void CreateLease_Click(object sender, EventArgs e)
        {
            SqlConnection conn = Database.Conn;

            string mId = mIdTxt.Text; //Få den til at ændre det til mmid når email er valgt :)
            string bId = bIdTxt.Text; // få den til at vælge bid når adresse er valgt :)
            string dato = leaseDTP.Value.ToString("dd-MM-yyyy");

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
                //MessageBox.Show($"Værdier: Id: {mId} | Løbenummer: {loebeNr} | date: {dato}");

                string sqlComUpdateM = $"UPDATE Medlem SET mLNr={loebeNr}, beboer = 1 WHERE mId = {mId}";
                SqlCommand cmdUpdateM = new SqlCommand(sqlComUpdateM, conn);

                cmdUpdateM.Parameters.AddWithValue("@mLNr", loebeNr);
                cmdUpdateM.ExecuteNonQuery();
                //MessageBox.Show("Update medlem done");

                string sqlComUpdateB = $"UPDATE Bolig SET bLNr={loebeNr} WHERE bId = {bId}";
                SqlCommand cmdUpdateB = new SqlCommand(sqlComUpdateB, conn);
                cmdUpdateB.Parameters.AddWithValue("@bLNr", loebeNr);
                cmdUpdateB.ExecuteNonQuery();
                //MessageBox.Show("Update bolig done");

                string sqlComDeleteV = $"DELETE FROM Venteliste WHERE vMid = {mId}";
                SqlCommand cmdDeleteV = new SqlCommand(sqlComDeleteV, conn);
                cmdDeleteV.ExecuteNonQuery();
                MessageBox.Show("Lejekontrakt oprettet");
            }
            catch (Exception ecx) { MessageBox.Show(ecx.ToString()); }
            finally { if (conn.State == ConnectionState.Open) { conn.Close(); } }

            //Opdater dgv
            FillDataSource.SetUpDGV(leaseDGV, GetSqlComL());

        }

        //Knap = Print
        private void leasePrintbtn_Click(object sender, EventArgs e)
        {
            string writerName = $"Resourceforbrug_lease";
            string[] headersarr = new string[] { "Løbenummer", "Adresse", "Indflytter", "Fornavn", "Efternavn", "Email", "Medlem ID" };
            DataGridView dgv = leaseDGV;
            Print.PrintIt(dgv, writerName, headersarr);
        }

        //Hent sql til LeaseDGV
        private static string GetSqlComL()
        {
            string sqlCom = $"SELECT lNr AS 'Løbenummer', adr AS 'Adresse',  lDato AS 'Indflytter',fNavn + ' ' + eNavn AS 'Navn', email AS 'Email', mId AS 'ID' FROM Lejekontrakt, Bolig, Medlem WHERE lNr = mLNr AND lNr = bLNr";
            return sqlCom;
        }

        //Hent sql til MedlemDGV
        private static string GetSqlComM()
        {
            string sqlCom = "SELECT mId AS 'ID',fNavn + ' ' + eNavn AS 'Navn',tlf AS 'Telefonnummer',email AS 'Email' FROM Medlem WHERE mLNr IS NULL";
            return sqlCom;
        }

        //Hent sql til BoligDGV
        private static string GetSqlComB()
        {
            string sqlCom = "SELECT bId AS 'ID', mndPris AS 'Pris pr måned', adr AS 'Adresse', kvm AS 'Kvm', bType AS 'Type af bolig' FROM Bolig, BoligType WHERE bTId = tId AND bLNr IS NULL";
            return sqlCom;
        }

        //Ubrugt kode, der ikke kan fjernes
        private void refreshBtn_Click(object sender, EventArgs e){}
        private void Lease_Load(object sender, EventArgs e){}
        private void emailCBX_Click(object sender, EventArgs e) {}        
        private void leaseAdresseCBX_Click(object sender, EventArgs e) {}
    }
}
