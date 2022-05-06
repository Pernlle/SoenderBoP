namespace SoenderBoP
{
    partial class Menu
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
            this.loginBtn = new System.Windows.Forms.Button();
            this.reserveBtn = new System.Windows.Forms.Button();
            this.readBtn = new System.Windows.Forms.Button();
            this.createBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.loginBtn);
            this.panel1.Controls.Add(this.reserveBtn);
            this.panel1.Controls.Add(this.readBtn);
            this.panel1.Controls.Add(this.createBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 562);
            this.panel1.TabIndex = 0;
            // 
            // loginBtn
            // 
            this.loginBtn.Location = new System.Drawing.Point(44, 456);
            this.loginBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(98, 40);
            this.loginBtn.TabIndex = 3;
            this.loginBtn.Text = "Log ind";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // reserveBtn
            // 
            this.reserveBtn.Location = new System.Drawing.Point(44, 144);
            this.reserveBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.reserveBtn.Name = "reserveBtn";
            this.reserveBtn.Size = new System.Drawing.Size(164, 45);
            this.reserveBtn.TabIndex = 2;
            this.reserveBtn.Text = "Reservere ressourcer";
            this.reserveBtn.UseVisualStyleBackColor = true;
            // 
            // readBtn
            // 
            this.readBtn.Location = new System.Drawing.Point(44, 91);
            this.readBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.readBtn.Name = "readBtn";
            this.readBtn.Size = new System.Drawing.Size(164, 45);
            this.readBtn.TabIndex = 1;
            this.readBtn.Text = "Se medlem";
            this.readBtn.UseVisualStyleBackColor = true;
            // 
            // createBtn
            // 
            this.createBtn.Location = new System.Drawing.Point(44, 39);
            this.createBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(164, 45);
            this.createBtn.TabIndex = 0;
            this.createBtn.Text = "Opret medlem";
            this.createBtn.UseVisualStyleBackColor = true;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Menu";
            this.Text = "Menu";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Button reserveBtn;
        private System.Windows.Forms.Button readBtn;
        private System.Windows.Forms.Button createBtn;
    }
}