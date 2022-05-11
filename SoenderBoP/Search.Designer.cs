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
            this.searchPanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(267, 210);
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
            this.minPrisBox.Location = new System.Drawing.Point(89, 107);
            this.minPrisBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.minPrisBox.Name = "minPrisBox";
            this.minPrisBox.Size = new System.Drawing.Size(89, 22);
            this.minPrisBox.TabIndex = 1;
            // 
            // maxPrisBox
            // 
            this.maxPrisBox.Location = new System.Drawing.Point(89, 160);
            this.maxPrisBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.maxPrisBox.Name = "maxPrisBox";
            this.maxPrisBox.Size = new System.Drawing.Size(89, 22);
            this.maxPrisBox.TabIndex = 2;
            // 
            // Kvm
            // 
            this.Kvm.AutoSize = true;
            this.Kvm.Location = new System.Drawing.Point(51, 237);
            this.Kvm.Name = "Kvm";
            this.Kvm.Size = new System.Drawing.Size(33, 16);
            this.Kvm.TabIndex = 3;
            this.Kvm.Text = "Kvm";
            // 
            // minKvmLabel
            // 
            this.minKvmLabel.AutoSize = true;
            this.minKvmLabel.Location = new System.Drawing.Point(51, 275);
            this.minKvmLabel.Name = "minKvmLabel";
            this.minKvmLabel.Size = new System.Drawing.Size(28, 16);
            this.minKvmLabel.TabIndex = 4;
            this.minKvmLabel.Text = "Min";
            // 
            // maxKvmLabel
            // 
            this.maxKvmLabel.AutoSize = true;
            this.maxKvmLabel.Location = new System.Drawing.Point(51, 324);
            this.maxKvmLabel.Name = "maxKvmLabel";
            this.maxKvmLabel.Size = new System.Drawing.Size(32, 16);
            this.maxKvmLabel.TabIndex = 5;
            this.maxKvmLabel.Text = "Max";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Max";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Min";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Måned Pris";
            // 
            // minKvmBox
            // 
            this.minKvmBox.Location = new System.Drawing.Point(89, 272);
            this.minKvmBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.minKvmBox.Name = "minKvmBox";
            this.minKvmBox.Size = new System.Drawing.Size(89, 22);
            this.minKvmBox.TabIndex = 9;
            // 
            // maxKvmBox
            // 
            this.maxKvmBox.Location = new System.Drawing.Point(89, 321);
            this.maxKvmBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.maxKvmBox.Name = "maxKvmBox";
            this.maxKvmBox.Size = new System.Drawing.Size(89, 22);
            this.maxKvmBox.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(610, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "SØG BOLIG";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1188, 67);
            this.panel1.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.minPrisBox);
            this.panel2.Controls.Add(this.searchBtn);
            this.panel2.Controls.Add(this.maxKvmBox);
            this.panel2.Controls.Add(this.maxPrisBox);
            this.panel2.Controls.Add(this.minKvmBox);
            this.panel2.Controls.Add(this.Kvm);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.minKvmLabel);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.maxKvmLabel);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(780, 67);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(408, 483);
            this.panel2.TabIndex = 15;
            // 
            // searchPanel
            // 
            this.searchPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchPanel.Location = new System.Drawing.Point(0, 67);
            this.searchPanel.Name = "searchPanel";
            this.searchPanel.Size = new System.Drawing.Size(780, 483);
            this.searchPanel.TabIndex = 16;
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1188, 550);
            this.Controls.Add(this.searchPanel);
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
        private System.Windows.Forms.Panel searchPanel;
    }
}