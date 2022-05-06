namespace SoenderBoP
{
    partial class Create
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.fNavnMTxt = new System.Windows.Forms.MaskedTextBox();
            this.eNavnMTxt = new System.Windows.Forms.MaskedTextBox();
            this.tlfMTxt = new System.Windows.Forms.MaskedTextBox();
            this.emailMTxt = new System.Windows.Forms.MaskedTextBox();
            this.createBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.createBtn);
            this.panel1.Controls.Add(this.emailMTxt);
            this.panel1.Controls.Add(this.tlfMTxt);
            this.panel1.Controls.Add(this.eNavnMTxt);
            this.panel1.Controls.Add(this.fNavnMTxt);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 0;
            // 
            // fNavnMTxt
            // 
            this.fNavnMTxt.Location = new System.Drawing.Point(376, 132);
            this.fNavnMTxt.Name = "fNavnMTxt";
            this.fNavnMTxt.Size = new System.Drawing.Size(100, 22);
            this.fNavnMTxt.TabIndex = 0;
            // 
            // eNavnMTxt
            // 
            this.eNavnMTxt.Location = new System.Drawing.Point(376, 180);
            this.eNavnMTxt.Name = "eNavnMTxt";
            this.eNavnMTxt.Size = new System.Drawing.Size(100, 22);
            this.eNavnMTxt.TabIndex = 1;
            // 
            // tlfMTxt
            // 
            this.tlfMTxt.Location = new System.Drawing.Point(376, 227);
            this.tlfMTxt.Name = "tlfMTxt";
            this.tlfMTxt.Size = new System.Drawing.Size(100, 22);
            this.tlfMTxt.TabIndex = 2;
            // 
            // emailMTxt
            // 
            this.emailMTxt.Location = new System.Drawing.Point(376, 275);
            this.emailMTxt.Name = "emailMTxt";
            this.emailMTxt.Size = new System.Drawing.Size(100, 22);
            this.emailMTxt.TabIndex = 3;
            // 
            // createBtn
            // 
            this.createBtn.Location = new System.Drawing.Point(322, 321);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(75, 23);
            this.createBtn.TabIndex = 4;
            this.createBtn.Text = "Opret";
            this.createBtn.UseVisualStyleBackColor = true;
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
            // 
            // Create
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Create";
            this.Text = "Create";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button createBtn;
        private System.Windows.Forms.MaskedTextBox emailMTxt;
        private System.Windows.Forms.MaskedTextBox tlfMTxt;
        private System.Windows.Forms.MaskedTextBox eNavnMTxt;
        private System.Windows.Forms.MaskedTextBox fNavnMTxt;
    }
}