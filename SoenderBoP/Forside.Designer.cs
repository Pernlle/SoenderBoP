namespace SoenderBoP
{
    partial class Forside
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
            this.manuPanel = new System.Windows.Forms.Panel();
            this.BackgroundPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.sloganPanel = new System.Windows.Forms.Panel();
            this.BackgroundPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // manuPanel
            // 
            this.manuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.manuPanel.Location = new System.Drawing.Point(0, 0);
            this.manuPanel.Name = "manuPanel";
            this.manuPanel.Size = new System.Drawing.Size(200, 450);
            this.manuPanel.TabIndex = 0;
            // 
            // BackgroundPanel
            // 
            this.BackgroundPanel.Controls.Add(this.panel1);
            this.BackgroundPanel.Controls.Add(this.sloganPanel);
            this.BackgroundPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BackgroundPanel.Location = new System.Drawing.Point(200, 0);
            this.BackgroundPanel.Name = "BackgroundPanel";
            this.BackgroundPanel.Size = new System.Drawing.Size(600, 450);
            this.BackgroundPanel.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 350);
            this.panel1.TabIndex = 1;
            // 
            // sloganPanel
            // 
            this.sloganPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.sloganPanel.Location = new System.Drawing.Point(0, 350);
            this.sloganPanel.Name = "sloganPanel";
            this.sloganPanel.Size = new System.Drawing.Size(600, 100);
            this.sloganPanel.TabIndex = 0;
            // 
            // Forside
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BackgroundPanel);
            this.Controls.Add(this.manuPanel);
            this.Name = "Forside";
            this.Text = "Forside";
            this.Load += new System.EventHandler(this.Forside_Load);
            this.BackgroundPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel BackgroundPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel sloganPanel;
        public System.Windows.Forms.Panel manuPanel;
    }
}

