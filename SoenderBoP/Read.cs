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
        }

        private void Read_Load(object sender, EventArgs e)
        {
            string sqlcom = "SELECT mId AS 'ID',fNavn AS 'Fornavn',eNavn AS 'Efternavn',tlf AS 'Telefonnummer',email AS 'Email',mLNr AS 'Løbenummer' FROM Medlem";
            readMedlemDGV.DataSource= FillDataSource.GetDataSource(sqlcom);
            DataGridView DGV = readMedlemDGV;
            GetDGVStyle.GetStyle(DGV);
   

            sqlcom = "SELECT bId AS 'ID', mndPris AS 'Måneds pris',adr AS 'Adresse',kvm AS 'Kvm',bType AS 'Bolig type',bLNr AS 'Løbenummer' FROM Bolig";
            readBoligDGV.DataSource = FillDataSource.GetDataSource(sqlcom);
            DGV = readBoligDGV;
            GetDGVStyle.GetStyle(DGV);

            sqlcom = "SELECT * FROM Reservationer";
            readReserveDGV.DataSource = FillDataSource.GetDataSource(sqlcom);
            DGV = readReserveDGV;
            GetDGVStyle.GetStyle(DGV);

            sqlcom = $"SELECT lNr AS 'Løbenummer', adr AS 'Adresse',  lDato AS 'Indflytter', fNavn AS 'Fornavn', eNavn AS 'Efternavn', email AS 'Email', mId AS 'ID' FROM Lejekontrakt, Bolig, Medlem WHERE lNr = mLNr AND lNr = bLNr";
            lDGV.DataSource = FillDataSource.GetDataSource(sqlcom);
            DGV = lDGV;
            GetDGVStyle.GetStyle(DGV);

            sqlcom = "SELECT vDato AS 'Dato for opskrivelse', fNavn AS 'Fornavn', eNavn AS 'Efternavn', vMid AS 'ID' FROM Lejlighed ORDER BY vDato ASC";
            lejlighedDGV.DataSource = FillDataSource.GetDataSource(sqlcom);
            DGV = lejlighedDGV;
            GetDGVStyle.GetStyle(DGV);
            lejlighedDGV.RowHeadersVisible = false;


            sqlcom = "SELECT vDato AS 'Dato for opskrivelse', fNavn AS 'Fornavn', eNavn AS 'Efternavn', vMid AS 'ID' FROM Ungdomsbolig ORDER BY vDato ASC";
            ungdomsDGV.DataSource = FillDataSource.GetDataSource(sqlcom);
            DGV = ungdomsDGV;
            GetDGVStyle.GetStyle(DGV);

            sqlcom = "SELECT vDato AS 'Dato for opskrivelse', fNavn AS 'Fornavn', eNavn AS 'Efternavn', vMid AS 'ID' FROM Seniorbolig ORDER BY vDato ASC";
            seniorDGV.DataSource = FillDataSource.GetDataSource(sqlcom);
            DGV = seniorDGV;
            GetDGVStyle.GetStyle(DGV);
        }


        private void seniorDGV_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
           
                this.seniorDGV.Rows[e.RowIndex].Cells["seniorNr"].Value = (e.RowIndex + 1).ToString();
            
        }

        private void ungdomsDGV_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.ungdomsDGV.Rows[e.RowIndex].Cells["ungdomsNr"].Value = (e.RowIndex + 1).ToString();

        }

        private void lejlighedDGV_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.lejlighedDGV.Rows[e.RowIndex].Cells["lejlighedNr"].Value = (e.RowIndex + 1).ToString();

        }
    }
}
