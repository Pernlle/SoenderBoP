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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.medlemTableAdapter1 = new SoenderBoP.soenderbodbDataSet1TableAdapters.MedlemTableAdapter();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.editMedlemDGV.DefaultCellStyle = dataGridViewCellStyle1;
            this.editMedlemDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editMedlemDGV.Location = new System.Drawing.Point(0, 0);
            this.editMedlemDGV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.editMedlemDGV.Name = "editMedlemDGV";
            this.editMedlemDGV.RowHeadersWidth = 62;
            this.editMedlemDGV.Size = new System.Drawing.Size(585, 490);
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
            this.deleteBtn.Location = new System.Drawing.Point(15, 398);
            this.deleteBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(224, 44);
            this.deleteBtn.TabIndex = 1;
            this.deleteBtn.Text = "Slet";
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
            this.updateBtn.Location = new System.Drawing.Point(15, 321);
            this.updateBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(224, 42);
            this.updateBtn.TabIndex = 2;
            this.updateBtn.Text = "Opdater";
            this.updateBtn.UseVisualStyleBackColor = false;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // tlfMTxt
            // 
            this.tlfMTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tlfMTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tlfMTxt.Location = new System.Drawing.Point(15, 186);
            this.tlfMTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tlfMTxt.Name = "tlfMTxt";
            this.tlfMTxt.Size = new System.Drawing.Size(224, 32);
            this.tlfMTxt.TabIndex = 3;
            // 
            // emailMTxt
            // 
            this.emailMTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.emailMTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.emailMTxt.Location = new System.Drawing.Point(15, 248);
            this.emailMTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.emailMTxt.Name = "emailMTxt";
            this.emailMTxt.Size = new System.Drawing.Size(224, 32);
            this.emailMTxt.TabIndex = 4;
            // 
            // navnTxt
            // 
            this.navnTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.navnTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.navnTxt.Location = new System.Drawing.Point(15, 124);
            this.navnTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.navnTxt.Name = "navnTxt";
            this.navnTxt.ReadOnly = true;
            this.navnTxt.Size = new System.Drawing.Size(224, 32);
            this.navnTxt.TabIndex = 5;
            this.navnTxt.TabStop = false;
            // 
            // medlemTableAdapter
            // 
            this.medlemTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.navnTxt);
            this.panel1.Controls.Add(this.updateBtn);
            this.panel1.Controls.Add(this.emailMTxt);
            this.panel1.Controls.Add(this.deleteBtn);
            this.panel1.Controls.Add(this.tlfMTxt);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(585, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(253, 490);
            this.panel1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 40);
            this.label1.TabIndex = 6;
            this.label1.Text = "Rediger";
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(11, 499);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(141, 355);
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
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(846, 531);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.editMedlemDGV);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Location = new System.Drawing.Point(4, 37);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(838, 490);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Rediger medlemmer";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(846, 531);
            this.Controls.Add(this.tabControl1);
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
    }
}