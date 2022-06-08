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
    public partial class Reservation : Form
    {
        public Reservation()
        {
            InitializeComponent();
            //ressource dgv fill
            FillDataSource.SetUpDGV(ressourceDGV, GetSqlComR());
            //reserveret dgv fill
            FillDataSource.SetUpDGV(reserveDGV, GetSqlComR());
        }

        //Knap = Se ID
        private void seIdbtn_Click(object sender, EventArgs e)
        {
            FillDataSource.SetUpDGV(ressourceDGV, GetSqlComRR());
        }

        //Knap = Reserver
        public void reserveBtn_Click(object sender, EventArgs e)
        {
            string loebeNr = this.loebeNr.Text;
            string rId = this.rId.Text;

            string daStartDag = dStartDag.Text;
            string daStartMaaned = dStartMaaned.Text;
            string daStartAar = dStartAar.Text;
            string daStartTime = dStartTime.Text;
            string daStartMinut = dStartMinut.Text;

            string daSlutDag = dSlutDag.Text;
            string daSlutMaaned = dSlutMaaned.Text;
            string daSlutAar = dSlutAar.Text;
            string daSlutTime = dSlutTime.Text;
            string daSlutMinut = dSlutMinut.Text;

            string dStart = daStartDag + "-" + daStartMaaned + "-" + daStartAar + " " + daStartTime + ":" + daStartMinut;
            string dSlut = daSlutDag + "-" + daSlutMaaned + "-" + daSlutAar + " " + daSlutTime + ":" + daSlutMinut;

            string insertInto = "Reserveret";
            object[] data = { loebeNr, rId, dStart, dSlut };
            string add = "rLNr,rRId,dStart,dSlut";

            CRUD.Create(insertInto, add, data);
        }

        //Henter sql
        private static string GetSqlComRR()
        {
            string sqlCom = "SELECT rId AS 'Ressource ID', rType AS 'Ressource', rNr AS 'Nr.' FROM Ressource";
            return sqlCom;
        }

        //Henter sql
        private static string GetSqlComR()
        {
            string sqlCom = "SELECT lNr AS 'Løbenummer', rType AS 'Ressource', rNr AS 'Nr', dStart AS 'Fra', dSlut AS 'Til', fNavn + ' ' + eNavn AS 'Navn', mId AS 'Medlem ID' FROM Reserveret, Medlem, Ressource, Lejekontrakt WHERE lNr = mLNr AND rRId = rId AND lNr = rLNr";
            return sqlCom;
        }

        //Ubrugt kode
        private void Reservation_Load(object sender, EventArgs e) {}
    }
}
