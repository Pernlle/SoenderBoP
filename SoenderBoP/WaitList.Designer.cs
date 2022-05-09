namespace SoenderBoP
{
    partial class WaitList
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.lejlighed = new System.Windows.Forms.TabPage();
            this.ungdomsbolig = new System.Windows.Forms.TabPage();
            this.seniorbolig = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.waitListViews = new SoenderBoP.waitListViews();
            this.lejlighedBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lejlighedTableAdapter = new SoenderBoP.waitListViewsTableAdapters.LejlighedTableAdapter();
            this.panel4 = new System.Windows.Forms.Panel();
            this.NR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opskrevetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fNavnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eNavnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medlemIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ungdomsboligBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ungdomsboligTableAdapter = new SoenderBoP.waitListViewsTableAdapters.UngdomsboligTableAdapter();
            this.opskrevetDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fNavnDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eNavnDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medlemIdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seniorboligBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.seniorboligTableAdapter = new SoenderBoP.waitListViewsTableAdapters.SeniorboligTableAdapter();
            this.opskrevetDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fNavnDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eNavnDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medlemIdDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.lejlighed.SuspendLayout();
            this.ungdomsbolig.SuspendLayout();
            this.seniorbolig.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.waitListViews)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lejlighedBindingSource)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ungdomsboligBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seniorboligBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.lejlighed);
            this.tabControl1.Controls.Add(this.ungdomsbolig);
            this.tabControl1.Controls.Add(this.seniorbolig);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // lejlighed
            // 
            this.lejlighed.Controls.Add(this.panel4);
            this.lejlighed.Controls.Add(this.panel1);
            this.lejlighed.Location = new System.Drawing.Point(4, 29);
            this.lejlighed.Name = "lejlighed";
            this.lejlighed.Padding = new System.Windows.Forms.Padding(3);
            this.lejlighed.Size = new System.Drawing.Size(792, 417);
            this.lejlighed.TabIndex = 0;
            this.lejlighed.Text = "Lejlighed";
            this.lejlighed.UseVisualStyleBackColor = true;
            // 
            // ungdomsbolig
            // 
            this.ungdomsbolig.Controls.Add(this.dataGridView2);
            this.ungdomsbolig.Controls.Add(this.panel2);
            this.ungdomsbolig.Location = new System.Drawing.Point(4, 29);
            this.ungdomsbolig.Name = "ungdomsbolig";
            this.ungdomsbolig.Padding = new System.Windows.Forms.Padding(3);
            this.ungdomsbolig.Size = new System.Drawing.Size(792, 417);
            this.ungdomsbolig.TabIndex = 1;
            this.ungdomsbolig.Text = "Ungdomsbolig";
            this.ungdomsbolig.UseVisualStyleBackColor = true;
            // 
            // seniorbolig
            // 
            this.seniorbolig.Controls.Add(this.dataGridView3);
            this.seniorbolig.Controls.Add(this.panel3);
            this.seniorbolig.Location = new System.Drawing.Point(4, 29);
            this.seniorbolig.Name = "seniorbolig";
            this.seniorbolig.Padding = new System.Windows.Forms.Padding(3);
            this.seniorbolig.Size = new System.Drawing.Size(792, 417);
            this.seniorbolig.TabIndex = 2;
            this.seniorbolig.Text = "Seniorbolig";
            this.seniorbolig.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NR,
            this.opskrevetDataGridViewTextBoxColumn,
            this.fNavnDataGridViewTextBoxColumn,
            this.eNavnDataGridViewTextBoxColumn,
            this.medlemIdDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.lejlighedBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(586, 411);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(589, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 411);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tilføj til venteliste";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Medlem:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Dato:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(589, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 411);
            this.panel2.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.opskrevetDataGridViewTextBoxColumn1,
            this.fNavnDataGridViewTextBoxColumn1,
            this.eNavnDataGridViewTextBoxColumn1,
            this.medlemIdDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.ungdomsboligBindingSource;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(586, 411);
            this.dataGridView2.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Dato:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Medlem:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Tilføj til venteliste";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(589, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 411);
            this.panel3.TabIndex = 0;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.opskrevetDataGridViewTextBoxColumn2,
            this.fNavnDataGridViewTextBoxColumn2,
            this.eNavnDataGridViewTextBoxColumn2,
            this.medlemIdDataGridViewTextBoxColumn2});
            this.dataGridView3.DataSource = this.seniorboligBindingSource;
            this.dataGridView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView3.Location = new System.Drawing.Point(3, 3);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 62;
            this.dataGridView3.RowTemplate.Height = 28;
            this.dataGridView3.Size = new System.Drawing.Size(586, 411);
            this.dataGridView3.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 188);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "Dato:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 20);
            this.label8.TabIndex = 4;
            this.label8.Text = "Medlem:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(127, 20);
            this.label9.TabIndex = 3;
            this.label9.Text = "Tilføj til venteliste";
            // 
            // waitListViews
            // 
            this.waitListViews.DataSetName = "waitListViews";
            this.waitListViews.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lejlighedBindingSource
            // 
            this.lejlighedBindingSource.DataMember = "Lejlighed";
            this.lejlighedBindingSource.DataSource = this.waitListViews;
            // 
            // lejlighedTableAdapter
            // 
            this.lejlighedTableAdapter.ClearBeforeFill = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dataGridView1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(586, 411);
            this.panel4.TabIndex = 2;
            // 
            // NR
            // 
            this.NR.HeaderText = "Nr";
            this.NR.MinimumWidth = 8;
            this.NR.Name = "NR";
            this.NR.Width = 150;
            // 
            // opskrevetDataGridViewTextBoxColumn
            // 
            this.opskrevetDataGridViewTextBoxColumn.DataPropertyName = "opskrevet";
            this.opskrevetDataGridViewTextBoxColumn.HeaderText = "opskrevet";
            this.opskrevetDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.opskrevetDataGridViewTextBoxColumn.Name = "opskrevetDataGridViewTextBoxColumn";
            this.opskrevetDataGridViewTextBoxColumn.Width = 150;
            // 
            // fNavnDataGridViewTextBoxColumn
            // 
            this.fNavnDataGridViewTextBoxColumn.DataPropertyName = "fNavn";
            this.fNavnDataGridViewTextBoxColumn.HeaderText = "fNavn";
            this.fNavnDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.fNavnDataGridViewTextBoxColumn.Name = "fNavnDataGridViewTextBoxColumn";
            this.fNavnDataGridViewTextBoxColumn.Width = 150;
            // 
            // eNavnDataGridViewTextBoxColumn
            // 
            this.eNavnDataGridViewTextBoxColumn.DataPropertyName = "eNavn";
            this.eNavnDataGridViewTextBoxColumn.HeaderText = "eNavn";
            this.eNavnDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.eNavnDataGridViewTextBoxColumn.Name = "eNavnDataGridViewTextBoxColumn";
            this.eNavnDataGridViewTextBoxColumn.Width = 150;
            // 
            // medlemIdDataGridViewTextBoxColumn
            // 
            this.medlemIdDataGridViewTextBoxColumn.DataPropertyName = "medlemId";
            this.medlemIdDataGridViewTextBoxColumn.HeaderText = "medlemId";
            this.medlemIdDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.medlemIdDataGridViewTextBoxColumn.Name = "medlemIdDataGridViewTextBoxColumn";
            this.medlemIdDataGridViewTextBoxColumn.Width = 150;
            // 
            // ungdomsboligBindingSource
            // 
            this.ungdomsboligBindingSource.DataMember = "Ungdomsbolig";
            this.ungdomsboligBindingSource.DataSource = this.waitListViews;
            // 
            // ungdomsboligTableAdapter
            // 
            this.ungdomsboligTableAdapter.ClearBeforeFill = true;
            // 
            // opskrevetDataGridViewTextBoxColumn1
            // 
            this.opskrevetDataGridViewTextBoxColumn1.DataPropertyName = "opskrevet";
            this.opskrevetDataGridViewTextBoxColumn1.HeaderText = "opskrevet";
            this.opskrevetDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.opskrevetDataGridViewTextBoxColumn1.Name = "opskrevetDataGridViewTextBoxColumn1";
            this.opskrevetDataGridViewTextBoxColumn1.Width = 150;
            // 
            // fNavnDataGridViewTextBoxColumn1
            // 
            this.fNavnDataGridViewTextBoxColumn1.DataPropertyName = "fNavn";
            this.fNavnDataGridViewTextBoxColumn1.HeaderText = "fNavn";
            this.fNavnDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.fNavnDataGridViewTextBoxColumn1.Name = "fNavnDataGridViewTextBoxColumn1";
            this.fNavnDataGridViewTextBoxColumn1.Width = 150;
            // 
            // eNavnDataGridViewTextBoxColumn1
            // 
            this.eNavnDataGridViewTextBoxColumn1.DataPropertyName = "eNavn";
            this.eNavnDataGridViewTextBoxColumn1.HeaderText = "eNavn";
            this.eNavnDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.eNavnDataGridViewTextBoxColumn1.Name = "eNavnDataGridViewTextBoxColumn1";
            this.eNavnDataGridViewTextBoxColumn1.Width = 150;
            // 
            // medlemIdDataGridViewTextBoxColumn1
            // 
            this.medlemIdDataGridViewTextBoxColumn1.DataPropertyName = "medlemId";
            this.medlemIdDataGridViewTextBoxColumn1.HeaderText = "medlemId";
            this.medlemIdDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.medlemIdDataGridViewTextBoxColumn1.Name = "medlemIdDataGridViewTextBoxColumn1";
            this.medlemIdDataGridViewTextBoxColumn1.Width = 150;
            // 
            // seniorboligBindingSource
            // 
            this.seniorboligBindingSource.DataMember = "Seniorbolig";
            this.seniorboligBindingSource.DataSource = this.waitListViews;
            // 
            // seniorboligTableAdapter
            // 
            this.seniorboligTableAdapter.ClearBeforeFill = true;
            // 
            // opskrevetDataGridViewTextBoxColumn2
            // 
            this.opskrevetDataGridViewTextBoxColumn2.DataPropertyName = "opskrevet";
            this.opskrevetDataGridViewTextBoxColumn2.HeaderText = "opskrevet";
            this.opskrevetDataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.opskrevetDataGridViewTextBoxColumn2.Name = "opskrevetDataGridViewTextBoxColumn2";
            this.opskrevetDataGridViewTextBoxColumn2.Width = 150;
            // 
            // fNavnDataGridViewTextBoxColumn2
            // 
            this.fNavnDataGridViewTextBoxColumn2.DataPropertyName = "fNavn";
            this.fNavnDataGridViewTextBoxColumn2.HeaderText = "fNavn";
            this.fNavnDataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.fNavnDataGridViewTextBoxColumn2.Name = "fNavnDataGridViewTextBoxColumn2";
            this.fNavnDataGridViewTextBoxColumn2.Width = 150;
            // 
            // eNavnDataGridViewTextBoxColumn2
            // 
            this.eNavnDataGridViewTextBoxColumn2.DataPropertyName = "eNavn";
            this.eNavnDataGridViewTextBoxColumn2.HeaderText = "eNavn";
            this.eNavnDataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.eNavnDataGridViewTextBoxColumn2.Name = "eNavnDataGridViewTextBoxColumn2";
            this.eNavnDataGridViewTextBoxColumn2.Width = 150;
            // 
            // medlemIdDataGridViewTextBoxColumn2
            // 
            this.medlemIdDataGridViewTextBoxColumn2.DataPropertyName = "medlemId";
            this.medlemIdDataGridViewTextBoxColumn2.HeaderText = "medlemId";
            this.medlemIdDataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.medlemIdDataGridViewTextBoxColumn2.Name = "medlemIdDataGridViewTextBoxColumn2";
            this.medlemIdDataGridViewTextBoxColumn2.Width = 150;
            // 
            // WaitList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "WaitList";
            this.Text = "WaitList";
            this.Load += new System.EventHandler(this.WaitList_Load);
            this.tabControl1.ResumeLayout(false);
            this.lejlighed.ResumeLayout(false);
            this.ungdomsbolig.ResumeLayout(false);
            this.seniorbolig.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.waitListViews)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lejlighedBindingSource)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ungdomsboligBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seniorboligBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage lejlighed;
        private System.Windows.Forms.TabPage ungdomsbolig;
        private System.Windows.Forms.TabPage seniorbolig;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private waitListViews waitListViews;
        private System.Windows.Forms.BindingSource lejlighedBindingSource;
        private waitListViewsTableAdapters.LejlighedTableAdapter lejlighedTableAdapter;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridViewTextBoxColumn NR;
        private System.Windows.Forms.DataGridViewTextBoxColumn opskrevetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fNavnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eNavnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn medlemIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource ungdomsboligBindingSource;
        private waitListViewsTableAdapters.UngdomsboligTableAdapter ungdomsboligTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn opskrevetDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fNavnDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn eNavnDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn medlemIdDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource seniorboligBindingSource;
        private waitListViewsTableAdapters.SeniorboligTableAdapter seniorboligTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn opskrevetDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn fNavnDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn eNavnDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn medlemIdDataGridViewTextBoxColumn2;
    }
}