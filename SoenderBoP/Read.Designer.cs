namespace SoenderBoP
{
    partial class Read
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.readMedlemDGV = new System.Windows.Forms.DataGridView();
            this.medlemBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.soenderbodbDataSet = new SoenderBoP.soenderbodbDataSet();
            this.medlemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.readBoligDGV = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.readReserveDGV = new System.Windows.Forms.DataGridView();
            this.boligBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reserveretBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.soenderbodbDataSet1 = new SoenderBoP.soenderbodbDataSet1();
            this.boligTableAdapter = new SoenderBoP.soenderbodbDataSetTableAdapters.BoligTableAdapter();
            this.medlemTableAdapter = new SoenderBoP.soenderbodbDataSetTableAdapters.MedlemTableAdapter();
            this.reserveretTableAdapter = new SoenderBoP.soenderbodbDataSet1TableAdapters.ReserveretTableAdapter();
            this.reserveretBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.reserveretTableAdapter1 = new SoenderBoP.soenderbodbDataSetTableAdapters.ReserveretTableAdapter();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.ventelister = new System.Windows.Forms.TabControl();
            this.lejlighed = new System.Windows.Forms.TabPage();
            this.Ungdomsbolig = new System.Windows.Forms.TabPage();
            this.lejlighedDGV = new System.Windows.Forms.DataGridView();
            this.lejlighedNr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ungdomsDGV = new System.Windows.Forms.DataGridView();
            this.ungdomsNr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seniorbolig = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.readMedlemDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medlemBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soenderbodbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medlemBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.readBoligDGV)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.readReserveDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boligBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reserveretBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soenderbodbDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reserveretBindingSource1)).BeginInit();
            this.tabPage5.SuspendLayout();
            this.ventelister.SuspendLayout();
            this.lejlighed.SuspendLayout();
            this.Ungdomsbolig.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lejlighedDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ungdomsDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // readMedlemDGV
            // 
            this.readMedlemDGV.BackgroundColor = System.Drawing.Color.Linen;
            this.readMedlemDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.readMedlemDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.readMedlemDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.readMedlemDGV.Location = new System.Drawing.Point(3, 4);
            this.readMedlemDGV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.readMedlemDGV.Name = "readMedlemDGV";
            this.readMedlemDGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.readMedlemDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.readMedlemDGV.RowTemplate.Height = 28;
            this.readMedlemDGV.Size = new System.Drawing.Size(786, 401);
            this.readMedlemDGV.TabIndex = 0;
            // 
            // medlemBindingSource1
            // 
            this.medlemBindingSource1.DataMember = "Medlem";
            this.medlemBindingSource1.DataSource = this.soenderbodbDataSet;
            // 
            // soenderbodbDataSet
            // 
            this.soenderbodbDataSet.DataSetName = "soenderbodbDataSet";
            this.soenderbodbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // medlemBindingSource
            // 
            this.medlemBindingSource.DataMember = "Medlem";
            this.medlemBindingSource.DataSource = this.soenderbodbDataSet;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.readMedlemDGV);
            this.tabPage1.Location = new System.Drawing.Point(4, 37);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Size = new System.Drawing.Size(792, 409);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Medlem";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.readBoligDGV);
            this.tabPage2.Location = new System.Drawing.Point(4, 37);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Size = new System.Drawing.Size(792, 409);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Bolig";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // readBoligDGV
            // 
            this.readBoligDGV.BackgroundColor = System.Drawing.Color.Linen;
            this.readBoligDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.readBoligDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.readBoligDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.readBoligDGV.Location = new System.Drawing.Point(3, 4);
            this.readBoligDGV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.readBoligDGV.Name = "readBoligDGV";
            this.readBoligDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.readBoligDGV.RowTemplate.Height = 24;
            this.readBoligDGV.Size = new System.Drawing.Size(786, 401);
            this.readBoligDGV.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.readReserveDGV);
            this.tabPage3.Location = new System.Drawing.Point(4, 37);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage3.Size = new System.Drawing.Size(792, 409);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Reservationer";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // readReserveDGV
            // 
            this.readReserveDGV.BackgroundColor = System.Drawing.Color.Linen;
            this.readReserveDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.readReserveDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.readReserveDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.readReserveDGV.Location = new System.Drawing.Point(3, 4);
            this.readReserveDGV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.readReserveDGV.Name = "readReserveDGV";
            this.readReserveDGV.RowHeadersWidth = 51;
            this.readReserveDGV.RowTemplate.Height = 24;
            this.readReserveDGV.Size = new System.Drawing.Size(786, 401);
            this.readReserveDGV.TabIndex = 0;
            // 
            // boligBindingSource
            // 
            this.boligBindingSource.DataMember = "Bolig";
            this.boligBindingSource.DataSource = this.soenderbodbDataSet;
            // 
            // reserveretBindingSource
            // 
            this.reserveretBindingSource.DataMember = "Reserveret";
            this.reserveretBindingSource.DataSource = this.soenderbodbDataSet1;
            // 
            // soenderbodbDataSet1
            // 
            this.soenderbodbDataSet1.DataSetName = "soenderbodbDataSet1";
            this.soenderbodbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // boligTableAdapter
            // 
            this.boligTableAdapter.ClearBeforeFill = true;
            // 
            // medlemTableAdapter
            // 
            this.medlemTableAdapter.ClearBeforeFill = true;
            // 
            // reserveretTableAdapter
            // 
            this.reserveretTableAdapter.ClearBeforeFill = true;
            // 
            // reserveretBindingSource1
            // 
            this.reserveretBindingSource1.DataMember = "Reserveret";
            this.reserveretBindingSource1.DataSource = this.soenderbodbDataSet;
            // 
            // reserveretTableAdapter1
            // 
            this.reserveretTableAdapter1.ClearBeforeFill = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 37);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(792, 409);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Lejekontrakter";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.ventelister);
            this.tabPage5.Location = new System.Drawing.Point(4, 37);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(792, 409);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Ventelister";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // ventelister
            // 
            this.ventelister.Controls.Add(this.lejlighed);
            this.ventelister.Controls.Add(this.Ungdomsbolig);
            this.ventelister.Controls.Add(this.seniorbolig);
            this.ventelister.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ventelister.Location = new System.Drawing.Point(3, 3);
            this.ventelister.Name = "ventelister";
            this.ventelister.SelectedIndex = 0;
            this.ventelister.Size = new System.Drawing.Size(786, 403);
            this.ventelister.TabIndex = 0;
            // 
            // lejlighed
            // 
            this.lejlighed.Controls.Add(this.lejlighedDGV);
            this.lejlighed.Location = new System.Drawing.Point(4, 37);
            this.lejlighed.Name = "lejlighed";
            this.lejlighed.Padding = new System.Windows.Forms.Padding(3);
            this.lejlighed.Size = new System.Drawing.Size(778, 362);
            this.lejlighed.TabIndex = 0;
            this.lejlighed.Text = "Lejlighed";
            this.lejlighed.UseVisualStyleBackColor = true;
            // 
            // Ungdomsbolig
            // 
            this.Ungdomsbolig.Controls.Add(this.ungdomsDGV);
            this.Ungdomsbolig.Location = new System.Drawing.Point(4, 37);
            this.Ungdomsbolig.Name = "Ungdomsbolig";
            this.Ungdomsbolig.Padding = new System.Windows.Forms.Padding(3);
            this.Ungdomsbolig.Size = new System.Drawing.Size(778, 362);
            this.Ungdomsbolig.TabIndex = 1;
            this.Ungdomsbolig.Text = "Ungdomsbolig";
            this.Ungdomsbolig.UseVisualStyleBackColor = true;
            // 
            // lejlighedDGV
            // 
            this.lejlighedDGV.AllowUserToAddRows = false;
            this.lejlighedDGV.AllowUserToDeleteRows = false;
            this.lejlighedDGV.AllowUserToResizeColumns = false;
            this.lejlighedDGV.AllowUserToResizeRows = false;
            this.lejlighedDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.lejlighedDGV.BackgroundColor = System.Drawing.Color.Linen;
            this.lejlighedDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lejlighedDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.lejlighedDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.lejlighedDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lejlighedDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lejlighedNr});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Linen;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(1);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.lejlighedDGV.DefaultCellStyle = dataGridViewCellStyle1;
            this.lejlighedDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lejlighedDGV.GridColor = System.Drawing.Color.Gainsboro;
            this.lejlighedDGV.Location = new System.Drawing.Point(3, 3);
            this.lejlighedDGV.Margin = new System.Windows.Forms.Padding(0);
            this.lejlighedDGV.MultiSelect = false;
            this.lejlighedDGV.Name = "lejlighedDGV";
            this.lejlighedDGV.ReadOnly = true;
            this.lejlighedDGV.RowHeadersVisible = false;
            this.lejlighedDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.lejlighedDGV.RowTemplate.Height = 28;
            this.lejlighedDGV.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.lejlighedDGV.Size = new System.Drawing.Size(772, 356);
            this.lejlighedDGV.TabIndex = 1;
            // 
            // lejlighedNr
            // 
            this.lejlighedNr.HeaderText = "Nr.";
            this.lejlighedNr.MinimumWidth = 8;
            this.lejlighedNr.Name = "lejlighedNr";
            this.lejlighedNr.ReadOnly = true;
            // 
            // ungdomsDGV
            // 
            this.ungdomsDGV.AllowUserToAddRows = false;
            this.ungdomsDGV.AllowUserToDeleteRows = false;
            this.ungdomsDGV.AllowUserToResizeColumns = false;
            this.ungdomsDGV.AllowUserToResizeRows = false;
            this.ungdomsDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ungdomsDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.ungdomsDGV.BackgroundColor = System.Drawing.Color.Linen;
            this.ungdomsDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ungdomsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ungdomsDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ungdomsNr});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Linen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ungdomsDGV.DefaultCellStyle = dataGridViewCellStyle2;
            this.ungdomsDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ungdomsDGV.Location = new System.Drawing.Point(3, 3);
            this.ungdomsDGV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ungdomsDGV.Name = "ungdomsDGV";
            this.ungdomsDGV.ReadOnly = true;
            this.ungdomsDGV.RowHeadersVisible = false;
            this.ungdomsDGV.RowHeadersWidth = 62;
            this.ungdomsDGV.RowTemplate.Height = 28;
            this.ungdomsDGV.Size = new System.Drawing.Size(772, 356);
            this.ungdomsDGV.TabIndex = 2;
            // 
            // ungdomsNr
            // 
            this.ungdomsNr.HeaderText = "Nr.";
            this.ungdomsNr.MinimumWidth = 8;
            this.ungdomsNr.Name = "ungdomsNr";
            this.ungdomsNr.ReadOnly = true;
            // 
            // seniorbolig
            // 
            this.seniorbolig.Location = new System.Drawing.Point(4, 37);
            this.seniorbolig.Name = "seniorbolig";
            this.seniorbolig.Padding = new System.Windows.Forms.Padding(3);
            this.seniorbolig.Size = new System.Drawing.Size(778, 362);
            this.seniorbolig.TabIndex = 2;
            this.seniorbolig.Text = "tabPage6";
            this.seniorbolig.UseVisualStyleBackColor = true;
            // 
            // Read
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Read";
            this.Text = "Read";
            this.Load += new System.EventHandler(this.Read_Load);
            ((System.ComponentModel.ISupportInitialize)(this.readMedlemDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medlemBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soenderbodbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medlemBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.readBoligDGV)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.readReserveDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boligBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reserveretBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soenderbodbDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reserveretBindingSource1)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.ventelister.ResumeLayout(false);
            this.lejlighed.ResumeLayout(false);
            this.Ungdomsbolig.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lejlighedDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ungdomsDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView readMedlemDGV;
        private System.Windows.Forms.BindingSource medlemBindingSource;
        private soenderbodbDataSet soenderbodbDataSet;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView readBoligDGV;
        private System.Windows.Forms.BindingSource boligBindingSource;
        private soenderbodbDataSetTableAdapters.BoligTableAdapter boligTableAdapter;
        private System.Windows.Forms.BindingSource medlemBindingSource1;
        private soenderbodbDataSetTableAdapters.MedlemTableAdapter medlemTableAdapter;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView readReserveDGV;
        private soenderbodbDataSet1 soenderbodbDataSet1;
        private System.Windows.Forms.BindingSource reserveretBindingSource;
        private soenderbodbDataSet1TableAdapters.ReserveretTableAdapter reserveretTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn rIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loebeNrDataGridViewTextBoxColumn2;
        private System.Windows.Forms.BindingSource reserveretBindingSource1;
        private soenderbodbDataSetTableAdapters.ReserveretTableAdapter reserveretTableAdapter1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabControl ventelister;
        private System.Windows.Forms.TabPage lejlighed;
        private System.Windows.Forms.DataGridView lejlighedDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn lejlighedNr;
        private System.Windows.Forms.TabPage Ungdomsbolig;
        private System.Windows.Forms.DataGridView ungdomsDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ungdomsNr;
        private System.Windows.Forms.TabPage seniorbolig;
    }
}