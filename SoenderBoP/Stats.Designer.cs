namespace SoenderBoP
{
    partial class Stats
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.Parkering1 = new System.Windows.Forms.Label();
            this.Parkering2 = new System.Windows.Forms.Label();
            this.Festsal1 = new System.Windows.Forms.Label();
            this.Festsal2 = new System.Windows.Forms.Label();
            this.Vaskemaskine1 = new System.Windows.Forms.Label();
            this.Vaskemaskine2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.showStatsDGV = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.printStatsBTN = new System.Windows.Forms.Button();
            this.statsCBX = new System.Windows.Forms.ComboBox();
            this.medlemBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.soenderbodbDataSet1 = new SoenderBoP.soenderbodbDataSet1();
            this.statsRichTextBox = new System.Windows.Forms.RichTextBox();
            this.medlemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.soenderbodbDataSet = new SoenderBoP.soenderbodbDataSet();
            this.reserveretBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reserveretTableAdapter = new SoenderBoP.soenderbodbDataSetTableAdapters.ReserveretTableAdapter();
            this.ressourceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ressourceTableAdapter = new SoenderBoP.soenderbodbDataSetTableAdapters.RessourceTableAdapter();
            this.medlemTableAdapter = new SoenderBoP.soenderbodbDataSetTableAdapters.MedlemTableAdapter();
            this.medlemTableAdapter1 = new SoenderBoP.soenderbodbDataSet1TableAdapters.MedlemTableAdapter();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.showStatsDGV)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.medlemBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soenderbodbDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medlemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soenderbodbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reserveretBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ressourceBindingSource)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "Statistik";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 1;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 20);
            this.label3.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.IndianRed;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(25, 314);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(328, 48);
            this.button1.TabIndex = 3;
            this.button1.Text = "OPRET STATISTIK";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Alle ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(306, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Parkering";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(598, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Festsal";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(857, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Vaskemaskine";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(309, 244);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 29);
            this.button2.TabIndex = 8;
            this.button2.Text = "Create Statistic";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(602, 244);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(129, 29);
            this.button3.TabIndex = 9;
            this.button3.Text = "Create Statistic";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(861, 244);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(129, 29);
            this.button4.TabIndex = 10;
            this.button4.Text = "Create Statistic";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // Parkering1
            // 
            this.Parkering1.AutoSize = true;
            this.Parkering1.Location = new System.Drawing.Point(309, 129);
            this.Parkering1.Name = "Parkering1";
            this.Parkering1.Size = new System.Drawing.Size(51, 20);
            this.Parkering1.TabIndex = 11;
            this.Parkering1.Text = "label8";
            // 
            // Parkering2
            // 
            this.Parkering2.AutoSize = true;
            this.Parkering2.Location = new System.Drawing.Point(309, 182);
            this.Parkering2.Name = "Parkering2";
            this.Parkering2.Size = new System.Drawing.Size(51, 20);
            this.Parkering2.TabIndex = 12;
            this.Parkering2.Text = "label9";
            // 
            // Festsal1
            // 
            this.Festsal1.AutoSize = true;
            this.Festsal1.Location = new System.Drawing.Point(598, 129);
            this.Festsal1.Name = "Festsal1";
            this.Festsal1.Size = new System.Drawing.Size(60, 20);
            this.Festsal1.TabIndex = 13;
            this.Festsal1.Text = "label10";
            // 
            // Festsal2
            // 
            this.Festsal2.AutoSize = true;
            this.Festsal2.Location = new System.Drawing.Point(598, 182);
            this.Festsal2.Name = "Festsal2";
            this.Festsal2.Size = new System.Drawing.Size(60, 20);
            this.Festsal2.TabIndex = 14;
            this.Festsal2.Text = "label11";
            // 
            // Vaskemaskine1
            // 
            this.Vaskemaskine1.AutoSize = true;
            this.Vaskemaskine1.Location = new System.Drawing.Point(857, 129);
            this.Vaskemaskine1.Name = "Vaskemaskine1";
            this.Vaskemaskine1.Size = new System.Drawing.Size(60, 20);
            this.Vaskemaskine1.TabIndex = 15;
            this.Vaskemaskine1.Text = "label12";
            // 
            // Vaskemaskine2
            // 
            this.Vaskemaskine2.AutoSize = true;
            this.Vaskemaskine2.Location = new System.Drawing.Point(857, 182);
            this.Vaskemaskine2.Name = "Vaskemaskine2";
            this.Vaskemaskine2.Size = new System.Drawing.Size(60, 20);
            this.Vaskemaskine2.TabIndex = 16;
            this.Vaskemaskine2.Text = "label13";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(28, 206);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1118, 765);
            this.panel1.TabIndex = 17;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(0, 620);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(775, 145);
            this.panel3.TabIndex = 6;
            // 
            // showStatsDGV
            // 
            this.showStatsDGV.BackgroundColor = System.Drawing.Color.Linen;
            this.showStatsDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.showStatsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.showStatsDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.showStatsDGV.Location = new System.Drawing.Point(3, 2);
            this.showStatsDGV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.showStatsDGV.Name = "showStatsDGV";
            this.showStatsDGV.RowHeadersVisible = false;
            this.showStatsDGV.RowHeadersWidth = 51;
            this.showStatsDGV.RowTemplate.Height = 24;
            this.showStatsDGV.Size = new System.Drawing.Size(730, 720);
            this.showStatsDGV.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.printStatsBTN);
            this.panel2.Controls.Add(this.statsCBX);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(733, 2);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(374, 720);
            this.panel2.TabIndex = 5;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.IndianRed;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(25, 505);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(328, 48);
            this.button5.TabIndex = 7;
            this.button5.Text = "VIS ALLE";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(19, 184);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(206, 32);
            this.label8.TabIndex = 6;
            this.label8.Text = "Sorter på medlem";
            // 
            // printStatsBTN
            // 
            this.printStatsBTN.BackColor = System.Drawing.Color.IndianRed;
            this.printStatsBTN.FlatAppearance.BorderSize = 0;
            this.printStatsBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.printStatsBTN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printStatsBTN.ForeColor = System.Drawing.Color.White;
            this.printStatsBTN.Location = new System.Drawing.Point(25, 412);
            this.printStatsBTN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.printStatsBTN.Name = "printStatsBTN";
            this.printStatsBTN.Size = new System.Drawing.Size(328, 48);
            this.printStatsBTN.TabIndex = 5;
            this.printStatsBTN.Text = "PRINT";
            this.printStatsBTN.UseVisualStyleBackColor = false;
            this.printStatsBTN.Click += new System.EventHandler(this.printStatsBTN_Click);
            // 
            // statsCBX
            // 
            this.statsCBX.BackColor = System.Drawing.Color.IndianRed;
            this.statsCBX.Cursor = System.Windows.Forms.Cursors.Hand;
            this.statsCBX.DataSource = this.medlemBindingSource1;
            this.statsCBX.DisplayMember = "email";
            this.statsCBX.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statsCBX.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statsCBX.ForeColor = System.Drawing.Color.White;
            this.statsCBX.FormattingEnabled = true;
            this.statsCBX.Location = new System.Drawing.Point(25, 229);
            this.statsCBX.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.statsCBX.Name = "statsCBX";
            this.statsCBX.Size = new System.Drawing.Size(328, 40);
            this.statsCBX.TabIndex = 4;
            this.statsCBX.ValueMember = "email";
            this.statsCBX.Click += new System.EventHandler(this.statsCBX_Click);
            // 
            // medlemBindingSource1
            // 
            this.medlemBindingSource1.DataMember = "Medlem";
            this.medlemBindingSource1.DataSource = this.soenderbodbDataSet1;
            // 
            // soenderbodbDataSet1
            // 
            this.soenderbodbDataSet1.DataSetName = "soenderbodbDataSet1";
            this.soenderbodbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // statsRichTextBox
            // 
            this.statsRichTextBox.Location = new System.Drawing.Point(997, 244);
            this.statsRichTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.statsRichTextBox.Name = "statsRichTextBox";
            this.statsRichTextBox.Size = new System.Drawing.Size(120, 53);
            this.statsRichTextBox.TabIndex = 5;
            this.statsRichTextBox.Text = "";
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
            // reserveretBindingSource
            // 
            this.reserveretBindingSource.DataMember = "Reserveret";
            this.reserveretBindingSource.DataSource = this.soenderbodbDataSet;
            // 
            // reserveretTableAdapter
            // 
            this.reserveretTableAdapter.ClearBeforeFill = true;
            // 
            // ressourceBindingSource
            // 
            this.ressourceBindingSource.DataMember = "Ressource";
            this.ressourceBindingSource.DataSource = this.soenderbodbDataSet;
            // 
            // ressourceTableAdapter
            // 
            this.ressourceTableAdapter.ClearBeforeFill = true;
            // 
            // medlemTableAdapter
            // 
            this.medlemTableAdapter.ClearBeforeFill = true;
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
            this.tabControl1.Size = new System.Drawing.Size(1118, 765);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.showStatsDGV);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Location = new System.Drawing.Point(4, 37);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(1110, 724);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Statistik";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Stats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1118, 765);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Vaskemaskine2);
            this.Controls.Add(this.Vaskemaskine1);
            this.Controls.Add(this.statsRichTextBox);
            this.Controls.Add(this.Festsal2);
            this.Controls.Add(this.Festsal1);
            this.Controls.Add(this.Parkering2);
            this.Controls.Add(this.Parkering1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Stats";
            this.Text = "Stats";
            this.Load += new System.EventHandler(this.Stats_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.showStatsDGV)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.medlemBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soenderbodbDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medlemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soenderbodbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reserveretBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ressourceBindingSource)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label Parkering1;
        private System.Windows.Forms.Label Parkering2;
        private System.Windows.Forms.Label Festsal1;
        private System.Windows.Forms.Label Festsal2;
        private System.Windows.Forms.Label Vaskemaskine1;
        private System.Windows.Forms.Label Vaskemaskine2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox statsCBX;
        private soenderbodbDataSet soenderbodbDataSet;
        private System.Windows.Forms.BindingSource reserveretBindingSource;
        private soenderbodbDataSetTableAdapters.ReserveretTableAdapter reserveretTableAdapter;
        private System.Windows.Forms.BindingSource ressourceBindingSource;
        private soenderbodbDataSetTableAdapters.RessourceTableAdapter ressourceTableAdapter;
        private System.Windows.Forms.BindingSource medlemBindingSource;
        private soenderbodbDataSetTableAdapters.MedlemTableAdapter medlemTableAdapter;
        private System.Windows.Forms.RichTextBox statsRichTextBox;
        private soenderbodbDataSet1 soenderbodbDataSet1;
        private System.Windows.Forms.BindingSource medlemBindingSource1;
        private soenderbodbDataSet1TableAdapters.MedlemTableAdapter medlemTableAdapter1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView showStatsDGV;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button printStatsBTN;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button5;
    }
}