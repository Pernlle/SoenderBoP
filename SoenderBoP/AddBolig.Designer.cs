namespace SoenderBoP
{
    partial class AddBolig
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.adresseMTxt = new System.Windows.Forms.MaskedTextBox();
            this.typeMTxt = new System.Windows.Forms.MaskedTextBox();
            this.kvmMTxt = new System.Windows.Forms.MaskedTextBox();
            this.prisTextBox3 = new System.Windows.Forms.MaskedTextBox();
            this.createBBtn = new System.Windows.Forms.Button();
            this.notifyMBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(39, 93);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 605);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Linen;
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 576);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Opret bolig";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.notifyMBtn);
            this.panel2.Controls.Add(this.createBBtn);
            this.panel2.Controls.Add(this.prisTextBox3);
            this.panel2.Controls.Add(this.kvmMTxt);
            this.panel2.Controls.Add(this.typeMTxt);
            this.panel2.Controls.Add(this.adresseMTxt);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(478, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(311, 570);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Opret ny bolig";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Adresse";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(34, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 28);
            this.label4.TabIndex = 3;
            this.label4.Text = "Kvm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(34, 290);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 28);
            this.label5.TabIndex = 4;
            this.label5.Text = "Pris";
            // 
            // adresseMTxt
            // 
            this.adresseMTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.adresseMTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.adresseMTxt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adresseMTxt.Location = new System.Drawing.Point(21, 123);
            this.adresseMTxt.Name = "adresseMTxt";
            this.adresseMTxt.Size = new System.Drawing.Size(276, 27);
            this.adresseMTxt.TabIndex = 5;
            // 
            // typeMTxt
            // 
            this.typeMTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.typeMTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.typeMTxt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeMTxt.Location = new System.Drawing.Point(17, 194);
            this.typeMTxt.Name = "typeMTxt";
            this.typeMTxt.Size = new System.Drawing.Size(276, 27);
            this.typeMTxt.TabIndex = 6;
            // 
            // kvmMTxt
            // 
            this.kvmMTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.kvmMTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.kvmMTxt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kvmMTxt.Location = new System.Drawing.Point(21, 260);
            this.kvmMTxt.Name = "kvmMTxt";
            this.kvmMTxt.Size = new System.Drawing.Size(276, 27);
            this.kvmMTxt.TabIndex = 7;
            // 
            // prisTextBox3
            // 
            this.prisTextBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.prisTextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.prisTextBox3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prisTextBox3.Location = new System.Drawing.Point(21, 321);
            this.prisTextBox3.Name = "prisTextBox3";
            this.prisTextBox3.Size = new System.Drawing.Size(276, 27);
            this.prisTextBox3.TabIndex = 8;
            // 
            // createBBtn
            // 
            this.createBBtn.BackColor = System.Drawing.Color.IndianRed;
            this.createBBtn.FlatAppearance.BorderSize = 0;
            this.createBBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createBBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createBBtn.ForeColor = System.Drawing.Color.White;
            this.createBBtn.Location = new System.Drawing.Point(21, 374);
            this.createBBtn.Name = "createBBtn";
            this.createBBtn.Size = new System.Drawing.Size(276, 38);
            this.createBBtn.TabIndex = 9;
            this.createBBtn.Text = "OPRET";
            this.createBBtn.UseVisualStyleBackColor = false;
            this.createBBtn.Click += new System.EventHandler(this.createBBtn_Click);
            // 
            // notifyMBtn
            // 
            this.notifyMBtn.BackColor = System.Drawing.Color.IndianRed;
            this.notifyMBtn.FlatAppearance.BorderSize = 0;
            this.notifyMBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.notifyMBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notifyMBtn.ForeColor = System.Drawing.Color.White;
            this.notifyMBtn.Location = new System.Drawing.Point(21, 441);
            this.notifyMBtn.Name = "notifyMBtn";
            this.notifyMBtn.Size = new System.Drawing.Size(276, 38);
            this.notifyMBtn.TabIndex = 10;
            this.notifyMBtn.Text = "NOTIFY MEDLEMMER";
            this.notifyMBtn.UseVisualStyleBackColor = false;
            this.notifyMBtn.Click += new System.EventHandler(this.notifyMBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(29, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(424, 31);
            this.label6.TabIndex = 1;
            this.label6.Text = "DENNE SIDE ER UNDER KONSTRUERING";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // AddBolig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(800, 605);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Name = "AddBolig";
            this.Text = "AddBolig";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox adresseMTxt;
        private System.Windows.Forms.MaskedTextBox prisTextBox3;
        private System.Windows.Forms.MaskedTextBox kvmMTxt;
        private System.Windows.Forms.MaskedTextBox typeMTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button notifyMBtn;
        private System.Windows.Forms.Button createBBtn;
    }
}