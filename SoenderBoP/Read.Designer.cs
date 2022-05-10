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
            this.soenderbodbDataSet = new SoenderBoP.soenderbodbDataSet();
            this.medlemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fNavnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eNavnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tlfDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loebeNrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.readMedlemDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soenderbodbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medlemBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
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
            this.readMedlemDGV.DataSource = this.medlemBindingSource;
            this.readMedlemDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.readMedlemDGV.Location = new System.Drawing.Point(0, 0);
            this.readMedlemDGV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.readMedlemDGV.Name = "readMedlemDGV";
            this.readMedlemDGV.RowHeadersWidth = 62;
            this.readMedlemDGV.RowTemplate.Height = 28;
            this.readMedlemDGV.Size = new System.Drawing.Size(711, 360);
            this.readMedlemDGV.TabIndex = 0;
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
            // panel1
            // 
            this.panel1.Controls.Add(this.readMedlemDGV);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(711, 360);
            this.panel1.TabIndex = 1;
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
            ((System.ComponentModel.ISupportInitialize)(this.readMedlemDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soenderbodbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medlemBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
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
    }
}