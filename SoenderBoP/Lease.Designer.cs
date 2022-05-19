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
            this.panel1 = new System.Windows.Forms.Panel();
            this.MedlemNavn = new System.Windows.Forms.ComboBox();
            this.leaseDate = new System.Windows.Forms.DateTimePicker();
            this.CreateLease = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.leaseDGV = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.leaseDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.MedlemNavn);
            this.panel1.Controls.Add(this.leaseDate);
            this.panel1.Controls.Add(this.CreateLease);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(524, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(222, 450);
            this.panel1.TabIndex = 0;
            // 
            // MedlemNavn
            // 
            this.MedlemNavn.FormattingEnabled = true;
            this.MedlemNavn.Location = new System.Drawing.Point(11, 99);
            this.MedlemNavn.Name = "MedlemNavn";
            this.MedlemNavn.Size = new System.Drawing.Size(183, 28);
            this.MedlemNavn.TabIndex = 5;
            // 
            // leaseDate
            // 
            this.leaseDate.Location = new System.Drawing.Point(15, 205);
            this.leaseDate.Name = "leaseDate";
            this.leaseDate.Size = new System.Drawing.Size(179, 26);
            this.leaseDate.TabIndex = 4;
            // 
            // CreateLease
            // 
            this.CreateLease.Location = new System.Drawing.Point(55, 329);
            this.CreateLease.Name = "CreateLease";
            this.CreateLease.Size = new System.Drawing.Size(127, 32);
            this.CreateLease.TabIndex = 3;
            this.CreateLease.Text = "Opret";
            this.CreateLease.UseVisualStyleBackColor = true;
            this.CreateLease.Click += new System.EventHandler(this.CreateLease_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 171);
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
            this.label2.Size = new System.Drawing.Size(45, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Navn";
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
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(524, 450);
            this.panel2.TabIndex = 1;
            // 
            // leaseDGV
            // 
            this.leaseDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.leaseDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.leaseDGV.BackgroundColor = System.Drawing.Color.Linen;
            this.leaseDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.leaseDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.leaseDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.leaseDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.leaseDGV.GridColor = System.Drawing.Color.Linen;
            this.leaseDGV.Location = new System.Drawing.Point(0, 0);
            this.leaseDGV.Name = "leaseDGV";
            this.leaseDGV.RowHeadersVisible = false;
            this.leaseDGV.RowHeadersWidth = 62;
            this.leaseDGV.RowTemplate.Height = 28;
            this.leaseDGV.Size = new System.Drawing.Size(524, 450);
            this.leaseDGV.TabIndex = 0;
            // 
            // Lease
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Lease";
            this.Text = "Lease";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.ComboBox MedlemNavn;
        private System.Windows.Forms.DateTimePicker leaseDate;
    }
}