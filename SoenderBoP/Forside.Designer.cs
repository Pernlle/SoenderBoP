namespace SoenderBoP
{
    partial class Forside
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
            this.manuPanel = new System.Windows.Forms.Panel();
            this.searchBtn = new System.Windows.Forms.Button();
            this.leaseBtn = new System.Windows.Forms.Button();
            this.waitListBtn = new System.Windows.Forms.Button();
            this.loginBtn = new System.Windows.Forms.Button();
            this.reservationBtn = new System.Windows.Forms.Button();
            this.statsBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.readBtn = new System.Windows.Forms.Button();
            this.createBtn = new System.Windows.Forms.Button();
            this.BackgroundPanel = new System.Windows.Forms.Panel();
            this.sloganPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.sloganLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.manuPanel.SuspendLayout();
            this.BackgroundPanel.SuspendLayout();
            this.sloganPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // manuPanel
            // 
            this.manuPanel.BackColor = System.Drawing.Color.White;
            this.manuPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.manuPanel.Controls.Add(this.searchBtn);
            this.manuPanel.Controls.Add(this.leaseBtn);
            this.manuPanel.Controls.Add(this.waitListBtn);
            this.manuPanel.Controls.Add(this.loginBtn);
            this.manuPanel.Controls.Add(this.reservationBtn);
            this.manuPanel.Controls.Add(this.statsBtn);
            this.manuPanel.Controls.Add(this.editBtn);
            this.manuPanel.Controls.Add(this.readBtn);
            this.manuPanel.Controls.Add(this.createBtn);
            this.manuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.manuPanel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.manuPanel.Location = new System.Drawing.Point(0, 0);
            this.manuPanel.Name = "manuPanel";
            this.manuPanel.Size = new System.Drawing.Size(200, 544);
            this.manuPanel.TabIndex = 0;
            // 
            // searchBtn
            // 
            this.searchBtn.BackColor = System.Drawing.Color.IndianRed;
            this.searchBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.searchBtn.Location = new System.Drawing.Point(0, 252);
            this.searchBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(196, 34);
            this.searchBtn.TabIndex = 3;
            this.searchBtn.Text = "Søg boliger";
            this.searchBtn.UseVisualStyleBackColor = false;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // leaseBtn
            // 
            this.leaseBtn.BackColor = System.Drawing.Color.IndianRed;
            this.leaseBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.leaseBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.leaseBtn.Location = new System.Drawing.Point(0, 220);
            this.leaseBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.leaseBtn.Name = "leaseBtn";
            this.leaseBtn.Size = new System.Drawing.Size(196, 32);
            this.leaseBtn.TabIndex = 4;
            this.leaseBtn.Text = "Lejekontrakt";
            this.leaseBtn.UseVisualStyleBackColor = false;
            this.leaseBtn.Click += new System.EventHandler(this.leaseBtn_Click);
            // 
            // waitListBtn
            // 
            this.waitListBtn.BackColor = System.Drawing.Color.IndianRed;
            this.waitListBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.waitListBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.waitListBtn.Location = new System.Drawing.Point(0, 186);
            this.waitListBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.waitListBtn.Name = "waitListBtn";
            this.waitListBtn.Size = new System.Drawing.Size(196, 34);
            this.waitListBtn.TabIndex = 6;
            this.waitListBtn.Text = "Venteliste";
            this.waitListBtn.UseVisualStyleBackColor = false;
            this.waitListBtn.Click += new System.EventHandler(this.waitListBtn_Click);
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.Color.IndianRed;
            this.loginBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.loginBtn.Location = new System.Drawing.Point(0, 501);
            this.loginBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(196, 39);
            this.loginBtn.TabIndex = 5;
            this.loginBtn.Text = "Log på";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // reservationBtn
            // 
            this.reservationBtn.BackColor = System.Drawing.Color.IndianRed;
            this.reservationBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reservationBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.reservationBtn.Location = new System.Drawing.Point(0, 150);
            this.reservationBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.reservationBtn.Name = "reservationBtn";
            this.reservationBtn.Size = new System.Drawing.Size(196, 36);
            this.reservationBtn.TabIndex = 4;
            this.reservationBtn.Text = "Reserver ressource";
            this.reservationBtn.UseVisualStyleBackColor = false;
            this.reservationBtn.Click += new System.EventHandler(this.reservationBtn_Click);
            // 
            // statsBtn
            // 
            this.statsBtn.BackColor = System.Drawing.Color.IndianRed;
            this.statsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.statsBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.statsBtn.Location = new System.Drawing.Point(0, 113);
            this.statsBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.statsBtn.Name = "statsBtn";
            this.statsBtn.Size = new System.Drawing.Size(196, 37);
            this.statsBtn.TabIndex = 3;
            this.statsBtn.Text = "Udtræk statistik";
            this.statsBtn.UseVisualStyleBackColor = false;
            this.statsBtn.Click += new System.EventHandler(this.statsBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.BackColor = System.Drawing.Color.IndianRed;
            this.editBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.editBtn.Location = new System.Drawing.Point(0, 75);
            this.editBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(196, 38);
            this.editBtn.TabIndex = 2;
            this.editBtn.Text = "Rediger medlem";
            this.editBtn.UseVisualStyleBackColor = false;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // readBtn
            // 
            this.readBtn.BackColor = System.Drawing.Color.IndianRed;
            this.readBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.readBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.readBtn.Location = new System.Drawing.Point(0, 38);
            this.readBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.readBtn.Name = "readBtn";
            this.readBtn.Size = new System.Drawing.Size(196, 37);
            this.readBtn.TabIndex = 2;
            this.readBtn.Text = "Se medlemmer";
            this.readBtn.UseVisualStyleBackColor = false;
            this.readBtn.Click += new System.EventHandler(this.readBtn_Click);
            // 
            // createBtn
            // 
            this.createBtn.BackColor = System.Drawing.Color.IndianRed;
            this.createBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.createBtn.Location = new System.Drawing.Point(0, 0);
            this.createBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(196, 38);
            this.createBtn.TabIndex = 1;
            this.createBtn.Text = "Opret medlem";
            this.createBtn.UseVisualStyleBackColor = false;
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
            // 
            // BackgroundPanel
            // 
            this.BackgroundPanel.Controls.Add(this.sloganPanel);
            this.BackgroundPanel.Controls.Add(this.panel1);
            this.BackgroundPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BackgroundPanel.Location = new System.Drawing.Point(200, 0);
            this.BackgroundPanel.Name = "BackgroundPanel";
            this.BackgroundPanel.Size = new System.Drawing.Size(644, 544);
            this.BackgroundPanel.TabIndex = 1;
            // 
            // sloganPanel
            // 
            this.sloganPanel.Controls.Add(this.pictureBox1);
            this.sloganPanel.Controls.Add(this.sloganLabel);
            this.sloganPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.sloganPanel.Location = new System.Drawing.Point(0, 427);
            this.sloganPanel.Name = "sloganPanel";
            this.sloganPanel.Size = new System.Drawing.Size(644, 117);
            this.sloganPanel.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = global::SoenderBoP.Properties.Resources.Boligforeningen;
            this.pictureBox1.Location = new System.Drawing.Point(524, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 117);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // sloganLabel
            // 
            this.sloganLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sloganLabel.AutoSize = true;
            this.sloganLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sloganLabel.Location = new System.Drawing.Point(17, 25);
            this.sloganLabel.Name = "sloganLabel";
            this.sloganLabel.Size = new System.Drawing.Size(355, 36);
            this.sloganLabel.TabIndex = 0;
            this.sloganLabel.Text = "SønderBo er søndme god";
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(644, 544);
            this.panel1.TabIndex = 1;
            // 
            // Forside
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 544);
            this.Controls.Add(this.BackgroundPanel);
            this.Controls.Add(this.manuPanel);
            this.Name = "Forside";
            this.Text = "Forside";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Forside_Load);
            this.manuPanel.ResumeLayout(false);
            this.BackgroundPanel.ResumeLayout(false);
            this.sloganPanel.ResumeLayout(false);
            this.sloganPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel BackgroundPanel;
        private System.Windows.Forms.Panel sloganPanel;
        public System.Windows.Forms.Panel manuPanel;
        public System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Button reservationBtn;
        private System.Windows.Forms.Button statsBtn;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Button readBtn;
        private System.Windows.Forms.Button createBtn;
        private System.Windows.Forms.Button waitListBtn;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Button leaseBtn;
        private System.Windows.Forms.Label sloganLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

