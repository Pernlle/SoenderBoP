﻿namespace SoenderBoP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Forside));
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.sloganLabel = new System.Windows.Forms.Label();
            this.medlemTableAdapter = new SoenderBoP.soenderbodbDataSetTableAdapters.MedlemTableAdapter();
            this.manuPanel.SuspendLayout();
            this.BackgroundPanel.SuspendLayout();
            this.sloganPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // manuPanel
            // 
            this.manuPanel.BackColor = System.Drawing.SystemColors.Control;
            this.manuPanel.Controls.Add(this.loginBtn);
            this.manuPanel.Controls.Add(this.reservationBtn);
            this.manuPanel.Controls.Add(this.statsBtn);
            this.manuPanel.Controls.Add(this.editBtn);
            this.manuPanel.Controls.Add(this.readBtn);
            this.manuPanel.Controls.Add(this.createBtn);
            this.manuPanel.Controls.Add(this.waitListBtn);
            this.manuPanel.Controls.Add(this.leaseBtn);
            this.manuPanel.Controls.Add(this.searchBtn);
            this.manuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.manuPanel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.manuPanel.Location = new System.Drawing.Point(0, 0);
            this.manuPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.manuPanel.Name = "manuPanel";
            this.manuPanel.Size = new System.Drawing.Size(264, 680);
            this.manuPanel.TabIndex = 1;
            // 
            // searchBtn
            // 
            this.searchBtn.BackColor = System.Drawing.Color.IndianRed;
            this.searchBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.searchBtn.FlatAppearance.BorderColor = System.Drawing.Color.SeaShell;
            this.searchBtn.FlatAppearance.BorderSize = 0;
            this.searchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn.ForeColor = System.Drawing.Color.White;
            this.searchBtn.Location = new System.Drawing.Point(0, 0);
            this.searchBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(264, 59);
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
            this.leaseBtn.FlatAppearance.BorderColor = System.Drawing.Color.SeaShell;
            this.leaseBtn.FlatAppearance.BorderSize = 0;
            this.leaseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.leaseBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leaseBtn.ForeColor = System.Drawing.Color.White;
            this.leaseBtn.Location = new System.Drawing.Point(0, 59);
            this.leaseBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.leaseBtn.Name = "leaseBtn";
            this.leaseBtn.Size = new System.Drawing.Size(264, 58);
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
            this.waitListBtn.FlatAppearance.BorderColor = System.Drawing.Color.SeaShell;
            this.waitListBtn.FlatAppearance.BorderSize = 0;
            this.waitListBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.waitListBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.waitListBtn.ForeColor = System.Drawing.Color.White;
            this.waitListBtn.Location = new System.Drawing.Point(0, 117);
            this.waitListBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.waitListBtn.Name = "waitListBtn";
            this.waitListBtn.Size = new System.Drawing.Size(264, 59);
            this.waitListBtn.TabIndex = 2;
            this.waitListBtn.Text = "Venteliste";
            this.waitListBtn.UseVisualStyleBackColor = false;
            this.waitListBtn.Click += new System.EventHandler(this.waitListBtn_Click);
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.Color.IndianRed;
            this.loginBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.loginBtn.FlatAppearance.BorderSize = 0;
            this.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBtn.ForeColor = System.Drawing.Color.White;
            this.loginBtn.Location = new System.Drawing.Point(0, 492);
            this.loginBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(264, 62);
            this.loginBtn.TabIndex = 1;
            this.loginBtn.Text = "LOG PÅ";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // reservationBtn
            // 
            this.reservationBtn.BackColor = System.Drawing.Color.IndianRed;
            this.reservationBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reservationBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.reservationBtn.FlatAppearance.BorderColor = System.Drawing.Color.SeaShell;
            this.reservationBtn.FlatAppearance.BorderSize = 0;
            this.reservationBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reservationBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reservationBtn.ForeColor = System.Drawing.Color.White;
            this.reservationBtn.Location = new System.Drawing.Point(0, 430);
            this.reservationBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.reservationBtn.Name = "reservationBtn";
            this.reservationBtn.Size = new System.Drawing.Size(264, 62);
            this.reservationBtn.TabIndex = 0;
            this.reservationBtn.Text = "Reserver ressource";
            this.reservationBtn.UseVisualStyleBackColor = false;
            this.reservationBtn.Click += new System.EventHandler(this.reservationBtn_Click);
            // 
            // statsBtn
            // 
            this.statsBtn.BackColor = System.Drawing.Color.IndianRed;
            this.statsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.statsBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.statsBtn.FlatAppearance.BorderColor = System.Drawing.Color.SeaShell;
            this.statsBtn.FlatAppearance.BorderSize = 0;
            this.statsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.statsBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statsBtn.ForeColor = System.Drawing.Color.White;
            this.statsBtn.Location = new System.Drawing.Point(0, 368);
            this.statsBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.statsBtn.Name = "statsBtn";
            this.statsBtn.Size = new System.Drawing.Size(264, 62);
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
            this.editBtn.FlatAppearance.BorderColor = System.Drawing.Color.SeaShell;
            this.editBtn.FlatAppearance.BorderSize = 0;
            this.editBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editBtn.ForeColor = System.Drawing.Color.White;
            this.editBtn.Location = new System.Drawing.Point(0, 303);
            this.editBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(264, 65);
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
            this.readBtn.FlatAppearance.BorderColor = System.Drawing.Color.SeaShell;
            this.readBtn.FlatAppearance.BorderSize = 0;
            this.readBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.readBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readBtn.ForeColor = System.Drawing.Color.White;
            this.readBtn.Location = new System.Drawing.Point(0, 241);
            this.readBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.readBtn.Name = "readBtn";
            this.readBtn.Size = new System.Drawing.Size(264, 62);
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
            this.createBtn.FlatAppearance.BorderColor = System.Drawing.Color.SeaShell;
            this.createBtn.FlatAppearance.BorderSize = 0;
            this.createBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createBtn.ForeColor = System.Drawing.Color.White;
            this.createBtn.Location = new System.Drawing.Point(0, 176);
            this.createBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(264, 65);
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
            this.BackgroundPanel.Location = new System.Drawing.Point(264, 0);
            this.BackgroundPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BackgroundPanel.Name = "BackgroundPanel";
            this.BackgroundPanel.Size = new System.Drawing.Size(686, 680);
            this.BackgroundPanel.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Linen;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(686, 680);
            this.panel1.TabIndex = 0;
            // 
            // sloganPanel
            // 
            this.sloganPanel.BackColor = System.Drawing.SystemColors.Control;
            this.sloganPanel.Controls.Add(this.pictureBox1);
            this.sloganPanel.Controls.Add(this.sloganLabel);
            this.sloganPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.sloganPanel.Location = new System.Drawing.Point(0, 570);
            this.sloganPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sloganPanel.Name = "sloganPanel";
            this.sloganPanel.Size = new System.Drawing.Size(686, 110);
            this.sloganPanel.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = global::SoenderBoP.Properties.Resources.Boligforeningen;
            this.pictureBox1.Location = new System.Drawing.Point(578, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(108, 110);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // sloganLabel
            // 
            this.sloganLabel.AutoSize = true;
            this.sloganLabel.BackColor = System.Drawing.Color.Transparent;
            this.sloganLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sloganLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sloganLabel.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.sloganLabel.Location = new System.Drawing.Point(0, 0);
            this.sloganLabel.Name = "sloganLabel";
            this.sloganLabel.Size = new System.Drawing.Size(275, 32);
            this.sloganLabel.TabIndex = 0;
            this.sloganLabel.Text = "SønderBo er søndme god";
            this.sloganLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // medlemTableAdapter
            // 
            this.medlemTableAdapter.ClearBeforeFill = true;
            // 
            // Forside
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 680);
            this.Controls.Add(this.BackgroundPanel);
            this.Controls.Add(this.manuPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Forside";
            this.Text = "Sønderbo Boligforening";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Forside_FormClosing);
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
        private soenderbodbDataSetTableAdapters.MedlemTableAdapter medlemTableAdapter;
    }
}

