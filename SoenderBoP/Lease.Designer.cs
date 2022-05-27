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
            this.leasePrintbtn = new System.Windows.Forms.Button();
            this.bIdTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.leaseAdresseCBX = new System.Windows.Forms.ComboBox();
            this.boligBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.soenderbodbDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.soenderbodbDataSet = new SoenderBoP.soenderbodbDataSet();
            this.mIdTxt = new System.Windows.Forms.TextBox();
            this.emailCBX = new System.Windows.Forms.ComboBox();
            this.medlemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.leaseDTP = new System.Windows.Forms.DateTimePicker();
            this.CreateLease = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.leaseDGV = new System.Windows.Forms.DataGridView();
            this.medlemTableAdapter = new SoenderBoP.soenderbodbDataSetTableAdapters.MedlemTableAdapter();
            this.boligTableAdapter = new SoenderBoP.soenderbodbDataSetTableAdapters.BoligTableAdapter();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.boligBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soenderbodbDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soenderbodbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medlemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leaseDGV)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.leasePrintbtn);
            this.panel1.Controls.Add(this.bIdTxt);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.leaseAdresseCBX);
            this.panel1.Controls.Add(this.mIdTxt);
            this.panel1.Controls.Add(this.emailCBX);
            this.panel1.Controls.Add(this.leaseDTP);
            this.panel1.Controls.Add(this.CreateLease);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(545, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(251, 449);
            this.panel1.TabIndex = 0;
            // 
            // leasePrintbtn
            // 
            this.leasePrintbtn.BackColor = System.Drawing.Color.IndianRed;
            this.leasePrintbtn.FlatAppearance.BorderSize = 0;
            this.leasePrintbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.leasePrintbtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leasePrintbtn.ForeColor = System.Drawing.Color.White;
            this.leasePrintbtn.Location = new System.Drawing.Point(13, 341);
            this.leasePrintbtn.Name = "leasePrintbtn";
            this.leasePrintbtn.Size = new System.Drawing.Size(233, 40);
            this.leasePrintbtn.TabIndex = 0;
            this.leasePrintbtn.Text = "PRINT";
            this.leasePrintbtn.UseVisualStyleBackColor = false;
            this.leasePrintbtn.Click += new System.EventHandler(this.leasePrintbtn_Click);
            // 
            // bIdTxt
            // 
            this.bIdTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bIdTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bIdTxt.Location = new System.Drawing.Point(132, 152);
            this.bIdTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bIdTxt.Name = "bIdTxt";
            this.bIdTxt.Size = new System.Drawing.Size(54, 27);
            this.bIdTxt.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 28);
            this.label4.TabIndex = 10;
            this.label4.Text = "Adresse";
            // 
            // leaseAdresseCBX
            // 
            this.leaseAdresseCBX.BackColor = System.Drawing.Color.IndianRed;
            this.leaseAdresseCBX.DataSource = this.boligBindingSource;
            this.leaseAdresseCBX.DisplayMember = "adr";
            this.leaseAdresseCBX.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.leaseAdresseCBX.ForeColor = System.Drawing.Color.White;
            this.leaseAdresseCBX.FormattingEnabled = true;
            this.leaseAdresseCBX.Location = new System.Drawing.Point(15, 152);
            this.leaseAdresseCBX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.leaseAdresseCBX.Name = "leaseAdresseCBX";
            this.leaseAdresseCBX.Size = new System.Drawing.Size(113, 36);
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
            // mIdTxt
            // 
            this.mIdTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.mIdTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mIdTxt.Location = new System.Drawing.Point(132, 78);
            this.mIdTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mIdTxt.Name = "mIdTxt";
            this.mIdTxt.Size = new System.Drawing.Size(54, 27);
            this.mIdTxt.TabIndex = 7;
            // 
            // emailCBX
            // 
            this.emailCBX.BackColor = System.Drawing.Color.IndianRed;
            this.emailCBX.DataSource = this.medlemBindingSource;
            this.emailCBX.DisplayMember = "email";
            this.emailCBX.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.emailCBX.ForeColor = System.Drawing.Color.White;
            this.emailCBX.FormattingEnabled = true;
            this.emailCBX.Location = new System.Drawing.Point(13, 78);
            this.emailCBX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.emailCBX.Name = "emailCBX";
            this.emailCBX.Size = new System.Drawing.Size(113, 36);
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
            this.leaseDTP.Location = new System.Drawing.Point(15, 232);
            this.leaseDTP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.leaseDTP.Name = "leaseDTP";
            this.leaseDTP.Size = new System.Drawing.Size(233, 34);
            this.leaseDTP.TabIndex = 4;
            this.leaseDTP.Value = new System.DateTime(2022, 5, 19, 0, 0, 0, 0);
            // 
            // CreateLease
            // 
            this.CreateLease.BackColor = System.Drawing.Color.IndianRed;
            this.CreateLease.FlatAppearance.BorderSize = 0;
            this.CreateLease.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateLease.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateLease.ForeColor = System.Drawing.Color.White;
            this.CreateLease.Location = new System.Drawing.Point(13, 280);
            this.CreateLease.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CreateLease.Name = "CreateLease";
            this.CreateLease.Size = new System.Drawing.Size(233, 40);
            this.CreateLease.TabIndex = 3;
            this.CreateLease.Text = "OPRET";
            this.CreateLease.UseVisualStyleBackColor = false;
            this.CreateLease.Click += new System.EventHandler(this.CreateLease_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Dato";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Opret lejekontrakt";
            // 
            // refreshBtn
            // 
            this.refreshBtn.Location = new System.Drawing.Point(306, 234);
            this.refreshBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(25, 26);
            this.refreshBtn.TabIndex = 8;
            this.refreshBtn.Text = "R";
            this.refreshBtn.UseVisualStyleBackColor = true;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(214, 343);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(197, 66);
            this.panel3.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(11, 394);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(383, 303);
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
            this.leaseDGV.Location = new System.Drawing.Point(3, 2);
            this.leaseDGV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.leaseDGV.Name = "leaseDGV";
            this.leaseDGV.ReadOnly = true;
            this.leaseDGV.RowHeadersWidth = 62;
            this.leaseDGV.RowTemplate.Height = 28;
            this.leaseDGV.Size = new System.Drawing.Size(542, 449);
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
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(807, 482);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.leaseDGV);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.panel3);
            this.tabPage1.Controls.Add(this.refreshBtn);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(799, 453);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Opret Lejekontrakt";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Lease
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(807, 482);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Lease";
            this.Text = "Lease";
            this.Load += new System.EventHandler(this.Lease_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.boligBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soenderbodbDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soenderbodbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medlemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leaseDGV)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
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
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
    }
}