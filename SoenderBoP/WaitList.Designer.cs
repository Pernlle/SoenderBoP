namespace SoenderBoP
{
    partial class WaitList
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.lejlighed = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lejlighedDGV = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ungdomsbolig = new System.Windows.Forms.TabPage();
            this.ungdomsDGV = new System.Windows.Forms.DataGridView();
            this.ungdomsNr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.seniorbolig = new System.Windows.Forms.TabPage();
            this.seniorDGV = new System.Windows.Forms.DataGridView();
            this.seniorNr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lejlighedBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.waitListViews = new SoenderBoP.waitListViews();
            this.opskrevetDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fNavnDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eNavnDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medlemIdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ungdomsboligBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.opskrevetDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fNavnDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eNavnDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medlemIdDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seniorboligBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lejlighedTableAdapter = new SoenderBoP.waitListViewsTableAdapters.LejlighedTableAdapter();
            this.ungdomsboligTableAdapter = new SoenderBoP.waitListViewsTableAdapters.UngdomsboligTableAdapter();
            this.seniorboligTableAdapter = new SoenderBoP.waitListViewsTableAdapters.SeniorboligTableAdapter();
            this.lejlighedNr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opskrevetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fNavnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eNavnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medlemIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.lejlighed.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lejlighedDGV)).BeginInit();
            this.panel1.SuspendLayout();
            this.ungdomsbolig.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ungdomsDGV)).BeginInit();
            this.panel2.SuspendLayout();
            this.seniorbolig.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.seniorDGV)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lejlighedBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.waitListViews)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ungdomsboligBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seniorboligBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.lejlighed);
            this.tabControl1.Controls.Add(this.ungdomsbolig);
            this.tabControl1.Controls.Add(this.seniorbolig);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft JhengHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(15, 5);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(952, 575);
            this.tabControl1.TabIndex = 0;
            // 
            // lejlighed
            // 
            this.lejlighed.Controls.Add(this.panel4);
            this.lejlighed.Controls.Add(this.panel1);
            this.lejlighed.Location = new System.Drawing.Point(4, 38);
            this.lejlighed.Name = "lejlighed";
            this.lejlighed.Padding = new System.Windows.Forms.Padding(3);
            this.lejlighed.Size = new System.Drawing.Size(944, 533);
            this.lejlighed.TabIndex = 0;
            this.lejlighed.Text = "Lejlighed";
            this.lejlighed.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lejlighedDGV);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(601, 527);
            this.panel4.TabIndex = 2;
            // 
            // lejlighedDGV
            // 
            this.lejlighedDGV.AllowUserToAddRows = false;
            this.lejlighedDGV.AllowUserToDeleteRows = false;
            this.lejlighedDGV.AllowUserToResizeColumns = false;
            this.lejlighedDGV.AllowUserToResizeRows = false;
            this.lejlighedDGV.AutoGenerateColumns = false;
            this.lejlighedDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.lejlighedDGV.BackgroundColor = System.Drawing.Color.Linen;
            this.lejlighedDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lejlighedDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.lejlighedDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lejlighedDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lejlighedNr,
            this.opskrevetDataGridViewTextBoxColumn,
            this.fNavnDataGridViewTextBoxColumn,
            this.eNavnDataGridViewTextBoxColumn,
            this.medlemIdDataGridViewTextBoxColumn});
            this.lejlighedDGV.DataSource = this.lejlighedBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Linen;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft JhengHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.lejlighedDGV.DefaultCellStyle = dataGridViewCellStyle1;
            this.lejlighedDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lejlighedDGV.GridColor = System.Drawing.Color.Gainsboro;
            this.lejlighedDGV.Location = new System.Drawing.Point(0, 0);
            this.lejlighedDGV.Margin = new System.Windows.Forms.Padding(0);
            this.lejlighedDGV.MultiSelect = false;
            this.lejlighedDGV.Name = "lejlighedDGV";
            this.lejlighedDGV.ReadOnly = true;
            this.lejlighedDGV.RowHeadersVisible = false;
            this.lejlighedDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.lejlighedDGV.RowTemplate.Height = 28;
            this.lejlighedDGV.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.lejlighedDGV.Size = new System.Drawing.Size(601, 527);
            this.lejlighedDGV.TabIndex = 0;
            this.lejlighedDGV.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.lejlighedDGV_RowPostPaint);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(604, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(337, 527);
            this.panel1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Dato:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Medlem:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tilføj til venteliste";
            // 
            // ungdomsbolig
            // 
            this.ungdomsbolig.Controls.Add(this.ungdomsDGV);
            this.ungdomsbolig.Controls.Add(this.panel2);
            this.ungdomsbolig.Location = new System.Drawing.Point(4, 38);
            this.ungdomsbolig.Name = "ungdomsbolig";
            this.ungdomsbolig.Padding = new System.Windows.Forms.Padding(3);
            this.ungdomsbolig.Size = new System.Drawing.Size(944, 533);
            this.ungdomsbolig.TabIndex = 1;
            this.ungdomsbolig.Text = "Ungdomsbolig";
            this.ungdomsbolig.UseVisualStyleBackColor = true;
            // 
            // ungdomsDGV
            // 
            this.ungdomsDGV.AutoGenerateColumns = false;
            this.ungdomsDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ungdomsDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.ungdomsDGV.BackgroundColor = System.Drawing.Color.Linen;
            this.ungdomsDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ungdomsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ungdomsDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ungdomsNr,
            this.opskrevetDataGridViewTextBoxColumn1,
            this.fNavnDataGridViewTextBoxColumn1,
            this.eNavnDataGridViewTextBoxColumn1,
            this.medlemIdDataGridViewTextBoxColumn1});
            this.ungdomsDGV.DataSource = this.ungdomsboligBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Linen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft JhengHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ungdomsDGV.DefaultCellStyle = dataGridViewCellStyle2;
            this.ungdomsDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ungdomsDGV.Location = new System.Drawing.Point(3, 3);
            this.ungdomsDGV.Name = "ungdomsDGV";
            this.ungdomsDGV.ReadOnly = true;
            this.ungdomsDGV.RowHeadersWidth = 62;
            this.ungdomsDGV.RowTemplate.Height = 28;
            this.ungdomsDGV.Size = new System.Drawing.Size(599, 527);
            this.ungdomsDGV.TabIndex = 1;
            this.ungdomsDGV.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.ungdomsDGV_RowPostPaint);
            // 
            // ungdomsNr
            // 
            this.ungdomsNr.HeaderText = "Nr.";
            this.ungdomsNr.MinimumWidth = 8;
            this.ungdomsNr.Name = "ungdomsNr";
            this.ungdomsNr.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(602, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(339, 527);
            this.panel2.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Dato:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Medlem:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(173, 25);
            this.label6.TabIndex = 3;
            this.label6.Text = "Tilføj til venteliste";
            // 
            // seniorbolig
            // 
            this.seniorbolig.Controls.Add(this.seniorDGV);
            this.seniorbolig.Controls.Add(this.panel3);
            this.seniorbolig.Location = new System.Drawing.Point(4, 38);
            this.seniorbolig.Name = "seniorbolig";
            this.seniorbolig.Padding = new System.Windows.Forms.Padding(3);
            this.seniorbolig.Size = new System.Drawing.Size(944, 533);
            this.seniorbolig.TabIndex = 2;
            this.seniorbolig.Text = "Seniorbolig";
            this.seniorbolig.UseVisualStyleBackColor = true;
            // 
            // seniorDGV
            // 
            this.seniorDGV.AutoGenerateColumns = false;
            this.seniorDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.seniorDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.seniorDGV.BackgroundColor = System.Drawing.Color.Linen;
            this.seniorDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.seniorDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.seniorDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.seniorNr,
            this.opskrevetDataGridViewTextBoxColumn2,
            this.fNavnDataGridViewTextBoxColumn2,
            this.eNavnDataGridViewTextBoxColumn2,
            this.medlemIdDataGridViewTextBoxColumn2});
            this.seniorDGV.DataSource = this.seniorboligBindingSource;
            this.seniorDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.seniorDGV.GridColor = System.Drawing.Color.Black;
            this.seniorDGV.Location = new System.Drawing.Point(3, 3);
            this.seniorDGV.Name = "seniorDGV";
            this.seniorDGV.RowHeadersWidth = 62;
            this.seniorDGV.RowTemplate.Height = 28;
            this.seniorDGV.Size = new System.Drawing.Size(590, 527);
            this.seniorDGV.TabIndex = 1;
            this.seniorDGV.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.seniorDGV_RowPostPaint);
            // 
            // seniorNr
            // 
            this.seniorNr.HeaderText = "Nr.";
            this.seniorNr.MinimumWidth = 8;
            this.seniorNr.Name = "seniorNr";
            this.seniorNr.ReadOnly = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(593, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(348, 527);
            this.panel3.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 188);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 25);
            this.label7.TabIndex = 5;
            this.label7.Text = "Dato:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 25);
            this.label8.TabIndex = 4;
            this.label8.Text = "Medlem:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(-5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(173, 25);
            this.label9.TabIndex = 3;
            this.label9.Text = "Tilføj til venteliste";
            // 
            // lejlighedBindingSource
            // 
            this.lejlighedBindingSource.DataMember = "Lejlighed";
            this.lejlighedBindingSource.DataSource = this.waitListViews;
            // 
            // waitListViews
            // 
            this.waitListViews.DataSetName = "waitListViews";
            this.waitListViews.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // opskrevetDataGridViewTextBoxColumn1
            // 
            this.opskrevetDataGridViewTextBoxColumn1.DataPropertyName = "opskrevet";
            this.opskrevetDataGridViewTextBoxColumn1.HeaderText = "Opskrevet";
            this.opskrevetDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.opskrevetDataGridViewTextBoxColumn1.Name = "opskrevetDataGridViewTextBoxColumn1";
            this.opskrevetDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // fNavnDataGridViewTextBoxColumn1
            // 
            this.fNavnDataGridViewTextBoxColumn1.DataPropertyName = "fNavn";
            this.fNavnDataGridViewTextBoxColumn1.HeaderText = "Fornavn";
            this.fNavnDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.fNavnDataGridViewTextBoxColumn1.Name = "fNavnDataGridViewTextBoxColumn1";
            this.fNavnDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // eNavnDataGridViewTextBoxColumn1
            // 
            this.eNavnDataGridViewTextBoxColumn1.DataPropertyName = "eNavn";
            this.eNavnDataGridViewTextBoxColumn1.HeaderText = "Efternavn";
            this.eNavnDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.eNavnDataGridViewTextBoxColumn1.Name = "eNavnDataGridViewTextBoxColumn1";
            this.eNavnDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // medlemIdDataGridViewTextBoxColumn1
            // 
            this.medlemIdDataGridViewTextBoxColumn1.DataPropertyName = "medlemId";
            this.medlemIdDataGridViewTextBoxColumn1.HeaderText = "ID";
            this.medlemIdDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.medlemIdDataGridViewTextBoxColumn1.Name = "medlemIdDataGridViewTextBoxColumn1";
            this.medlemIdDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // ungdomsboligBindingSource
            // 
            this.ungdomsboligBindingSource.DataMember = "Ungdomsbolig";
            this.ungdomsboligBindingSource.DataSource = this.waitListViews;
            // 
            // opskrevetDataGridViewTextBoxColumn2
            // 
            this.opskrevetDataGridViewTextBoxColumn2.DataPropertyName = "opskrevet";
            this.opskrevetDataGridViewTextBoxColumn2.HeaderText = "Opskrevet";
            this.opskrevetDataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.opskrevetDataGridViewTextBoxColumn2.Name = "opskrevetDataGridViewTextBoxColumn2";
            this.opskrevetDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // fNavnDataGridViewTextBoxColumn2
            // 
            this.fNavnDataGridViewTextBoxColumn2.DataPropertyName = "fNavn";
            this.fNavnDataGridViewTextBoxColumn2.HeaderText = "Fornavn";
            this.fNavnDataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.fNavnDataGridViewTextBoxColumn2.Name = "fNavnDataGridViewTextBoxColumn2";
            this.fNavnDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // eNavnDataGridViewTextBoxColumn2
            // 
            this.eNavnDataGridViewTextBoxColumn2.DataPropertyName = "eNavn";
            this.eNavnDataGridViewTextBoxColumn2.HeaderText = "Efternavn";
            this.eNavnDataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.eNavnDataGridViewTextBoxColumn2.Name = "eNavnDataGridViewTextBoxColumn2";
            this.eNavnDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // medlemIdDataGridViewTextBoxColumn2
            // 
            this.medlemIdDataGridViewTextBoxColumn2.DataPropertyName = "medlemId";
            this.medlemIdDataGridViewTextBoxColumn2.HeaderText = "ID";
            this.medlemIdDataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.medlemIdDataGridViewTextBoxColumn2.Name = "medlemIdDataGridViewTextBoxColumn2";
            this.medlemIdDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // seniorboligBindingSource
            // 
            this.seniorboligBindingSource.DataMember = "Seniorbolig";
            this.seniorboligBindingSource.DataSource = this.waitListViews;
            // 
            // lejlighedTableAdapter
            // 
            this.lejlighedTableAdapter.ClearBeforeFill = true;
            // 
            // ungdomsboligTableAdapter
            // 
            this.ungdomsboligTableAdapter.ClearBeforeFill = true;
            // 
            // seniorboligTableAdapter
            // 
            this.seniorboligTableAdapter.ClearBeforeFill = true;
            // 
            // lejlighedNr
            // 
            this.lejlighedNr.HeaderText = "Nr.";
            this.lejlighedNr.MinimumWidth = 8;
            this.lejlighedNr.Name = "lejlighedNr";
            this.lejlighedNr.ReadOnly = true;
            // 
            // opskrevetDataGridViewTextBoxColumn
            // 
            this.opskrevetDataGridViewTextBoxColumn.DataPropertyName = "opskrevet";
            this.opskrevetDataGridViewTextBoxColumn.HeaderText = "Opskrevet";
            this.opskrevetDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.opskrevetDataGridViewTextBoxColumn.Name = "opskrevetDataGridViewTextBoxColumn";
            this.opskrevetDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fNavnDataGridViewTextBoxColumn
            // 
            this.fNavnDataGridViewTextBoxColumn.DataPropertyName = "fNavn";
            this.fNavnDataGridViewTextBoxColumn.HeaderText = "Fornavn";
            this.fNavnDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.fNavnDataGridViewTextBoxColumn.Name = "fNavnDataGridViewTextBoxColumn";
            this.fNavnDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // eNavnDataGridViewTextBoxColumn
            // 
            this.eNavnDataGridViewTextBoxColumn.DataPropertyName = "eNavn";
            this.eNavnDataGridViewTextBoxColumn.HeaderText = "Efternavn";
            this.eNavnDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.eNavnDataGridViewTextBoxColumn.Name = "eNavnDataGridViewTextBoxColumn";
            this.eNavnDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // medlemIdDataGridViewTextBoxColumn
            // 
            this.medlemIdDataGridViewTextBoxColumn.DataPropertyName = "medlemId";
            this.medlemIdDataGridViewTextBoxColumn.HeaderText = "ID";
            this.medlemIdDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.medlemIdDataGridViewTextBoxColumn.Name = "medlemIdDataGridViewTextBoxColumn";
            this.medlemIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // WaitList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 575);
            this.Controls.Add(this.tabControl1);
            this.Name = "WaitList";
            this.Text = "WaitList";
            this.Load += new System.EventHandler(this.WaitList_Load);
            this.tabControl1.ResumeLayout(false);
            this.lejlighed.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lejlighedDGV)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ungdomsbolig.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ungdomsDGV)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.seniorbolig.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.seniorDGV)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lejlighedBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.waitListViews)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ungdomsboligBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seniorboligBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage lejlighed;
        private System.Windows.Forms.TabPage ungdomsbolig;
        private System.Windows.Forms.TabPage seniorbolig;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView lejlighedDGV;
        private System.Windows.Forms.DataGridView ungdomsDGV;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView seniorDGV;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private waitListViews waitListViews;
        private System.Windows.Forms.BindingSource lejlighedBindingSource;
        private waitListViewsTableAdapters.LejlighedTableAdapter lejlighedTableAdapter;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.BindingSource ungdomsboligBindingSource;
        private waitListViewsTableAdapters.UngdomsboligTableAdapter ungdomsboligTableAdapter;
        private System.Windows.Forms.BindingSource seniorboligBindingSource;
        private waitListViewsTableAdapters.SeniorboligTableAdapter seniorboligTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ungdomsNr;
        private System.Windows.Forms.DataGridViewTextBoxColumn opskrevetDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fNavnDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn eNavnDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn medlemIdDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn seniorNr;
        private System.Windows.Forms.DataGridViewTextBoxColumn opskrevetDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn fNavnDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn eNavnDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn medlemIdDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn lejlighedNr;
        private System.Windows.Forms.DataGridViewTextBoxColumn opskrevetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fNavnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eNavnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn medlemIdDataGridViewTextBoxColumn;
    }
}