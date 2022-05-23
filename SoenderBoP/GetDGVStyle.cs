﻿using System;
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
            DGV.GridColor = Color.FromKnownColor(KnownColor.Gainsboro);
            DGV.RowHeadersVisible = false;
            DGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGV.Dock = DockStyle.Fill;
            DGV.BorderStyle = BorderStyle.None;
            DGV.Location = new Point(8, 8);
            DGV.Size = new Size(500, 250);

            DGV.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            DGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            /*
                Cells style:
             */

            DGV.CellBorderStyle = DataGridViewCellBorderStyle.RaisedVertical;
            DGV.DefaultCellStyle.BackColor = Color.FromKnownColor(KnownColor.Linen);
            DGV.DefaultCellStyle.ForeColor = Color.FromKnownColor(KnownColor.ControlText);
            DGV.DefaultCellStyle.SelectionBackColor = Color.FromKnownColor(KnownColor.Linen);
            DGV.DefaultCellStyle.SelectionForeColor = Color.FromKnownColor(KnownColor.ControlText);
            DGV.DefaultCellStyle.Font = new Font("Microsoft JhengHei UI", 11);
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
            DGV.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft JhengHei UI", 11);
            DGV.ColumnHeadersDefaultCellStyle.Padding = new Padding(1);
            DGV.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False;
            DGV.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DGV.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;

            DGV.AllowUserToOrderColumns = false;

            return DGV;
        }
    }
}
