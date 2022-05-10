﻿namespace SoenderBoP
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
            this.minKvmBox = new System.Windows.Forms.MaskedTextBox();
            this.maxKvmBox = new System.Windows.Forms.MaskedTextBox();
            this.Kvm = new System.Windows.Forms.Label();
            this.minKvmLabel = new System.Windows.Forms.Label();
            this.maxKvmLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.minPrisBox = new System.Windows.Forms.MaskedTextBox();
            this.maxPrisBox = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(373, 241);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(110, 54);
            this.searchBtn.TabIndex = 0;
            this.searchBtn.Text = "Søg";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // minKvmBox
            // 
            this.minKvmBox.Location = new System.Drawing.Point(170, 328);
            this.minKvmBox.Name = "minKvmBox";
            this.minKvmBox.Size = new System.Drawing.Size(100, 26);
            this.minKvmBox.TabIndex = 1;
            // 
            // maxKvmBox
            // 
            this.maxKvmBox.Location = new System.Drawing.Point(170, 384);
            this.maxKvmBox.Name = "maxKvmBox";
            this.maxKvmBox.Size = new System.Drawing.Size(100, 26);
            this.maxKvmBox.TabIndex = 2;
            // 
            // Kvm
            // 
            this.Kvm.AutoSize = true;
            this.Kvm.Location = new System.Drawing.Point(130, 275);
            this.Kvm.Name = "Kvm";
            this.Kvm.Size = new System.Drawing.Size(39, 20);
            this.Kvm.TabIndex = 3;
            this.Kvm.Text = "Kvm";
            // 
            // minKvmLabel
            // 
            this.minKvmLabel.AutoSize = true;
            this.minKvmLabel.Location = new System.Drawing.Point(130, 328);
            this.minKvmLabel.Name = "minKvmLabel";
            this.minKvmLabel.Size = new System.Drawing.Size(34, 20);
            this.minKvmLabel.TabIndex = 4;
            this.minKvmLabel.Text = "Min";
            // 
            // maxKvmLabel
            // 
            this.maxKvmLabel.AutoSize = true;
            this.maxKvmLabel.Location = new System.Drawing.Point(130, 390);
            this.maxKvmLabel.Name = "maxKvmLabel";
            this.maxKvmLabel.Size = new System.Drawing.Size(38, 20);
            this.maxKvmLabel.TabIndex = 5;
            this.maxKvmLabel.Text = "Max";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(131, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Max";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(131, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Min";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(130, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Måned Pris";
            // 
            // minPrisBox
            // 
            this.minPrisBox.Location = new System.Drawing.Point(170, 116);
            this.minPrisBox.Name = "minPrisBox";
            this.minPrisBox.Size = new System.Drawing.Size(100, 26);
            this.minPrisBox.TabIndex = 9;
            // 
            // maxPrisBox
            // 
            this.maxPrisBox.Location = new System.Drawing.Point(170, 185);
            this.maxPrisBox.Name = "maxPrisBox";
            this.maxPrisBox.Size = new System.Drawing.Size(100, 26);
            this.maxPrisBox.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(636, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "SØG BOLIG";
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.maxPrisBox);
            this.Controls.Add(this.minPrisBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.maxKvmLabel);
            this.Controls.Add(this.minKvmLabel);
            this.Controls.Add(this.Kvm);
            this.Controls.Add(this.maxKvmBox);
            this.Controls.Add(this.minKvmBox);
            this.Controls.Add(this.searchBtn);
            this.Name = "Search";
            this.Text = "Search";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.MaskedTextBox minKvmBox;
        private System.Windows.Forms.MaskedTextBox maxKvmBox;
        private System.Windows.Forms.Label Kvm;
        private System.Windows.Forms.Label minKvmLabel;
        private System.Windows.Forms.Label maxKvmLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox minPrisBox;
        private System.Windows.Forms.MaskedTextBox maxPrisBox;
        private System.Windows.Forms.Label label4;
    }
}