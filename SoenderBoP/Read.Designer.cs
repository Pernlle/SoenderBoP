namespace SoenderBoP
{
    partial class Read
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
            this.readMedlemDGV = new System.Windows.Forms.DataGridView();
            this.mIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fNavnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eNavnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tlfDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loebeNrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medlemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.soenderbodbDataSet = new SoenderBoP.soenderbodbDataSet();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mndPrisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kvmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loebeNrDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.boligBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.boligTableAdapter = new SoenderBoP.soenderbodbDataSetTableAdapters.BoligTableAdapter();
            this.medlemBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.medlemTableAdapter = new SoenderBoP.soenderbodbDataSetTableAdapters.MedlemTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.readMedlemDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medlemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soenderbodbDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boligBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medlemBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // readMedlemDGV
            // 
            this.readMedlemDGV.AutoGenerateColumns = false;
            this.readMedlemDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.readMedlemDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mIdDataGridViewTextBoxColumn,
            this.fNavnDataGridViewTextBoxColumn,
            this.eNavnDataGridViewTextBoxColumn,
            this.tlfDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.loebeNrDataGridViewTextBoxColumn});
            this.readMedlemDGV.DataSource = this.medlemBindingSource1;
            this.readMedlemDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.readMedlemDGV.Location = new System.Drawing.Point(3, 3);
            this.readMedlemDGV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.readMedlemDGV.Name = "readMedlemDGV";
            this.readMedlemDGV.RowHeadersWidth = 62;
            this.readMedlemDGV.RowTemplate.Height = 28;
            this.readMedlemDGV.Size = new System.Drawing.Size(697, 325);
            this.readMedlemDGV.TabIndex = 0;
            // 
            // mIdDataGridViewTextBoxColumn
            // 
            this.mIdDataGridViewTextBoxColumn.DataPropertyName = "mId";
            this.mIdDataGridViewTextBoxColumn.HeaderText = "mId";
            this.mIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mIdDataGridViewTextBoxColumn.Name = "mIdDataGridViewTextBoxColumn";
            this.mIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.mIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // fNavnDataGridViewTextBoxColumn
            // 
            this.fNavnDataGridViewTextBoxColumn.DataPropertyName = "fNavn";
            this.fNavnDataGridViewTextBoxColumn.HeaderText = "fNavn";
            this.fNavnDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fNavnDataGridViewTextBoxColumn.Name = "fNavnDataGridViewTextBoxColumn";
            this.fNavnDataGridViewTextBoxColumn.Width = 125;
            // 
            // eNavnDataGridViewTextBoxColumn
            // 
            this.eNavnDataGridViewTextBoxColumn.DataPropertyName = "eNavn";
            this.eNavnDataGridViewTextBoxColumn.HeaderText = "eNavn";
            this.eNavnDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.eNavnDataGridViewTextBoxColumn.Name = "eNavnDataGridViewTextBoxColumn";
            this.eNavnDataGridViewTextBoxColumn.Width = 125;
            // 
            // tlfDataGridViewTextBoxColumn
            // 
            this.tlfDataGridViewTextBoxColumn.DataPropertyName = "tlf";
            this.tlfDataGridViewTextBoxColumn.HeaderText = "tlf";
            this.tlfDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tlfDataGridViewTextBoxColumn.Name = "tlfDataGridViewTextBoxColumn";
            this.tlfDataGridViewTextBoxColumn.Width = 125;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Width = 125;
            // 
            // loebeNrDataGridViewTextBoxColumn
            // 
            this.loebeNrDataGridViewTextBoxColumn.DataPropertyName = "loebeNr";
            this.loebeNrDataGridViewTextBoxColumn.HeaderText = "loebeNr";
            this.loebeNrDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.loebeNrDataGridViewTextBoxColumn.Name = "loebeNrDataGridViewTextBoxColumn";
            this.loebeNrDataGridViewTextBoxColumn.Width = 125;
            // 
            // medlemBindingSource
            // 
            this.medlemBindingSource.DataMember = "Medlem";
            this.medlemBindingSource.DataSource = this.soenderbodbDataSet;
            // 
            // soenderbodbDataSet
            // 
            this.soenderbodbDataSet.DataSetName = "soenderbodbDataSet";
            this.soenderbodbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(711, 360);
            this.panel1.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(711, 360);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.readMedlemDGV);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(703, 331);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Medlem";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(703, 331);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Bolig";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bIdDataGridViewTextBoxColumn,
            this.mndPrisDataGridViewTextBoxColumn,
            this.adrDataGridViewTextBoxColumn,
            this.kvmDataGridViewTextBoxColumn,
            this.bTypeDataGridViewTextBoxColumn,
            this.loebeNrDataGridViewTextBoxColumn1});
            this.dataGridView1.DataSource = this.boligBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(697, 325);
            this.dataGridView1.TabIndex = 0;
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
            // loebeNrDataGridViewTextBoxColumn1
            // 
            this.loebeNrDataGridViewTextBoxColumn1.DataPropertyName = "loebeNr";
            this.loebeNrDataGridViewTextBoxColumn1.HeaderText = "loebeNr";
            this.loebeNrDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.loebeNrDataGridViewTextBoxColumn1.Name = "loebeNrDataGridViewTextBoxColumn1";
            this.loebeNrDataGridViewTextBoxColumn1.Width = 125;
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
            // medlemBindingSource1
            // 
            this.medlemBindingSource1.DataMember = "Medlem";
            this.medlemBindingSource1.DataSource = this.soenderbodbDataSet;
            // 
            // medlemTableAdapter
            // 
            this.medlemTableAdapter.ClearBeforeFill = true;
            // 
            // Read
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 360);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Read";
            this.Text = "Read";
            this.Load += new System.EventHandler(this.Read_Load);
            ((System.ComponentModel.ISupportInitialize)(this.readMedlemDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medlemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soenderbodbDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boligBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medlemBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView readMedlemDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn mIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fNavnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eNavnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tlfDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loebeNrDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource medlemBindingSource;
        private soenderbodbDataSet soenderbodbDataSet;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource boligBindingSource;
        private soenderbodbDataSetTableAdapters.BoligTableAdapter boligTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn bIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mndPrisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kvmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loebeNrDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource medlemBindingSource1;
        private soenderbodbDataSetTableAdapters.MedlemTableAdapter medlemTableAdapter;
    }
}