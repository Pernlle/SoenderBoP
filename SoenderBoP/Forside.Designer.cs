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
            this.panel1 = new System.Windows.Forms.Panel();
            this.sloganPanel = new System.Windows.Forms.Panel();
            this.manuPanel.SuspendLayout();
            this.BackgroundPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // manuPanel
            // 
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
            this.manuPanel.Location = new System.Drawing.Point(0, 0);
            this.manuPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.manuPanel.Name = "manuPanel";
            this.manuPanel.Size = new System.Drawing.Size(225, 477);
            this.manuPanel.TabIndex = 0;
            // 
            // searchBtn
            // 
            this.searchBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.searchBtn.Location = new System.Drawing.Point(0, 314);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(225, 42);
            this.searchBtn.TabIndex = 3;
            this.searchBtn.Text = "Søg boliger";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // leaseBtn
            // 
            this.leaseBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.leaseBtn.Location = new System.Drawing.Point(0, 274);
            this.leaseBtn.Name = "leaseBtn";
            this.leaseBtn.Size = new System.Drawing.Size(225, 40);
            this.leaseBtn.TabIndex = 4;
            this.leaseBtn.Text = "Lejekontrakt";
            this.leaseBtn.UseVisualStyleBackColor = true;
            this.leaseBtn.Click += new System.EventHandler(this.leaseBtn_Click);
            // 
            // waitListBtn
            // 
            this.waitListBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.waitListBtn.Location = new System.Drawing.Point(0, 232);
            this.waitListBtn.Name = "waitListBtn";
            this.waitListBtn.Size = new System.Drawing.Size(225, 42);
            this.waitListBtn.TabIndex = 6;
            this.waitListBtn.Text = "Venteliste";
            this.waitListBtn.UseVisualStyleBackColor = true;
            this.waitListBtn.Click += new System.EventHandler(this.waitListBtn_Click);
            // 
            // loginBtn
            // 
            this.loginBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.loginBtn.Location = new System.Drawing.Point(0, 428);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(225, 49);
            this.loginBtn.TabIndex = 5;
            this.loginBtn.Text = "Log på";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // reservationBtn
            // 
            this.reservationBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.reservationBtn.Location = new System.Drawing.Point(0, 187);
            this.reservationBtn.Name = "reservationBtn";
            this.reservationBtn.Size = new System.Drawing.Size(225, 45);
            this.reservationBtn.TabIndex = 4;
            this.reservationBtn.Text = "Reserver ressource";
            this.reservationBtn.UseVisualStyleBackColor = true;
            this.reservationBtn.Click += new System.EventHandler(this.reservationBtn_Click);
            // 
            // statsBtn
            // 
            this.statsBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.statsBtn.Location = new System.Drawing.Point(0, 141);
            this.statsBtn.Name = "statsBtn";
            this.statsBtn.Size = new System.Drawing.Size(225, 46);
            this.statsBtn.TabIndex = 3;
            this.statsBtn.Text = "Udtræk statistik";
            this.statsBtn.UseVisualStyleBackColor = true;
            this.statsBtn.Click += new System.EventHandler(this.statsBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.editBtn.Location = new System.Drawing.Point(0, 94);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(225, 47);
            this.editBtn.TabIndex = 2;
            this.editBtn.Text = "Rediger medlem";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // readBtn
            // 
            this.readBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.readBtn.Location = new System.Drawing.Point(0, 48);
            this.readBtn.Name = "readBtn";
            this.readBtn.Size = new System.Drawing.Size(225, 46);
            this.readBtn.TabIndex = 2;
            this.readBtn.Text = "Se medlemmer";
            this.readBtn.UseVisualStyleBackColor = true;
            this.readBtn.Click += new System.EventHandler(this.readBtn_Click);
            // 
            // createBtn
            // 
            this.createBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.createBtn.Location = new System.Drawing.Point(0, 0);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(225, 48);
            this.createBtn.TabIndex = 1;
            this.createBtn.Text = "Opret medlem";
            this.createBtn.UseVisualStyleBackColor = true;
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
            // 
            // BackgroundPanel
            // 
            this.BackgroundPanel.Controls.Add(this.panel1);
            this.BackgroundPanel.Controls.Add(this.sloganPanel);
            this.BackgroundPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BackgroundPanel.Location = new System.Drawing.Point(225, 0);
            this.BackgroundPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BackgroundPanel.Name = "BackgroundPanel";
            this.BackgroundPanel.Size = new System.Drawing.Size(675, 477);
            this.BackgroundPanel.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(675, 477);
            this.panel1.TabIndex = 1;
            // 
            // sloganPanel
            // 
            this.sloganPanel.Location = new System.Drawing.Point(0, 397);
            this.sloganPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sloganPanel.Name = "sloganPanel";
            this.sloganPanel.Size = new System.Drawing.Size(675, 80);
            this.sloganPanel.TabIndex = 0;
            // 
            // Forside
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 477);
            this.Controls.Add(this.BackgroundPanel);
            this.Controls.Add(this.manuPanel);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Forside";
            this.Text = "Forside";
            this.Load += new System.EventHandler(this.Forside_Load);
            this.manuPanel.ResumeLayout(false);
            this.BackgroundPanel.ResumeLayout(false);
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
    }
}

