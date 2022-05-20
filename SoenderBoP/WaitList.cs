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
        }

        private void WaitList_Load(object sender, EventArgs e)
        {
            string sqlcom = "SELECT opskrevet AS 'Dato for opskrivelse', fNavn AS 'Fornavn', eNavn AS 'Efternavn', medlemId AS 'Medlems ID' FROM Lejlighed ORDER BY opskrevet ASC";
            lejlighedDGV.DataSource = FillDataSource.GetDataSource(sqlcom);
            DataGridView DGV = lejlighedDGV;
            GetDGVStyle.GetStyle(DGV);

            lejlighedDGV.AllowUserToOrderColumns = false;

            sqlcom = "SELECT opskrevet AS 'Dato for opskrivelse', fNavn AS 'Fornavn', eNavn AS 'Efternavn', medlemId AS 'Medlems ID' FROM Ungdomsbolig ORDER BY opskrevet ASC";
            ungdomsDGV.DataSource = FillDataSource.GetDataSource(sqlcom);
            DGV = ungdomsDGV;
            GetDGVStyle.GetStyle(DGV);

            ungdomsDGV.AllowUserToOrderColumns = false;

            sqlcom = "SELECT opskrevet AS 'Dato for opskrivelse', fNavn AS 'Fornavn', eNavn AS 'Efternavn', medlemId AS 'Medlems ID' FROM Seniorbolig ORDER BY opskrevet ASC";
            seniorDGV.DataSource = FillDataSource.GetDataSource(sqlcom);
            DGV = seniorDGV;
            GetDGVStyle.GetStyle(DGV);

            seniorDGV.AllowUserToOrderColumns = false;

        }

        private void lejlighedDGV_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.lejlighedDGV.Rows[e.RowIndex].Cells["lejlighedNr"].Value = (e.RowIndex + 1).ToString();
        }

        private void ungdomsDGV_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.ungdomsDGV.Rows[e.RowIndex].Cells["ungdomsNr"].Value = (e.RowIndex + 1).ToString();
        }

        private void seniorDGV_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.seniorDGV.Rows[e.RowIndex].Cells["seniorNr"].Value=(e.RowIndex+1).ToString();
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.lejlighedTableAdapter.FillBy(this.waitListViews.Lejlighed);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void lejlighedQToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.lejlighedTableAdapter.lejlighedQ(this.waitListViews.Lejlighed);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void waitlistPrintSBtn_Click(object sender, EventArgs e)
        {
            string writerName = $"Waitlist_Senior";
            //opskrevet AS 'Dato for opskrivelse', fNavn AS 'Fornavn', eNavn AS 'Efternavn', medlemId AS 'Medlems ID'
            string[] headersarr = new string[] { "Dato", "Fornavn", "Efternavn", "Medlems ID" };
            DataGridView dgv = seniorDGV;

            Print.PrintIt(dgv, writerName, headersarr);
        }

        private void waitlistPrintUBtn_Click(object sender, EventArgs e)
        {
            string writerName = $"Waitlist_Ungdom";
            string[] headersarr = new string[] { "Dato", "Fornavn", "Efternavn", "Medlems ID" };
            DataGridView dgv = ungdomsDGV;

            Print.PrintIt(dgv, writerName, headersarr);
        }

        private void waitlistPrintLbtn_Click(object sender, EventArgs e)
        {
            string writerName = $"Waitlist_Lejlighed";
            string[] headersarr = new string[] { "Dato", "Fornavn", "Efternavn", "Medlems ID" };
            DataGridView dgv = lejlighedDGV;

            Print.PrintIt(dgv, writerName, headersarr);
        }        
    }
}
