using System;
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
    public partial class WaitList : Form
    {
        public WaitList()
        {
            InitializeComponent();
            string sqlcom = "SELECT vDato AS 'Dato for opskrivelse', fNavn + ' ' + eNavn AS 'Navn', vMId AS 'ID' FROM Lejlighed ORDER BY vDato ASC";
            lejlighedDGV.DataSource = FillDataSource.GetDataSource(sqlcom);
            DataGridView DGV = lejlighedDGV;
            GetDGVStyle.GetStyle(DGV);

            sqlcom = "SELECT vDato AS 'Dato for opskrivelse', fNavn + ' ' + eNavn AS 'Navn', vMId AS 'ID' FROM Ungdomsbolig ORDER BY vDato ASC";
            ungdomsDGV.DataSource = FillDataSource.GetDataSource(sqlcom);
            DGV = ungdomsDGV;
            GetDGVStyle.GetStyle(DGV);

            sqlcom = "SELECT vDato AS 'Dato for opskrivelse',fNavn + ' ' + eNavn AS 'Navn', vMId AS 'ID' FROM Seniorbolig ORDER BY vDato ASC";
            seniorDGV.DataSource = FillDataSource.GetDataSource(sqlcom);
            DGV = seniorDGV;
            GetDGVStyle.GetStyle(DGV);
        }

        //Event = Nr til venteliste
        private void lejlighedDGV_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.lejlighedDGV.Rows[e.RowIndex].Cells["lejlighedNr"].Value = (e.RowIndex + 1).ToString();
        }

        //Event = Nr til venteliste
        private void ungdomsDGV_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.ungdomsDGV.Rows[e.RowIndex].Cells["ungdomsNr"].Value = (e.RowIndex + 1).ToString();
        }

        //Event = Nr til venteliste
        private void seniorDGV_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.seniorDGV.Rows[e.RowIndex].Cells["seniorNr"].Value=(e.RowIndex+1).ToString();
        }

        //Knap = Print lejlighed
        private void waitlistPrintLbtn_Click(object sender, EventArgs e)
        {
            string writerName = $"Waitlist_Lejlighed";
            string title = $"Venteliste til lejlighed";
            string[] headersarr = new string[] { "Dato", "Fornavn", "Efternavn", "ID" };
            DataGridView dgv = lejlighedDGV;

            Print.PrintIt(dgv, writerName, headersarr, title);
        }

        //Knap = Print ungdoms
        private void waitlistPrintUBtn_Click(object sender, EventArgs e)
        {
            string writerName = $"Waitlist_Ungdom";
            string title = $"Venteliste til ungdomsbolig";
            string[] headersarr = new string[] { "Dato", "Fornavn", "Efternavn", "ID" };
            DataGridView dgv = ungdomsDGV;

            Print.PrintIt(dgv, writerName, headersarr, title);
        }

        //Knap = Print senior
        private void waitlistPrintSBtn_Click(object sender, EventArgs e)
        {
            string writerName = $"Waitlist_Senior";
            string title = $"NogetTredje";
            //opskrevet AS 'Dato for opskrivelse', fNavn AS 'Fornavn', eNavn AS 'Efternavn', medlemId AS 'Medlems ID'
            string[] headersarr = new string[] { "Dato", "Navn", "ID" };
            DataGridView dgv = seniorDGV;

            Print.PrintIt(dgv, writerName, headersarr, title);
        }


        //Knap = Tilføj lejlighed
        private void createLBTN_Click(object sender, EventArgs e)
        {
            string mId = this.lmIdTXT.Text;
            string opskrevet = lDTP.Value.ToString("mm-dd-yyyy");
            int boligType = 1;

            // Sætter values ind i en array, så de kan sendes over i metoderne (CRUD)
            object[] data = { mId, opskrevet, boligType };

            //hvilken tabel i db som skal arbejdes med
            string insertInto = "Venteliste";
            // lav en add for hver parameter? så det kun er add der skal bruges ovre i create via foreach - genbrugelighed.
            //Det er vigtigt at disse er adskildt med [,] og ikke [, ] og at de står i samme rækkefølge i både object, add og value.
            string add = "vMId,vDato,vTId";
            // lav en values add for hver value? så det kun er add der skal bruges ovre i create via foreach - genbrugelighed.
            string values = "@vMId,@vDato,@vTId";

            CRUDFacade.Create(insertInto, add, values, data);
            string sqlcom = "SELECT vDato AS 'Dato for opskrivelse', fNavn + ' ' + eNavn AS 'Navn', vMId AS 'ID' FROM Lejlighed ORDER BY vDato ASC";
            FillDataSource.SetUpDGV(lejlighedDGV, sqlcom);
        }

        //Knap = Tilføj ungdoms
        private void createUBTN_Click(object sender, EventArgs e)
        {
            string mId = this.umIdTXT.Text;
            string dato = uDTP.Value.ToString("mm-dd-yyyy");
            int boligType = 2;

            // Sætter values ind i en array, så de kan sendes over i metoderne (CRUD)
            object[] data = { mId, dato, boligType };

            //hvilken tabel i db som skal arbejdes med
            string insertInto = "Venteliste";
            // lav en add for hver parameter? så det kun er add der skal bruges ovre i create via foreach - genbrugelighed.
            //Det er vigtigt at disse er adskildt med [,] og ikke [, ] og at de står i samme rækkefølge i både object, add og value.
            string add = "vMId,vDato,vTId";
            // lav en values add for hver value? så det kun er add der skal bruges ovre i create via foreach - genbrugelighed.
            string values = "@vMId,@vDato,@vTId";

            CRUDFacade.Create(insertInto, add, values, data);

            string sqlcom = "SELECT vDato AS 'Dato for opskrivelse', fNavn + ' ' + eNavn AS 'Navn', vMId AS 'ID' FROM Ungdomsbolig ORDER BY vDato ASC";
            FillDataSource.SetUpDGV(ungdomsDGV, sqlcom);

        }
        
        //Knap = Tilføj Senior
        private void createSBTN_Click(object sender, EventArgs e)
        {
            string mId = this.smIdTXT.Text;
            string opskrevet = sDTP.Value.ToString("mm-dd-yyyy");
            int boligType = 3;

            // Sætter values ind i en array, så de kan sendes over i metoderne (CRUD)
            object[] data = { mId, opskrevet, boligType };

            //hvilken tabel i db som skal arbejdes med
            string insertInto = "Venteliste";
            // lav en add for hver parameter? så det kun er add der skal bruges ovre i create via foreach - genbrugelighed.
            //Det er vigtigt at disse er adskildt med [,] og ikke [, ] og at de står i samme rækkefølge i både object, add og value.
            string add = "vMid,vDato,vTId";
            // lav en values add for hver value? så det kun er add der skal bruges ovre i create via foreach - genbrugelighed.
            string values = "@vMId,@vDato,@vTId";

            CRUDFacade.Create(insertInto, add, values, data);

            string sqlcom = "SELECT vDato AS 'Dato for opskrivelse', fNavn + ' ' + eNavn AS 'Navn', vMId AS 'ID' FROM Seniorbolig ORDER BY vDato ASC";
            FillDataSource.SetUpDGV(seniorDGV, sqlcom);

        }

        //Ubrugt kode
        private void WaitList_Load(object sender, EventArgs e) {}
        private void lejlighedQToolStripButton_Click(object sender, EventArgs e){try{this.lejlighedTableAdapter.lejlighedQ(this.waitListViews.Lejlighed);}catch (System.Exception ex){System.Windows.Forms.MessageBox.Show(ex.Message);}}
        private void fillByToolStripButton_Click(object sender, EventArgs e) { try { this.lejlighedTableAdapter.FillBy(this.waitListViews.Lejlighed); } catch (System.Exception ex) { System.Windows.Forms.MessageBox.Show(ex.Message); } }

    }
}
