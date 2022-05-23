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
    public partial class Create : Form
    {
        public Create()
        {
            InitializeComponent();
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            //Values fra tekstboxe:
            string fName = fNavnMTxt.Text;
            string eName = eNavnMTxt.Text;
            int phone = Convert.ToInt32(tlfMTxt.Text);
            string email = emailMTxt.Text;

            // Sætter values ind i en array, så de kan sendes over i metoderne (CRUD)
            object[] data = { fName, eName, phone, email};

            //hvilken tabel i db som skal arbejdes med
            string insertInto = "Medlem";
            // lav en add for hver parameter? så det kun er add der skal bruges ovre i create via foreach - genbrugelighed.
            //Det er vigtigt at disse er adskildt med [,] og ikke [, ] og at de står i samme rækkefølge i både object, add og value.
            string add = "fNavn,eNavn,tlf,email";
            // lav en values add for hver value? så det kun er add der skal bruges ovre i create via foreach - genbrugelighed.
            string values = "@fNavn,@eNavn,@tlf,@email";

            CRUD.CreateMedlem(insertInto, add, values, data);
        }
        private string fNameMTxt;
        public string GetFNameTxt { get { return fNameMTxt; } set { fNameMTxt = fNavnMTxt.Text; } }

        private void Create_Load(object sender, EventArgs e)
        {
            string sqlcom = "SELECT mId AS 'ID',fNavn AS 'Fornavn',eNavn AS 'Efternavn',tlf AS 'Telefonnummer',email AS 'Email',mLNr AS 'Løbenummer' FROM Medlem";
            mDGV.DataSource = FillDataSource.GetDataSource(sqlcom);
            DataGridView DGV = mDGV;
            GetDGVStyle.GetStyle(DGV);
        }
    }
}
