﻿namespace SoenderBoP
{
    partial class Edit
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.editMedlemDGV = new System.Windows.Forms.DataGridView();
            this.medlemBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.soenderbodbDataSet1 = new SoenderBoP.soenderbodbDataSet1();
            this.medlemBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.soenderbodbDataSet = new SoenderBoP.soenderbodbDataSet();
            this.medlemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.deleteBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.tlfMTxt = new System.Windows.Forms.MaskedTextBox();
            this.emailMTxt = new System.Windows.Forms.MaskedTextBox();
            this.navnTxt = new System.Windows.Forms.TextBox();
            this.medlemTableAdapter = new SoenderBoP.soenderbodbDataSetTableAdapters.MedlemTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.unObserveMcheckBx = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.medlemTableAdapter1 = new SoenderBoP.soenderbodbDataSet1TableAdapters.MedlemTableAdapter();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.helpBTN = new System.Windows.Forms.Button();
            this.navnLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.editMedlemDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medlemBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soenderbodbDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medlemBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soenderbodbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medlemBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // editMedlemDGV
            // 
            this.editMedlemDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.editMedlemDGV.BackgroundColor = System.Drawing.Color.Linen;
            this.editMedlemDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.editMedlemDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.editMedlemDGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.editMedlemDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editMedlemDGV.Location = new System.Drawing.Point(0, 0);
            this.editMedlemDGV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.editMedlemDGV.Name = "editMedlemDGV";
            this.editMedlemDGV.RowHeadersWidth = 62;
            this.editMedlemDGV.Size = new System.Drawing.Size(447, 556);
            this.editMedlemDGV.TabIndex = 0;
            this.editMedlemDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.medlemDGV_CellClick);
            // 
            // medlemBindingSource2
            // 
            this.medlemBindingSource2.DataMember = "Medlem";
            this.medlemBindingSource2.DataSource = this.soenderbodbDataSet1;
            // 
            // soenderbodbDataSet1
            // 
            this.soenderbodbDataSet1.DataSetName = "soenderbodbDataSet1";
            this.soenderbodbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // medlemBindingSource1
            // 
            this.medlemBindingSource1.DataMember = "Medlem";
            this.medlemBindingSource1.DataSource = this.soenderbodbDataSet;
            // 
            // soenderbodbDataSet
            // 
            this.soenderbodbDataSet.DataSetName = "soenderbodbDataSet";
            this.soenderbodbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // medlemBindingSource
            // 
            this.medlemBindingSource.DataMember = "Medlem";
            this.medlemBindingSource.DataSource = this.soenderbodbDataSet;
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.IndianRed;
            this.deleteBtn.FlatAppearance.BorderSize = 0;
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.ForeColor = System.Drawing.Color.White;
            this.deleteBtn.Location = new System.Drawing.Point(20, 460);
            this.deleteBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(255, 35);
            this.deleteBtn.TabIndex = 1;
            this.deleteBtn.Text = "SLET";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.BackColor = System.Drawing.Color.IndianRed;
            this.updateBtn.FlatAppearance.BorderSize = 0;
            this.updateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBtn.ForeColor = System.Drawing.Color.White;
            this.updateBtn.Location = new System.Drawing.Point(20, 399);
            this.updateBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(255, 34);
            this.updateBtn.TabIndex = 2;
            this.updateBtn.Text = "OPDATER";
            this.updateBtn.UseVisualStyleBackColor = false;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // tlfMTxt
            // 
            this.tlfMTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tlfMTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tlfMTxt.Location = new System.Drawing.Point(19, 232);
            this.tlfMTxt.Name = "tlfMTxt";
            this.tlfMTxt.Size = new System.Drawing.Size(255, 27);
            this.tlfMTxt.TabIndex = 3;
            // 
            // emailMTxt
            // 
            this.emailMTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.emailMTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.emailMTxt.Location = new System.Drawing.Point(19, 307);
            this.emailMTxt.Name = "emailMTxt";
            this.emailMTxt.Size = new System.Drawing.Size(255, 27);
            this.emailMTxt.TabIndex = 4;
            // 
            // navnTxt
            // 
            this.navnTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.navnTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.navnTxt.Location = new System.Drawing.Point(595, 158);
            this.navnTxt.Name = "navnTxt";
            this.navnTxt.Size = new System.Drawing.Size(255, 15);
            this.navnTxt.TabIndex = 5;
            this.navnTxt.TabStop = false;
            // 
            // medlemTableAdapter
            // 
            this.medlemTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.navnLabel);
            this.panel1.Controls.Add(this.unObserveMcheckBx);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.updateBtn);
            this.panel1.Controls.Add(this.emailMTxt);
            this.panel1.Controls.Add(this.deleteBtn);
            this.panel1.Controls.Add(this.tlfMTxt);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(447, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(298, 556);
            this.panel1.TabIndex = 6;
            // 
            // unObserveMcheckBx
            // 
            this.unObserveMcheckBx.AutoSize = true;
            this.unObserveMcheckBx.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unObserveMcheckBx.Location = new System.Drawing.Point(265, 359);
            this.unObserveMcheckBx.Name = "unObserveMcheckBx";
            this.unObserveMcheckBx.Size = new System.Drawing.Size(18, 17);
            this.unObserveMcheckBx.TabIndex = 12;
            this.unObserveMcheckBx.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 350);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(236, 28);
            this.label6.TabIndex = 11;
            this.label6.Text = "Fjern medlem fra mailliste";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(240, 28);
            this.label5.TabIndex = 10;
            this.label5.Text = "Vælg et medlem i tabellen";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 28);
            this.label4.TabIndex = 9;
            this.label4.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 28);
            this.label3.TabIndex = 8;
            this.label3.Text = "Telefonnummer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 28);
            this.label2.TabIndex = 7;
            this.label2.Text = "Navn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 36);
            this.label1.TabIndex = 6;
            this.label1.Text = "Rediger";
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(10, 399);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(125, 284);
            this.panel2.TabIndex = 7;
            // 
            // medlemTableAdapter1
            // 
            this.medlemTableAdapter1.ClearBeforeFill = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(753, 592);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.editMedlemDGV);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.helpBTN);
            this.tabPage1.Location = new System.Drawing.Point(4, 32);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(745, 556);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Rediger medlemmer";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // helpBTN
            // 
            this.helpBTN.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.helpBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.helpBTN.Cursor = System.Windows.Forms.Cursors.Help;
            this.helpBTN.FlatAppearance.BorderSize = 0;
            this.helpBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.helpBTN.Font = new System.Drawing.Font("Agency FB", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpBTN.ForeColor = System.Drawing.Color.White;
            this.helpBTN.Location = new System.Drawing.Point(284, 414);
            this.helpBTN.Margin = new System.Windows.Forms.Padding(0);
            this.helpBTN.Name = "helpBTN";
            this.helpBTN.Padding = new System.Windows.Forms.Padding(1);
            this.helpBTN.Size = new System.Drawing.Size(73, 61);
            this.helpBTN.TabIndex = 0;
            this.helpBTN.Text = "?";
            this.helpBTN.UseVisualStyleBackColor = false;
            // 
            // navnLabel
            // 
            this.navnLabel.AutoSize = true;
            this.navnLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.navnLabel.Location = new System.Drawing.Point(16, 152);
            this.navnLabel.Name = "navnLabel";
            this.navnLabel.Size = new System.Drawing.Size(242, 28);
            this.navnLabel.TabIndex = 13;
            this.navnLabel.Text = "                                              ";
            // 
            // Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(753, 592);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.navnTxt);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Edit";
            this.Text = "Edit";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Edit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.editMedlemDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medlemBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soenderbodbDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medlemBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soenderbodbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medlemBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView editMedlemDGV;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.MaskedTextBox tlfMTxt;
        private System.Windows.Forms.MaskedTextBox emailMTxt;
        private System.Windows.Forms.TextBox navnTxt;
        private soenderbodbDataSet soenderbodbDataSet;
        private System.Windows.Forms.BindingSource medlemBindingSource;
        private soenderbodbDataSetTableAdapters.MedlemTableAdapter medlemTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.BindingSource medlemBindingSource1;
        private System.Windows.Forms.Label label1;
        private soenderbodbDataSet1 soenderbodbDataSet1;
        private System.Windows.Forms.BindingSource medlemBindingSource2;
        private soenderbodbDataSet1TableAdapters.MedlemTableAdapter medlemTableAdapter1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button helpBTN;
        private System.Windows.Forms.CheckBox unObserveMcheckBx;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label navnLabel;
    }
}