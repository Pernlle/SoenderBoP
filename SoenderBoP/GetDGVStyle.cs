using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoenderBoP
{
    internal class GetDGVStyle
    {
        public static DataGridView GetStyle(DataGridView DGV)
        {

            //
            DGV.BackgroundColor = Color.FromKnownColor(KnownColor.Linen); // baggrunden bag ved dgv
            DGV.DefaultCellStyle.BackColor = Color.FromKnownColor(KnownColor.Linen); //celle farve :)

            /*
                Cells style:
             */

            DGV.DefaultCellStyle.BackColor = Color.FromKnownColor(KnownColor.Linen);
            DGV.DefaultCellStyle.ForeColor = Color.FromKnownColor(KnownColor.ControlText);
            DGV.DefaultCellStyle.SelectionBackColor = Color.FromKnownColor(KnownColor.ControlLight);
            DGV.DefaultCellStyle.SelectionForeColor = Color.FromKnownColor(KnownColor.ControlText);
            DGV.DefaultCellStyle.Font = new Font("Microsoft JhengHei UI", 14);
            DGV.DefaultCellStyle.Padding = new Padding(2);
            DGV.DefaultCellStyle.WrapMode = DataGridViewTriState.False;
            DGV.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            /*
                Header cells style:
             */

            DGV.ColumnHeadersDefaultCellStyle.BackColor = Color.FromKnownColor(KnownColor.Linen);
            DGV.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromKnownColor(KnownColor.ControlText);
            DGV.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromKnownColor(KnownColor.ControlLight);
            DGV.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.FromKnownColor(KnownColor.ControlText);
            DGV.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft JhengHei UI", 12);
            DGV.ColumnHeadersDefaultCellStyle.Padding = new Padding(2);
            DGV.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False;
            DGV.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;


            DGV.Location = new Point(8, 8);
            DGV.Size = new Size(500, 250);

            DGV.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            DGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            DGV.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            DGV.CellBorderStyle = DataGridViewCellBorderStyle.Single;

            DGV.GridColor = Color.Black;

            DGV.RowHeadersVisible = false;

            DGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGV.MultiSelect = false;
            DGV.Dock = DockStyle.Fill;

         

            //Allow User to:
            DGV.AllowDrop = false;
            DGV.AllowUserToAddRows = false;
            DGV.AllowUserToResizeRows = false;
            DGV.AllowUserToResizeColumns = false;
            DGV.AllowUserToDeleteRows = false;

            return DGV;
        }
    }
}
