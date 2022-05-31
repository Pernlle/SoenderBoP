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
    public partial class Create : Form
    {
        public Create()
        {
            InitializeComponent();
            FillDataSource.SetUpDGV(mDGV, GetSqlCom());

        }

        //Hent sql
        public static string GetSqlCom()
        {
            string sqlCom = "SELECT mId AS 'ID',fNavn + ' ' + eNavn AS 'Navn',tlf AS 'Telefonnummer',email AS 'Email', beboer AS 'Status', mLNr AS 'Løbenummer' FROM Medlem";
            return sqlCom;
        }

        //Knap = Opret
        private void createBtn_Click(object sender, EventArgs e)
        {
            //Values fra tekstboxe:
            string fName = fNavnMTxt.Text;
            string eName = eNavnMTxt.Text;
            string phone = tlfMTxt.Text;
            string email = emailMTxt.Text;
            int beboer = 0;
            DBNull loebeNr = DBNull.Value;

            int num = -1;
            if (!int.TryParse(phone, out num))
            {
                Console.WriteLine("Tlf må kun indeholde numre");
            }
            else
            {
                int phoneN = Convert.ToInt32(phone);

                // Sætter values ind i en array, så de kan sendes over i metoderne (CRUD)
                object[] data = { fName, eName, phoneN, email, beboer, loebeNr };

                //hvilken tabel i db som skal arbejdes med
                string insertInto = "Medlem";
                // lav en add for hver parameter? så det kun er add der skal bruges ovre i create via foreach - genbrugelighed.
                //Det er vigtigt at disse er adskildt med [,] og ikke [, ] og at de står i samme rækkefølge i både object, add og value.
                string add = "fNavn,eNavn,tlf,email,beboer,mLNr";
                // lav en values add for hver value? så det kun er add der skal bruges ovre i create via foreach - genbrugelighed.
                string values = "@fNavn,@eNavn,@tlf,@email,@beboer,@mLNr";

                CRUDFacade.Create(insertInto, add, values, data);

                FillDataSource.SetUpDGV(mDGV, GetSqlCom());
            }
        }

        private string fNameMTxt;
        public string GetFNameTxt { get { return fNameMTxt; } set { fNameMTxt = fNavnMTxt.Text; } }        

        //Event = Ændrer 'Beboer' fra 0/1 til Medlem/Beboer 
        private void mDGV_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 4)
                if (e.Value is int)
                    e.Value = (int)e.Value == 0 ? "Medlem" : "Beboer";
        }

        //Ubrugt kode, der ikke kan fjernes
        private void Create_Load(object sender, EventArgs e) { }

    }
}
