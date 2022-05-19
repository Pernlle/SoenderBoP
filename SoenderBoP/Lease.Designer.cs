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
            this.panel3 = new System.Windows.Forms.Panel();
            this.leasePrintbtn = new System.Windows.Forms.Button();
            this.emailCBX = new System.Windows.Forms.ComboBox();
            this.leaseDTP = new System.Windows.Forms.DateTimePicker();
            this.CreateLease = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.leaseDGV = new System.Windows.Forms.DataGridView();
            this.mId = new System.Windows.Forms.TextBox();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.leaseDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.refreshBtn);
            this.panel1.Controls.Add(this.mId);
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
            this.emailCBX.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.emailCBX.FormattingEnabled = true;
            this.emailCBX.Location = new System.Drawing.Point(15, 97);
            this.emailCBX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.emailCBX.Name = "emailCBX";
            this.emailCBX.Size = new System.Drawing.Size(127, 28);
            this.emailCBX.TabIndex = 5;
            this.emailCBX.Click += new System.EventHandler(this.emailCBX_Click);
            // 
            // leaseDTP
            // 
            this.leaseDTP.Location = new System.Drawing.Point(15, 205);
            this.leaseDTP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.leaseDTP.Name = "leaseDTP";
            this.leaseDTP.Size = new System.Drawing.Size(180, 26);
            this.leaseDTP.TabIndex = 4;
            this.leaseDTP.Value = new System.DateTime(2022, 5, 19, 0, 0, 0, 0);
            // 
            // CreateLease
            // 
            this.CreateLease.Location = new System.Drawing.Point(46, 329);
            this.CreateLease.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            // mId
            // 
            this.mId.Location = new System.Drawing.Point(149, 98);
            this.mId.Name = "mId";
            this.mId.Size = new System.Drawing.Size(61, 26);
            this.mId.TabIndex = 7;
            // 
            // refreshBtn
            // 
            this.refreshBtn.Location = new System.Drawing.Point(194, 0);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(28, 32);
            this.refreshBtn.TabIndex = 8;
            this.refreshBtn.Text = "R";
            this.refreshBtn.UseVisualStyleBackColor = true;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
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
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
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
        private System.Windows.Forms.TextBox mId;
        private System.Windows.Forms.Button refreshBtn;
    }
}