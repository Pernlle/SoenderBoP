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
            this.button1 = new System.Windows.Forms.Button();
            this.fNavnMTxt = new System.Windows.Forms.MaskedTextBox();
            this.eNavnMTxt = new System.Windows.Forms.MaskedTextBox();
            this.tlfMTxt = new System.Windows.Forms.MaskedTextBox();
            this.emailMTxt = new System.Windows.Forms.MaskedTextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.emailMTxt);
            this.panel1.Controls.Add(this.tlfMTxt);
            this.panel1.Controls.Add(this.eNavnMTxt);
            this.panel1.Controls.Add(this.fNavnMTxt);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(243, 301);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // fNavnMTxt
            // 
            this.fNavnMTxt.Location = new System.Drawing.Point(317, 98);
            this.fNavnMTxt.Name = "fNavnMTxt";
            this.fNavnMTxt.Size = new System.Drawing.Size(100, 22);
            this.fNavnMTxt.TabIndex = 1;
            // 
            // eNavnMTxt
            // 
            this.eNavnMTxt.Location = new System.Drawing.Point(317, 138);
            this.eNavnMTxt.Name = "eNavnMTxt";
            this.eNavnMTxt.Size = new System.Drawing.Size(100, 22);
            this.eNavnMTxt.TabIndex = 2;
            // 
            // tlfMTxt
            // 
            this.tlfMTxt.Location = new System.Drawing.Point(317, 180);
            this.tlfMTxt.Name = "tlfMTxt";
            this.tlfMTxt.Size = new System.Drawing.Size(100, 22);
            this.tlfMTxt.TabIndex = 3;
            // 
            // emailMTxt
            // 
            this.emailMTxt.Location = new System.Drawing.Point(317, 222);
            this.emailMTxt.Name = "emailMTxt";
            this.emailMTxt.Size = new System.Drawing.Size(100, 22);
            this.emailMTxt.TabIndex = 4;
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox emailMTxt;
        private System.Windows.Forms.MaskedTextBox tlfMTxt;
        private System.Windows.Forms.MaskedTextBox eNavnMTxt;
        private System.Windows.Forms.MaskedTextBox fNavnMTxt;
    }
}