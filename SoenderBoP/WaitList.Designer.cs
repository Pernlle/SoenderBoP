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
            this.lejlighedNr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.waitlistPrintLbtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ungdomsbolig = new System.Windows.Forms.TabPage();
            this.ungdomsDGV = new System.Windows.Forms.DataGridView();
            this.ungdomsNr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.waitlistPrintUBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.seniorbolig = new System.Windows.Forms.TabPage();
            this.seniorDGV = new System.Windows.Forms.DataGridView();
            this.seniorNr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.waitlistPrintSBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.ungdomsboligBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.waitListViews = new SoenderBoP.waitListViews();
            this.seniorboligBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lejlighedBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lejlighedTableAdapter = new SoenderBoP.waitListViewsTableAdapters.LejlighedTableAdapter();
            this.ungdomsboligTableAdapter = new SoenderBoP.waitListViewsTableAdapters.UngdomsboligTableAdapter();
            this.seniorboligTableAdapter = new SoenderBoP.waitListViewsTableAdapters.SeniorboligTableAdapter();
            this.tabControl1.SuspendLayout();
            this.lejlighed.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lejlighedDGV)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.ungdomsbolig.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ungdomsDGV)).BeginInit();
            this.panel2.SuspendLayout();
            this.seniorbolig.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.seniorDGV)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ungdomsboligBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.waitListViews)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seniorboligBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lejlighedBindingSource)).BeginInit();
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
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.lejlighed.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lejlighed.Name = "lejlighed";
            this.lejlighed.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lejlighed.Size = new System.Drawing.Size(944, 533);
            this.lejlighed.TabIndex = 0;
            this.lejlighed.Text = "Lejlighed";
            this.lejlighed.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lejlighedDGV);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 2);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(600, 529);
            this.panel4.TabIndex = 2;
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
            this.lejlighedDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.lejlighedDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lejlighedDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lejlighedNr});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Linen;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft JhengHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(1);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
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
            this.lejlighedDGV.Size = new System.Drawing.Size(600, 529);
            this.lejlighedDGV.TabIndex = 0;
            this.lejlighedDGV.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.lejlighedDGV_RowPostPaint);
            // 
            // lejlighedNr
            // 
            this.lejlighedNr.HeaderText = "Nr.";
            this.lejlighedNr.MinimumWidth = 8;
            this.lejlighedNr.Name = "lejlighedNr";
            this.lejlighedNr.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(603, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(338, 529);
            this.panel1.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.waitlistPrintLbtn);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 404);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(338, 125);
            this.panel5.TabIndex = 3;
            // 
            // waitlistPrintLbtn
            // 
            this.waitlistPrintLbtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.waitlistPrintLbtn.Location = new System.Drawing.Point(0, 87);
            this.waitlistPrintLbtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.waitlistPrintLbtn.Name = "waitlistPrintLbtn";
            this.waitlistPrintLbtn.Size = new System.Drawing.Size(338, 38);
            this.waitlistPrintLbtn.TabIndex = 0;
            this.waitlistPrintLbtn.Text = "Print";
            this.waitlistPrintLbtn.UseVisualStyleBackColor = true;
            this.waitlistPrintLbtn.Click += new System.EventHandler(this.waitlistPrintLbtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Dato:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Medlem:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
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
            this.ungdomsbolig.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ungdomsbolig.Name = "ungdomsbolig";
            this.ungdomsbolig.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ungdomsbolig.Size = new System.Drawing.Size(944, 533);
            this.ungdomsbolig.TabIndex = 1;
            this.ungdomsbolig.Text = "Ungdomsbolig";
            this.ungdomsbolig.UseVisualStyleBackColor = true;
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
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft JhengHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ungdomsDGV.DefaultCellStyle = dataGridViewCellStyle2;
            this.ungdomsDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ungdomsDGV.Location = new System.Drawing.Point(3, 2);
            this.ungdomsDGV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ungdomsDGV.Name = "ungdomsDGV";
            this.ungdomsDGV.ReadOnly = true;
            this.ungdomsDGV.RowHeadersVisible = false;
            this.ungdomsDGV.RowHeadersWidth = 62;
            this.ungdomsDGV.RowTemplate.Height = 28;
            this.ungdomsDGV.Size = new System.Drawing.Size(599, 529);
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
            this.panel2.Controls.Add(this.waitlistPrintUBtn);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(602, 2);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(339, 529);
            this.panel2.TabIndex = 0;
            // 
            // waitlistPrintUBtn
            // 
            this.waitlistPrintUBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.waitlistPrintUBtn.Location = new System.Drawing.Point(0, 491);
            this.waitlistPrintUBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.waitlistPrintUBtn.Name = "waitlistPrintUBtn";
            this.waitlistPrintUBtn.Size = new System.Drawing.Size(339, 38);
            this.waitlistPrintUBtn.TabIndex = 6;
            this.waitlistPrintUBtn.Text = "Print";
            this.waitlistPrintUBtn.UseVisualStyleBackColor = true;
            this.waitlistPrintUBtn.Click += new System.EventHandler(this.waitlistPrintUBtn_Click);
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
            this.label5.Location = new System.Drawing.Point(6, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Medlem:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Location = new System.Drawing.Point(0, 0);
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
            this.seniorbolig.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.seniorbolig.Name = "seniorbolig";
            this.seniorbolig.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.seniorbolig.Size = new System.Drawing.Size(944, 533);
            this.seniorbolig.TabIndex = 2;
            this.seniorbolig.Text = "Seniorbolig";
            this.seniorbolig.UseVisualStyleBackColor = true;
            // 
            // seniorDGV
            // 
            this.seniorDGV.AllowUserToAddRows = false;
            this.seniorDGV.AllowUserToDeleteRows = false;
            this.seniorDGV.AllowUserToResizeColumns = false;
            this.seniorDGV.AllowUserToResizeRows = false;
            this.seniorDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.seniorDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.seniorDGV.BackgroundColor = System.Drawing.Color.Linen;
            this.seniorDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.seniorDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.seniorDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.seniorNr});
            this.seniorDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.seniorDGV.GridColor = System.Drawing.Color.Black;
            this.seniorDGV.Location = new System.Drawing.Point(3, 2);
            this.seniorDGV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.seniorDGV.Name = "seniorDGV";
            this.seniorDGV.RowHeadersVisible = false;
            this.seniorDGV.RowHeadersWidth = 62;
            this.seniorDGV.RowTemplate.Height = 28;
            this.seniorDGV.Size = new System.Drawing.Size(602, 529);
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
            this.panel3.Controls.Add(this.waitlistPrintSBtn);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(605, 2);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(336, 529);
            this.panel3.TabIndex = 0;
            // 
            // waitlistPrintSBtn
            // 
            this.waitlistPrintSBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.waitlistPrintSBtn.Location = new System.Drawing.Point(0, 491);
            this.waitlistPrintSBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.waitlistPrintSBtn.Name = "waitlistPrintSBtn";
            this.waitlistPrintSBtn.Size = new System.Drawing.Size(336, 38);
            this.waitlistPrintSBtn.TabIndex = 6;
            this.waitlistPrintSBtn.Text = "Print";
            this.waitlistPrintSBtn.UseVisualStyleBackColor = true;
            this.waitlistPrintSBtn.Click += new System.EventHandler(this.waitlistPrintSBtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 178);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 25);
            this.label7.TabIndex = 5;
            this.label7.Text = "Dato:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 25);
            this.label8.TabIndex = 4;
            this.label8.Text = "Medlem:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Top;
            this.label9.Location = new System.Drawing.Point(0, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(173, 25);
            this.label9.TabIndex = 3;
            this.label9.Text = "Tilføj til venteliste";
            // 
            // ungdomsboligBindingSource
            // 
            this.ungdomsboligBindingSource.DataMember = "Ungdomsbolig";
            this.ungdomsboligBindingSource.DataSource = this.waitListViews;
            // 
            // waitListViews
            // 
            this.waitListViews.DataSetName = "waitListViews";
            this.waitListViews.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // seniorboligBindingSource
            // 
            this.seniorboligBindingSource.DataMember = "Seniorbolig";
            this.seniorboligBindingSource.DataSource = this.waitListViews;
            // 
            // lejlighedBindingSource
            // 
            this.lejlighedBindingSource.DataMember = "Lejlighed";
            this.lejlighedBindingSource.DataSource = this.waitListViews;
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
            // WaitList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 575);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "WaitList";
            this.Text = "WaitList";
            this.Load += new System.EventHandler(this.WaitList_Load);
            this.tabControl1.ResumeLayout(false);
            this.lejlighed.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lejlighedDGV)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.ungdomsbolig.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ungdomsDGV)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.seniorbolig.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.seniorDGV)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ungdomsboligBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.waitListViews)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seniorboligBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lejlighedBindingSource)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn seniorNr;
        private System.Windows.Forms.DataGridViewTextBoxColumn lejlighedNr;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button waitlistPrintLbtn;
        private System.Windows.Forms.Button waitlistPrintUBtn;
        private System.Windows.Forms.Button waitlistPrintSBtn;
    }
}