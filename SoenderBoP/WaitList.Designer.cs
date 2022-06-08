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
            this.panel5 = new System.Windows.Forms.Panel();
            this.lCBX = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.lmIdTXT = new System.Windows.Forms.TextBox();
            this.lDTP = new System.Windows.Forms.DateTimePicker();
            this.waitlistPrintLbtn = new System.Windows.Forms.Button();
            this.createLBTN = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ungdomsbolig = new System.Windows.Forms.TabPage();
            this.ungdomsDGV = new System.Windows.Forms.DataGridView();
            this.ungdomsNr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.umIdTXT = new System.Windows.Forms.TextBox();
            this.uDTP = new System.Windows.Forms.DateTimePicker();
            this.createUBTN = new System.Windows.Forms.Button();
            this.waitlistPrintUBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.seniorbolig = new System.Windows.Forms.TabPage();
            this.seniorDGV = new System.Windows.Forms.DataGridView();
            this.seniorNr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.smIdTXT = new System.Windows.Forms.TextBox();
            this.sDTP = new System.Windows.Forms.DateTimePicker();
            this.createSBTN = new System.Windows.Forms.Button();
            this.waitlistPrintSBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.wsCBX = new System.Windows.Forms.ComboBox();
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
            this.tabControl1.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(15, 5);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1199, 568);
            this.tabControl1.TabIndex = 0;
            // 
            // lejlighed
            // 
            this.lejlighed.BackColor = System.Drawing.Color.Linen;
            this.lejlighed.Controls.Add(this.panel4);
            this.lejlighed.Controls.Add(this.panel1);
            this.lejlighed.Location = new System.Drawing.Point(4, 38);
            this.lejlighed.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lejlighed.Name = "lejlighed";
            this.lejlighed.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lejlighed.Size = new System.Drawing.Size(1191, 526);
            this.lejlighed.TabIndex = 0;
            this.lejlighed.Text = "Lejlighed";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lejlighedDGV);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.lCBX);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 2);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(847, 522);
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
            this.lejlighedDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
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
            this.lejlighedDGV.Size = new System.Drawing.Size(847, 522);
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
            // panel5
            // 
            this.panel5.Location = new System.Drawing.Point(274, 352);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(338, 10);
            this.panel5.TabIndex = 3;
            // 
            // lCBX
            // 
            this.lCBX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lCBX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lCBX.FormattingEnabled = true;
            this.lCBX.Location = new System.Drawing.Point(629, 301);
            this.lCBX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lCBX.Name = "lCBX";
            this.lCBX.Size = new System.Drawing.Size(212, 33);
            this.lCBX.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.lmIdTXT);
            this.panel1.Controls.Add(this.lDTP);
            this.panel1.Controls.Add(this.waitlistPrintLbtn);
            this.panel1.Controls.Add(this.createLBTN);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(850, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(338, 522);
            this.panel1.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 272);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(231, 32);
            this.label10.TabIndex = 6;
            this.label10.Text = "Dato = mm/dd/yyyy";
            // 
            // lmIdTXT
            // 
            this.lmIdTXT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lmIdTXT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lmIdTXT.Location = new System.Drawing.Point(12, 118);
            this.lmIdTXT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lmIdTXT.Name = "lmIdTXT";
            this.lmIdTXT.Size = new System.Drawing.Size(310, 32);
            this.lmIdTXT.TabIndex = 2;
            // 
            // lDTP
            // 
            this.lDTP.Location = new System.Drawing.Point(12, 214);
            this.lDTP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lDTP.Name = "lDTP";
            this.lDTP.Size = new System.Drawing.Size(310, 39);
            this.lDTP.TabIndex = 3;
            // 
            // waitlistPrintLbtn
            // 
            this.waitlistPrintLbtn.BackColor = System.Drawing.Color.IndianRed;
            this.waitlistPrintLbtn.FlatAppearance.BorderSize = 0;
            this.waitlistPrintLbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.waitlistPrintLbtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.waitlistPrintLbtn.ForeColor = System.Drawing.Color.White;
            this.waitlistPrintLbtn.Location = new System.Drawing.Point(12, 398);
            this.waitlistPrintLbtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.waitlistPrintLbtn.Name = "waitlistPrintLbtn";
            this.waitlistPrintLbtn.Size = new System.Drawing.Size(310, 56);
            this.waitlistPrintLbtn.TabIndex = 5;
            this.waitlistPrintLbtn.Text = "PRINT";
            this.waitlistPrintLbtn.UseVisualStyleBackColor = false;
            this.waitlistPrintLbtn.Click += new System.EventHandler(this.waitlistPrintLbtn_Click);
            // 
            // createLBTN
            // 
            this.createLBTN.BackColor = System.Drawing.Color.IndianRed;
            this.createLBTN.FlatAppearance.BorderSize = 0;
            this.createLBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createLBTN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createLBTN.ForeColor = System.Drawing.Color.White;
            this.createLBTN.Location = new System.Drawing.Point(12, 326);
            this.createLBTN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.createLBTN.Name = "createLBTN";
            this.createLBTN.Size = new System.Drawing.Size(310, 50);
            this.createLBTN.TabIndex = 4;
            this.createLBTN.Text = "TILFØJ";
            this.createLBTN.UseVisualStyleBackColor = false;
            this.createLBTN.Click += new System.EventHandler(this.createLBTN_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Dato:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Medlem ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tilføj til venteliste";
            // 
            // ungdomsbolig
            // 
            this.ungdomsbolig.BackColor = System.Drawing.Color.Linen;
            this.ungdomsbolig.Controls.Add(this.ungdomsDGV);
            this.ungdomsbolig.Controls.Add(this.panel2);
            this.ungdomsbolig.Location = new System.Drawing.Point(4, 38);
            this.ungdomsbolig.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ungdomsbolig.Name = "ungdomsbolig";
            this.ungdomsbolig.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ungdomsbolig.Size = new System.Drawing.Size(1191, 526);
            this.ungdomsbolig.TabIndex = 1;
            this.ungdomsbolig.Text = "Ungdomsbolig";
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
            this.ungdomsDGV.Size = new System.Drawing.Size(846, 522);
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
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.umIdTXT);
            this.panel2.Controls.Add(this.uDTP);
            this.panel2.Controls.Add(this.createUBTN);
            this.panel2.Controls.Add(this.waitlistPrintUBtn);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(849, 2);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(339, 522);
            this.panel2.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 269);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(231, 32);
            this.label11.TabIndex = 10;
            this.label11.Text = "Dato = mm/dd/yyyy";
            // 
            // umIdTXT
            // 
            this.umIdTXT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.umIdTXT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.umIdTXT.Location = new System.Drawing.Point(18, 122);
            this.umIdTXT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.umIdTXT.Name = "umIdTXT";
            this.umIdTXT.Size = new System.Drawing.Size(302, 32);
            this.umIdTXT.TabIndex = 9;
            // 
            // uDTP
            // 
            this.uDTP.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.uDTP.Location = new System.Drawing.Point(18, 214);
            this.uDTP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uDTP.Name = "uDTP";
            this.uDTP.Size = new System.Drawing.Size(302, 39);
            this.uDTP.TabIndex = 8;
            // 
            // createUBTN
            // 
            this.createUBTN.BackColor = System.Drawing.Color.IndianRed;
            this.createUBTN.FlatAppearance.BorderSize = 0;
            this.createUBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createUBTN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createUBTN.ForeColor = System.Drawing.Color.Transparent;
            this.createUBTN.Location = new System.Drawing.Point(18, 328);
            this.createUBTN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.createUBTN.Name = "createUBTN";
            this.createUBTN.Size = new System.Drawing.Size(302, 52);
            this.createUBTN.TabIndex = 7;
            this.createUBTN.Text = "TILFØJ";
            this.createUBTN.UseVisualStyleBackColor = false;
            this.createUBTN.Click += new System.EventHandler(this.createUBTN_Click);
            // 
            // waitlistPrintUBtn
            // 
            this.waitlistPrintUBtn.BackColor = System.Drawing.Color.IndianRed;
            this.waitlistPrintUBtn.FlatAppearance.BorderSize = 0;
            this.waitlistPrintUBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.waitlistPrintUBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.waitlistPrintUBtn.ForeColor = System.Drawing.Color.White;
            this.waitlistPrintUBtn.Location = new System.Drawing.Point(18, 410);
            this.waitlistPrintUBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.waitlistPrintUBtn.Name = "waitlistPrintUBtn";
            this.waitlistPrintUBtn.Size = new System.Drawing.Size(302, 52);
            this.waitlistPrintUBtn.TabIndex = 6;
            this.waitlistPrintUBtn.Text = "PRINT";
            this.waitlistPrintUBtn.UseVisualStyleBackColor = false;
            this.waitlistPrintUBtn.Click += new System.EventHandler(this.waitlistPrintUBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 32);
            this.label4.TabIndex = 5;
            this.label4.Text = "Dato:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 32);
            this.label5.TabIndex = 4;
            this.label5.Text = "Medlem ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(235, 38);
            this.label6.TabIndex = 3;
            this.label6.Text = "Tilføj til venteliste";
            // 
            // seniorbolig
            // 
            this.seniorbolig.BackColor = System.Drawing.Color.Linen;
            this.seniorbolig.Controls.Add(this.seniorDGV);
            this.seniorbolig.Controls.Add(this.panel3);
            this.seniorbolig.Controls.Add(this.wsCBX);
            this.seniorbolig.Location = new System.Drawing.Point(4, 38);
            this.seniorbolig.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.seniorbolig.Name = "seniorbolig";
            this.seniorbolig.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.seniorbolig.Size = new System.Drawing.Size(1191, 526);
            this.seniorbolig.TabIndex = 2;
            this.seniorbolig.Text = "Seniorbolig";
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
            this.seniorDGV.Size = new System.Drawing.Size(849, 522);
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
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.smIdTXT);
            this.panel3.Controls.Add(this.sDTP);
            this.panel3.Controls.Add(this.createSBTN);
            this.panel3.Controls.Add(this.waitlistPrintSBtn);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(852, 2);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(336, 522);
            this.panel3.TabIndex = 0;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 272);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(231, 32);
            this.label12.TabIndex = 11;
            this.label12.Text = "Dato = mm/dd/yyyy";
            // 
            // smIdTXT
            // 
            this.smIdTXT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.smIdTXT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.smIdTXT.Location = new System.Drawing.Point(14, 119);
            this.smIdTXT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.smIdTXT.Name = "smIdTXT";
            this.smIdTXT.Size = new System.Drawing.Size(304, 32);
            this.smIdTXT.TabIndex = 10;
            // 
            // sDTP
            // 
            this.sDTP.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.sDTP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sDTP.Location = new System.Drawing.Point(12, 214);
            this.sDTP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sDTP.Name = "sDTP";
            this.sDTP.Size = new System.Drawing.Size(306, 39);
            this.sDTP.TabIndex = 8;
            // 
            // createSBTN
            // 
            this.createSBTN.BackColor = System.Drawing.Color.IndianRed;
            this.createSBTN.FlatAppearance.BorderSize = 0;
            this.createSBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createSBTN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createSBTN.ForeColor = System.Drawing.Color.White;
            this.createSBTN.Location = new System.Drawing.Point(14, 319);
            this.createSBTN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.createSBTN.Name = "createSBTN";
            this.createSBTN.Size = new System.Drawing.Size(304, 61);
            this.createSBTN.TabIndex = 7;
            this.createSBTN.TabStop = false;
            this.createSBTN.Text = "TILFØJ";
            this.createSBTN.UseVisualStyleBackColor = false;
            this.createSBTN.Click += new System.EventHandler(this.createSBTN_Click);
            // 
            // waitlistPrintSBtn
            // 
            this.waitlistPrintSBtn.BackColor = System.Drawing.Color.IndianRed;
            this.waitlistPrintSBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.waitlistPrintSBtn.FlatAppearance.BorderSize = 0;
            this.waitlistPrintSBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.waitlistPrintSBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.waitlistPrintSBtn.ForeColor = System.Drawing.Color.White;
            this.waitlistPrintSBtn.Location = new System.Drawing.Point(14, 404);
            this.waitlistPrintSBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.waitlistPrintSBtn.Name = "waitlistPrintSBtn";
            this.waitlistPrintSBtn.Size = new System.Drawing.Size(305, 62);
            this.waitlistPrintSBtn.TabIndex = 6;
            this.waitlistPrintSBtn.Text = "PRINT";
            this.waitlistPrintSBtn.UseVisualStyleBackColor = false;
            this.waitlistPrintSBtn.Click += new System.EventHandler(this.waitlistPrintSBtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 178);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 32);
            this.label7.TabIndex = 5;
            this.label7.Text = "Dato:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 32);
            this.label8.TabIndex = 4;
            this.label8.Text = "Medlem ID";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Top;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(0, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(235, 38);
            this.label9.TabIndex = 3;
            this.label9.Text = "Tilføj til venteliste";
            // 
            // wsCBX
            // 
            this.wsCBX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.wsCBX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.wsCBX.FormattingEnabled = true;
            this.wsCBX.Location = new System.Drawing.Point(612, 215);
            this.wsCBX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.wsCBX.Name = "wsCBX";
            this.wsCBX.Size = new System.Drawing.Size(234, 33);
            this.wsCBX.TabIndex = 9;
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
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(1199, 568);
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
        private System.Windows.Forms.Button createLBTN;
        private System.Windows.Forms.Button createUBTN;
        private System.Windows.Forms.Button createSBTN;
        private System.Windows.Forms.TextBox smIdTXT;
        private System.Windows.Forms.ComboBox wsCBX;
        private System.Windows.Forms.DateTimePicker sDTP;
        private System.Windows.Forms.TextBox lmIdTXT;
        private System.Windows.Forms.ComboBox lCBX;
        private System.Windows.Forms.DateTimePicker lDTP;
        private System.Windows.Forms.TextBox umIdTXT;
        private System.Windows.Forms.DateTimePicker uDTP;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}