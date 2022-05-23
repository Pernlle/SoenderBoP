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

            sqlcom = "SELECT rId AS 'ID', rType AS 'Ressource', rNr AS 'Nr.' FROM Ressource";
            readReserveDGV.DataSource = FillDataSource.GetDataSource(sqlcom);
            DGV = readReserveDGV;
            GetDGVStyle.GetStyle(DGV);
        }
    }
}
