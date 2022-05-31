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
    public partial class Read : Form
    {
        public Read()
        {
            InitializeComponent();
            FillDataSource.SetUpDGV(readMedlemDGV, GetSqlComM());
            FillDataSource.SetUpDGV(readBoligDGV, GetSqlComB());
            FillDataSource.SetUpDGV(readReserveDGV, GetSqlComR());
            FillDataSource.SetUpDGV(readLeaseDGV, GetSqlComL());
            FillDataSource.SetUpDGV(lejlighedDGV, GetSqlComWL());
            FillDataSource.SetUpDGV(ungdomsDGV, GetSqlComWU());
            FillDataSource.SetUpDGV(seniorDGV, GetSqlComWS());
        }

        //Event = Laver venteliste nr
        private void seniorDGV_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
           this.seniorDGV.Rows[e.RowIndex].Cells["seniorNr"].Value = (e.RowIndex + 1).ToString();
        }

        //Event = Laver venteliste nr
        private void ungdomsDGV_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
           this.ungdomsDGV.Rows[e.RowIndex].Cells["ungdomsNr"].Value = (e.RowIndex + 1).ToString();
        }

        //Event = Laver venteliste nr
        private void lejlighedDGV_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
           this.lejlighedDGV.Rows[e.RowIndex].Cells["lejlighedNr"].Value = (e.RowIndex + 1).ToString();
        }

        //Event = Ændrer 'beboer' i DGV fra 0-1 til Medlem / Beboer for bruger
        private void readMedlemDGV_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 4)
                if (e.Value is int)
                    e.Value = (int)e.Value == 0 ? "Medlem" : "Beboer";
        }

        //Hent sql til medlem
        public static string GetSqlComM()
        {
            string sqlCom = "SELECT mId AS 'ID',fNavn + ' ' + eNavn AS 'Navn',tlf AS 'Telefonnummer',email AS 'Email', beboer AS 'Status', mLNr AS 'Løbenummer' FROM Medlem";
            return sqlCom;
        }

        //Hent sql til bolig
        public static string GetSqlComB()
        {
            string sqlCom = "SELECT bId AS 'ID', mndPris AS 'Måneds pris', adr AS 'Adresse',kvm AS 'Kvm', bType AS 'Type', bLNr AS 'Løbenummer' FROM Bolig, BoligType WHERE bTId = tId";
            return sqlCom;
        }

        //Hent sql til reservationer
        public static string GetSqlComR()
        {
            string sqlCom = "SELECT rType AS 'Ressource', rNr AS 'Nr', dStart AS 'Fra', dSlut AS 'Til', fNavn + ' ' + eNavn AS 'Navn', mId AS 'Medlem ID' FROM Reserveret, Medlem, Ressource, Lejekontrakt WHERE lNr = mLNr AND rRId = rId AND lNr = rLNr";
            return sqlCom;
        }

        //Hent sql til lejekontrakt
        public static string GetSqlComL()
        {
            string sqlCom = $"SELECT lNr AS 'Løbenummer', adr AS 'Adresse', lDato AS 'Indflytter', fNavn + ' ' + eNavn AS 'Navn', email AS 'Email', mId AS 'ID' FROM Lejekontrakt, Bolig, Medlem WHERE lNr = mLNr AND lNr = bLNr";
            return sqlCom;
        }

        //Hent sql til venteliste lejlighed
        public static string GetSqlComWL()
        {
            string sqlCom = "SELECT vDato AS 'Dato for opskrivelse', fNavn + ' ' + eNavn AS 'Navn', vMId AS 'ID' FROM Lejlighed ORDER BY vDato ASC";
            return sqlCom;
        }

        //Hent sql til venteliste ungdoms
        public static string GetSqlComWU()
        {
            string sqlCom = "SELECT vDato AS 'Dato for opskrivelse', fNavn + ' ' + eNavn AS 'Navn', vMId AS 'ID' FROM Ungdomsbolig ORDER BY vDato ASC";
            return sqlCom;
        }

        //Hent sql til venteliste senior
        public static string GetSqlComWS()
        {
            string sqlCom = "SELECT vDato AS 'Dato for opskrivelse',fNavn + ' ' + eNavn AS 'Navn', vMId AS 'ID' FROM Seniorbolig ORDER BY vDato ASC";
            return sqlCom;
        }

        //Ubrugt kode der ikke kan fjernes
        private void Read_Load(object sender, EventArgs e) { }
    }
}
