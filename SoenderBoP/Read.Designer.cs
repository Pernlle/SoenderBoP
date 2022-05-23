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
            this.medlemBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.soenderbodbDataSet = new SoenderBoP.soenderbodbDataSet();
            this.medlemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.readBoligDGV = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.readReserveDGV = new System.Windows.Forms.DataGridView();
            this.boligBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reserveretBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.soenderbodbDataSet1 = new SoenderBoP.soenderbodbDataSet1();
            this.boligTableAdapter = new SoenderBoP.soenderbodbDataSetTableAdapters.BoligTableAdapter();
            this.medlemTableAdapter = new SoenderBoP.soenderbodbDataSetTableAdapters.MedlemTableAdapter();
            this.reserveretTableAdapter = new SoenderBoP.soenderbodbDataSet1TableAdapters.ReserveretTableAdapter();
            this.reserveretBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.reserveretTableAdapter1 = new SoenderBoP.soenderbodbDataSetTableAdapters.ReserveretTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.readMedlemDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medlemBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soenderbodbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medlemBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.readBoligDGV)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.readReserveDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boligBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reserveretBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soenderbodbDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reserveretBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // readMedlemDGV
            // 
            this.readMedlemDGV.BackgroundColor = System.Drawing.Color.Linen;
            this.readMedlemDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.readMedlemDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.readMedlemDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.readMedlemDGV.Location = new System.Drawing.Point(3, 4);
            this.readMedlemDGV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.readMedlemDGV.Name = "readMedlemDGV";
            this.readMedlemDGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.readMedlemDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.readMedlemDGV.RowTemplate.Height = 28;
            this.readMedlemDGV.Size = new System.Drawing.Size(786, 401);
            this.readMedlemDGV.TabIndex = 0;
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.readMedlemDGV);
            this.tabPage1.Location = new System.Drawing.Point(4, 37);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Size = new System.Drawing.Size(792, 409);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Medlem";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.readBoligDGV);
            this.tabPage2.Location = new System.Drawing.Point(4, 37);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Size = new System.Drawing.Size(792, 409);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Bolig";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // readBoligDGV
            // 
            this.readBoligDGV.BackgroundColor = System.Drawing.Color.Linen;
            this.readBoligDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.readBoligDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.readBoligDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.readBoligDGV.Location = new System.Drawing.Point(3, 4);
            this.readBoligDGV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.readBoligDGV.Name = "readBoligDGV";
            this.readBoligDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.readBoligDGV.RowTemplate.Height = 24;
            this.readBoligDGV.Size = new System.Drawing.Size(786, 401);
            this.readBoligDGV.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.readReserveDGV);
            this.tabPage3.Location = new System.Drawing.Point(4, 37);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage3.Size = new System.Drawing.Size(792, 409);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Reservationer";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // readReserveDGV
            // 
            this.readReserveDGV.BackgroundColor = System.Drawing.Color.Linen;
            this.readReserveDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.readReserveDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.readReserveDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.readReserveDGV.Location = new System.Drawing.Point(3, 4);
            this.readReserveDGV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.readReserveDGV.Name = "readReserveDGV";
            this.readReserveDGV.RowHeadersWidth = 51;
            this.readReserveDGV.RowTemplate.Height = 24;
            this.readReserveDGV.Size = new System.Drawing.Size(786, 401);
            this.readReserveDGV.TabIndex = 0;
            // 
            // boligBindingSource
            // 
            this.boligBindingSource.DataMember = "Bolig";
            this.boligBindingSource.DataSource = this.soenderbodbDataSet;
            // 
            // reserveretBindingSource
            // 
            this.reserveretBindingSource.DataMember = "Reserveret";
            this.reserveretBindingSource.DataSource = this.soenderbodbDataSet1;
            // 
            // soenderbodbDataSet1
            // 
            this.soenderbodbDataSet1.DataSetName = "soenderbodbDataSet1";
            this.soenderbodbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // boligTableAdapter
            // 
            this.boligTableAdapter.ClearBeforeFill = true;
            // 
            // medlemTableAdapter
            // 
            this.medlemTableAdapter.ClearBeforeFill = true;
            // 
            // reserveretTableAdapter
            // 
            this.reserveretTableAdapter.ClearBeforeFill = true;
            // 
            // reserveretBindingSource1
            // 
            this.reserveretBindingSource1.DataMember = "Reserveret";
            this.reserveretBindingSource1.DataSource = this.soenderbodbDataSet;
            // 
            // reserveretTableAdapter1
            // 
            this.reserveretTableAdapter1.ClearBeforeFill = true;
            // 
            // Read
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Read";
            this.Text = "Read";
            this.Load += new System.EventHandler(this.Read_Load);
            ((System.ComponentModel.ISupportInitialize)(this.readMedlemDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medlemBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soenderbodbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medlemBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.readBoligDGV)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.readReserveDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boligBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reserveretBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soenderbodbDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reserveretBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView readMedlemDGV;
        private System.Windows.Forms.BindingSource medlemBindingSource;
        private soenderbodbDataSet soenderbodbDataSet;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView readBoligDGV;
        private System.Windows.Forms.BindingSource boligBindingSource;
        private soenderbodbDataSetTableAdapters.BoligTableAdapter boligTableAdapter;
        private System.Windows.Forms.BindingSource medlemBindingSource1;
        private soenderbodbDataSetTableAdapters.MedlemTableAdapter medlemTableAdapter;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView readReserveDGV;
        private soenderbodbDataSet1 soenderbodbDataSet1;
        private System.Windows.Forms.BindingSource reserveretBindingSource;
        private soenderbodbDataSet1TableAdapters.ReserveretTableAdapter reserveretTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn rIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loebeNrDataGridViewTextBoxColumn2;
        private System.Windows.Forms.BindingSource reserveretBindingSource1;
        private soenderbodbDataSetTableAdapters.ReserveretTableAdapter reserveretTableAdapter1;
    }
}