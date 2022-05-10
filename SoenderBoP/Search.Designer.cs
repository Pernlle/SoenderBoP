namespace SoenderBoP
{
    partial class Search
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
            this.searchBtn = new System.Windows.Forms.Button();
            this.minPrisBox = new System.Windows.Forms.MaskedTextBox();
            this.maxPrisBox = new System.Windows.Forms.MaskedTextBox();
            this.Kvm = new System.Windows.Forms.Label();
            this.minKvmLabel = new System.Windows.Forms.Label();
            this.maxKvmLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.minKvmBox = new System.Windows.Forms.MaskedTextBox();
            this.maxKvmBox = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.backgroundForDGV = new System.Windows.Forms.Panel();
            this.prisDGV = new System.Windows.Forms.Panel();
            this.kvmDGV = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.soenderbodbDataSet = new SoenderBoP.soenderbodbDataSet();
            this.boligBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.boligTableAdapter = new SoenderBoP.soenderbodbDataSetTableAdapters.BoligTableAdapter();
            this.bIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mndPrisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kvmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loebeNrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.backgroundForDGV.SuspendLayout();
            this.prisDGV.SuspendLayout();
            this.kvmDGV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soenderbodbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boligBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(279, 208);
            this.searchBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(98, 43);
            this.searchBtn.TabIndex = 13;
            this.searchBtn.Text = "Søg";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // minPrisBox
            // 
            this.minPrisBox.Location = new System.Drawing.Point(101, 105);
            this.minPrisBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.minPrisBox.Name = "minPrisBox";
            this.minPrisBox.Size = new System.Drawing.Size(89, 22);
            this.minPrisBox.TabIndex = 1;
            // 
            // maxPrisBox
            // 
            this.maxPrisBox.Location = new System.Drawing.Point(101, 158);
            this.maxPrisBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.maxPrisBox.Name = "maxPrisBox";
            this.maxPrisBox.Size = new System.Drawing.Size(89, 22);
            this.maxPrisBox.TabIndex = 2;
            // 
            // Kvm
            // 
            this.Kvm.AutoSize = true;
            this.Kvm.Location = new System.Drawing.Point(63, 235);
            this.Kvm.Name = "Kvm";
            this.Kvm.Size = new System.Drawing.Size(33, 16);
            this.Kvm.TabIndex = 3;
            this.Kvm.Text = "Kvm";
            // 
            // minKvmLabel
            // 
            this.minKvmLabel.AutoSize = true;
            this.minKvmLabel.Location = new System.Drawing.Point(63, 273);
            this.minKvmLabel.Name = "minKvmLabel";
            this.minKvmLabel.Size = new System.Drawing.Size(28, 16);
            this.minKvmLabel.TabIndex = 4;
            this.minKvmLabel.Text = "Min";
            // 
            // maxKvmLabel
            // 
            this.maxKvmLabel.AutoSize = true;
            this.maxKvmLabel.Location = new System.Drawing.Point(63, 322);
            this.maxKvmLabel.Name = "maxKvmLabel";
            this.maxKvmLabel.Size = new System.Drawing.Size(32, 16);
            this.maxKvmLabel.TabIndex = 5;
            this.maxKvmLabel.Text = "Max";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Max";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Min";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Måned Pris";
            // 
            // minKvmBox
            // 
            this.minKvmBox.Location = new System.Drawing.Point(101, 270);
            this.minKvmBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.minKvmBox.Name = "minKvmBox";
            this.minKvmBox.Size = new System.Drawing.Size(89, 22);
            this.minKvmBox.TabIndex = 9;
            // 
            // maxKvmBox
            // 
            this.maxKvmBox.Location = new System.Drawing.Point(101, 319);
            this.maxKvmBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.maxKvmBox.Name = "maxKvmBox";
            this.maxKvmBox.Size = new System.Drawing.Size(89, 22);
            this.maxKvmBox.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(577, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "SØG BOLIG";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaShell;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1220, 55);
            this.panel1.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SeaShell;
            this.panel2.Controls.Add(this.searchBtn);
            this.panel2.Controls.Add(this.minPrisBox);
            this.panel2.Controls.Add(this.maxKvmBox);
            this.panel2.Controls.Add(this.maxPrisBox);
            this.panel2.Controls.Add(this.minKvmBox);
            this.panel2.Controls.Add(this.Kvm);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.minKvmLabel);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.maxKvmLabel);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 55);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(429, 517);
            this.panel2.TabIndex = 15;
            // 
            // backgroundForDGV
            // 
            this.backgroundForDGV.Controls.Add(this.prisDGV);
            this.backgroundForDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backgroundForDGV.Location = new System.Drawing.Point(429, 55);
            this.backgroundForDGV.Name = "backgroundForDGV";
            this.backgroundForDGV.Size = new System.Drawing.Size(791, 517);
            this.backgroundForDGV.TabIndex = 16;
            // 
            // prisDGV
            // 
            this.prisDGV.Controls.Add(this.kvmDGV);
            this.prisDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.prisDGV.Location = new System.Drawing.Point(0, 0);
            this.prisDGV.Name = "prisDGV";
            this.prisDGV.Size = new System.Drawing.Size(791, 517);
            this.prisDGV.TabIndex = 0;
            // 
            // kvmDGV
            // 
            this.kvmDGV.Controls.Add(this.dataGridView1);
            this.kvmDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kvmDGV.Location = new System.Drawing.Point(0, 0);
            this.kvmDGV.Name = "kvmDGV";
            this.kvmDGV.Size = new System.Drawing.Size(791, 517);
            this.kvmDGV.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Wheat;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bIdDataGridViewTextBoxColumn,
            this.mndPrisDataGridViewTextBoxColumn,
            this.adrDataGridViewTextBoxColumn,
            this.kvmDataGridViewTextBoxColumn,
            this.bTypeDataGridViewTextBoxColumn,
            this.loebeNrDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.boligBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(791, 517);
            this.dataGridView1.TabIndex = 0;
            // 
            // soenderbodbDataSet
            // 
            this.soenderbodbDataSet.DataSetName = "soenderbodbDataSet";
            this.soenderbodbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // boligBindingSource
            // 
            this.boligBindingSource.DataMember = "Bolig";
            this.boligBindingSource.DataSource = this.soenderbodbDataSet;
            // 
            // boligTableAdapter
            // 
            this.boligTableAdapter.ClearBeforeFill = true;
            // 
            // bIdDataGridViewTextBoxColumn
            // 
            this.bIdDataGridViewTextBoxColumn.DataPropertyName = "bId";
            this.bIdDataGridViewTextBoxColumn.HeaderText = "bId";
            this.bIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bIdDataGridViewTextBoxColumn.Name = "bIdDataGridViewTextBoxColumn";
            this.bIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.bIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // mndPrisDataGridViewTextBoxColumn
            // 
            this.mndPrisDataGridViewTextBoxColumn.DataPropertyName = "mndPris";
            this.mndPrisDataGridViewTextBoxColumn.HeaderText = "mndPris";
            this.mndPrisDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mndPrisDataGridViewTextBoxColumn.Name = "mndPrisDataGridViewTextBoxColumn";
            this.mndPrisDataGridViewTextBoxColumn.Width = 125;
            // 
            // adrDataGridViewTextBoxColumn
            // 
            this.adrDataGridViewTextBoxColumn.DataPropertyName = "adr";
            this.adrDataGridViewTextBoxColumn.HeaderText = "adr";
            this.adrDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adrDataGridViewTextBoxColumn.Name = "adrDataGridViewTextBoxColumn";
            this.adrDataGridViewTextBoxColumn.Width = 125;
            // 
            // kvmDataGridViewTextBoxColumn
            // 
            this.kvmDataGridViewTextBoxColumn.DataPropertyName = "kvm";
            this.kvmDataGridViewTextBoxColumn.HeaderText = "kvm";
            this.kvmDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kvmDataGridViewTextBoxColumn.Name = "kvmDataGridViewTextBoxColumn";
            this.kvmDataGridViewTextBoxColumn.Width = 125;
            // 
            // bTypeDataGridViewTextBoxColumn
            // 
            this.bTypeDataGridViewTextBoxColumn.DataPropertyName = "bType";
            this.bTypeDataGridViewTextBoxColumn.HeaderText = "bType";
            this.bTypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bTypeDataGridViewTextBoxColumn.Name = "bTypeDataGridViewTextBoxColumn";
            this.bTypeDataGridViewTextBoxColumn.Width = 125;
            // 
            // loebeNrDataGridViewTextBoxColumn
            // 
            this.loebeNrDataGridViewTextBoxColumn.DataPropertyName = "loebeNr";
            this.loebeNrDataGridViewTextBoxColumn.HeaderText = "loebeNr";
            this.loebeNrDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.loebeNrDataGridViewTextBoxColumn.Name = "loebeNrDataGridViewTextBoxColumn";
            this.loebeNrDataGridViewTextBoxColumn.Width = 125;
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 572);
            this.Controls.Add(this.backgroundForDGV);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Search";
            this.Text = "Search";
            this.Load += new System.EventHandler(this.Search_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.backgroundForDGV.ResumeLayout(false);
            this.prisDGV.ResumeLayout(false);
            this.kvmDGV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soenderbodbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boligBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.MaskedTextBox minPrisBox;
        private System.Windows.Forms.MaskedTextBox maxPrisBox;
        private System.Windows.Forms.Label Kvm;
        private System.Windows.Forms.Label minKvmLabel;
        private System.Windows.Forms.Label maxKvmLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox minKvmBox;
        private System.Windows.Forms.MaskedTextBox maxKvmBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel backgroundForDGV;
        private System.Windows.Forms.Panel prisDGV;
        private System.Windows.Forms.Panel kvmDGV;
        private System.Windows.Forms.DataGridView dataGridView1;
        private soenderbodbDataSet soenderbodbDataSet;
        private System.Windows.Forms.BindingSource boligBindingSource;
        private soenderbodbDataSetTableAdapters.BoligTableAdapter boligTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn bIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mndPrisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kvmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loebeNrDataGridViewTextBoxColumn;
    }
}