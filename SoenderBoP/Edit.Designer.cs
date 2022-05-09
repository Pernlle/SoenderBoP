namespace SoenderBoP
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
            this.medlemDGV = new System.Windows.Forms.DataGridView();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.tlfMTxt = new System.Windows.Forms.MaskedTextBox();
            this.emailMTxt = new System.Windows.Forms.MaskedTextBox();
            this.navnTxt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.medlemDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // medlemDGV
            // 
            this.medlemDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.medlemDGV.Location = new System.Drawing.Point(11, 10);
            this.medlemDGV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.medlemDGV.Name = "medlemDGV";
            this.medlemDGV.RowHeadersWidth = 62;
            this.medlemDGV.Size = new System.Drawing.Size(436, 341);
            this.medlemDGV.TabIndex = 0;
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(474, 218);
            this.deleteBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(141, 35);
            this.deleteBtn.TabIndex = 1;
            this.deleteBtn.Text = "Slet";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(474, 278);
            this.updateBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(141, 34);
            this.updateBtn.TabIndex = 2;
            this.updateBtn.Text = "Opdater";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // tlfMTxt
            // 
            this.tlfMTxt.Location = new System.Drawing.Point(497, 102);
            this.tlfMTxt.Name = "tlfMTxt";
            this.tlfMTxt.Size = new System.Drawing.Size(100, 22);
            this.tlfMTxt.TabIndex = 3;
            // 
            // emailMTxt
            // 
            this.emailMTxt.Location = new System.Drawing.Point(497, 155);
            this.emailMTxt.Name = "emailMTxt";
            this.emailMTxt.Size = new System.Drawing.Size(100, 22);
            this.emailMTxt.TabIndex = 4;
            // 
            // navnTxt
            // 
            this.navnTxt.Location = new System.Drawing.Point(497, 50);
            this.navnTxt.Name = "navnTxt";
            this.navnTxt.ReadOnly = true;
            this.navnTxt.Size = new System.Drawing.Size(100, 22);
            this.navnTxt.TabIndex = 5;
            this.navnTxt.TabStop = false;
            // 
            // Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 360);
            this.Controls.Add(this.navnTxt);
            this.Controls.Add(this.emailMTxt);
            this.Controls.Add(this.tlfMTxt);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.medlemDGV);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Edit";
            this.Text = "Edit";
            ((System.ComponentModel.ISupportInitialize)(this.medlemDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView medlemDGV;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.MaskedTextBox tlfMTxt;
        private System.Windows.Forms.MaskedTextBox emailMTxt;
        private System.Windows.Forms.TextBox navnTxt;
    }
}