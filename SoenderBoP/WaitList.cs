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
        string strconn = @"Server=den1.mssql7.gear.host; Database=soenderbodb; User ID=soenderbodb; Password=password!";

        public WaitList()
        {
            InitializeComponent();
        }

        private void WaitList_Load(object sender, EventArgs e)
        {
            lejlighedDGV.DataSource = GetLejlighed();
            ungdomsDGV.DataSource = GetUngdoms();
            seniorDGV.DataSource = GetSenior();

        }

        private DataTable GetLejlighed()
        {
            string sqlcom = "SELECT * FROM Lejlighed ORDER BY opskrevet ASC";
            using (SqlConnection con = new SqlConnection(strconn))
            {
                using (SqlCommand cmd = new SqlCommand(sqlcom, con))
                {
                    using (SqlDataAdapter sda1 = new SqlDataAdapter(cmd))
                    {
                        DataTable dtLejlighed = new DataTable();
                        sda1.Fill(dtLejlighed);
                        return dtLejlighed;
                    }
                }
            }
        }

        private DataTable GetUngdoms()
        {
            string sqlcom = "SELECT * FROM Ungdomsbolig ORDER BY opskrevet ASC";
            using (SqlConnection con = new SqlConnection(strconn))
            {
                using (SqlCommand cmd = new SqlCommand(sqlcom, con))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        DataTable dtUngdoms = new DataTable();
                        sda.Fill(dtUngdoms);
                        return dtUngdoms;
                    }
                }
            }
        }

        private DataTable GetSenior()
        {
            string sqlcom = "SELECT * FROM Seniorbolig ORDER BY opskrevet ASC";
            using (SqlConnection con = new SqlConnection(strconn))
            {
                using (SqlCommand cmd = new SqlCommand(sqlcom, con))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        DataTable dtSenior = new DataTable();
                        sda.Fill(dtSenior);
                        return dtSenior;
                    }
                }
            }
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
    }
}
