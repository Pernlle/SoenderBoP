namespace SoenderBoP
{
    partial class Lease
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.bIdTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.leaseAdresseCBX = new System.Windows.Forms.ComboBox();
            this.boligBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.soenderbodbDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.soenderbodbDataSet = new SoenderBoP.soenderbodbDataSet();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.mIdTxt = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.leasePrintbtn = new System.Windows.Forms.Button();
            this.emailCBX = new System.Windows.Forms.ComboBox();
            this.medlemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.leaseDTP = new System.Windows.Forms.DateTimePicker();
            this.CreateLease = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.leaseDGV = new System.Windows.Forms.DataGridView();
            this.medlemTableAdapter = new SoenderBoP.soenderbodbDataSetTableAdapters.MedlemTableAdapter();
            this.boligTableAdapter = new SoenderBoP.soenderbodbDataSetTableAdapters.BoligTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.boligBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soenderbodbDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soenderbodbDataSet)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.medlemBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.leaseDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.bIdTxt);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.leaseAdresseCBX);
            this.panel1.Controls.Add(this.refreshBtn);
            this.panel1.Controls.Add(this.mIdTxt);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.emailCBX);
            this.panel1.Controls.Add(this.leaseDTP);
            this.panel1.Controls.Add(this.CreateLease);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(559, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(222, 518);
            this.panel1.TabIndex = 0;
            // 
            // bIdTxt
            // 
            this.bIdTxt.Location = new System.Drawing.Point(148, 190);
            this.bIdTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bIdTxt.Name = "bIdTxt";
            this.bIdTxt.Size = new System.Drawing.Size(61, 26);
            this.bIdTxt.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Adresse";
            // 
            // leaseAdresseCBX
            // 
            this.leaseAdresseCBX.DataSource = this.boligBindingSource;
            this.leaseAdresseCBX.DisplayMember = "adr";
            this.leaseAdresseCBX.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.leaseAdresseCBX.FormattingEnabled = true;
            this.leaseAdresseCBX.Location = new System.Drawing.Point(15, 190);
            this.leaseAdresseCBX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.leaseAdresseCBX.Name = "leaseAdresseCBX";
            this.leaseAdresseCBX.Size = new System.Drawing.Size(127, 28);
            this.leaseAdresseCBX.TabIndex = 9;
            this.leaseAdresseCBX.ValueMember = "adr";
            this.leaseAdresseCBX.Click += new System.EventHandler(this.leaseAdresseCBX_Click);
            // 
            // boligBindingSource
            // 
            this.boligBindingSource.DataMember = "Bolig";
            this.boligBindingSource.DataSource = this.soenderbodbDataSetBindingSource;
            // 
            // soenderbodbDataSetBindingSource
            // 
            this.soenderbodbDataSetBindingSource.DataSource = this.soenderbodbDataSet;
            this.soenderbodbDataSetBindingSource.Position = 0;
            // 
            // soenderbodbDataSet
            // 
            this.soenderbodbDataSet.DataSetName = "soenderbodbDataSet";
            this.soenderbodbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // refreshBtn
            // 
            this.refreshBtn.Location = new System.Drawing.Point(194, 0);
            this.refreshBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(28, 32);
            this.refreshBtn.TabIndex = 8;
            this.refreshBtn.Text = "R";
            this.refreshBtn.UseVisualStyleBackColor = true;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // mIdTxt
            // 
            this.mIdTxt.Location = new System.Drawing.Point(148, 98);
            this.mIdTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mIdTxt.Name = "mIdTxt";
            this.mIdTxt.Size = new System.Drawing.Size(61, 26);
            this.mIdTxt.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.leasePrintbtn);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 436);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(222, 82);
            this.panel3.TabIndex = 6;
            // 
            // leasePrintbtn
            // 
            this.leasePrintbtn.Location = new System.Drawing.Point(69, 24);
            this.leasePrintbtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.leasePrintbtn.Name = "leasePrintbtn";
            this.leasePrintbtn.Size = new System.Drawing.Size(84, 29);
            this.leasePrintbtn.TabIndex = 0;
            this.leasePrintbtn.Text = "Print";
            this.leasePrintbtn.UseVisualStyleBackColor = true;
            // 
            // emailCBX
            // 
            this.emailCBX.DataSource = this.medlemBindingSource;
            this.emailCBX.DisplayMember = "email";
            this.emailCBX.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.emailCBX.FormattingEnabled = true;
            this.emailCBX.Location = new System.Drawing.Point(15, 98);
            this.emailCBX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.emailCBX.Name = "emailCBX";
            this.emailCBX.Size = new System.Drawing.Size(127, 28);
            this.emailCBX.TabIndex = 5;
            this.emailCBX.ValueMember = "email";
            this.emailCBX.Click += new System.EventHandler(this.emailCBX_Click);
            // 
            // medlemBindingSource
            // 
            this.medlemBindingSource.DataMember = "Medlem";
            this.medlemBindingSource.DataSource = this.soenderbodbDataSetBindingSource;
            // 
            // leaseDTP
            // 
            this.leaseDTP.Location = new System.Drawing.Point(15, 271);
            this.leaseDTP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.leaseDTP.Name = "leaseDTP";
            this.leaseDTP.Size = new System.Drawing.Size(195, 26);
            this.leaseDTP.TabIndex = 4;
            this.leaseDTP.Value = new System.DateTime(2022, 5, 19, 0, 0, 0, 0);
            // 
            // CreateLease
            // 
            this.CreateLease.Location = new System.Drawing.Point(15, 329);
            this.CreateLease.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CreateLease.Name = "CreateLease";
            this.CreateLease.Size = new System.Drawing.Size(195, 32);
            this.CreateLease.TabIndex = 3;
            this.CreateLease.Text = "Opret";
            this.CreateLease.UseVisualStyleBackColor = true;
            this.CreateLease.Click += new System.EventHandler(this.CreateLease_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Dato";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Opret lejekontrakt";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.leaseDGV);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(559, 518);
            this.panel2.TabIndex = 1;
            // 
            // leaseDGV
            // 
            this.leaseDGV.AllowUserToAddRows = false;
            this.leaseDGV.AllowUserToDeleteRows = false;
            this.leaseDGV.AllowUserToResizeColumns = false;
            this.leaseDGV.AllowUserToResizeRows = false;
            this.leaseDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.leaseDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.leaseDGV.BackgroundColor = System.Drawing.Color.Linen;
            this.leaseDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.leaseDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.leaseDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.leaseDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.leaseDGV.Location = new System.Drawing.Point(0, 0);
            this.leaseDGV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.leaseDGV.Name = "leaseDGV";
            this.leaseDGV.ReadOnly = true;
            this.leaseDGV.RowHeadersWidth = 62;
            this.leaseDGV.RowTemplate.Height = 28;
            this.leaseDGV.Size = new System.Drawing.Size(559, 518);
            this.leaseDGV.TabIndex = 0;
            // 
            // medlemTableAdapter
            // 
            this.medlemTableAdapter.ClearBeforeFill = true;
            // 
            // boligTableAdapter
            // 
            this.boligTableAdapter.ClearBeforeFill = true;
            // 
            // Lease
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 518);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Lease";
            this.Text = "Lease";
            this.Load += new System.EventHandler(this.Lease_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.boligBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soenderbodbDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soenderbodbDataSet)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.medlemBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.leaseDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button CreateLease;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView leaseDGV;
        private System.Windows.Forms.ComboBox emailCBX;
        private System.Windows.Forms.DateTimePicker leaseDTP;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button leasePrintbtn;
        private System.Windows.Forms.TextBox mIdTxt;
        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.TextBox bIdTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox leaseAdresseCBX;
        private System.Windows.Forms.BindingSource soenderbodbDataSetBindingSource;
        private soenderbodbDataSet soenderbodbDataSet;
        private System.Windows.Forms.BindingSource medlemBindingSource;
        private soenderbodbDataSetTableAdapters.MedlemTableAdapter medlemTableAdapter;
        private System.Windows.Forms.BindingSource boligBindingSource;
        private soenderbodbDataSetTableAdapters.BoligTableAdapter boligTableAdapter;
    }
}