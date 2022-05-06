namespace SoenderBoP
{
    partial class Login
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
            this.loginBox = new System.Windows.Forms.GroupBox();
            this.passLabel = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.passBox = new System.Windows.Forms.MaskedTextBox();
            this.idBox = new System.Windows.Forms.TextBox();
            this.loginBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.loginBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.loginBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 0;
            // 
            // loginBox
            // 
            this.loginBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.loginBox.Controls.Add(this.passLabel);
            this.loginBox.Controls.Add(this.idLabel);
            this.loginBox.Controls.Add(this.passBox);
            this.loginBox.Controls.Add(this.idBox);
            this.loginBox.Controls.Add(this.loginBtn);
            this.loginBox.Location = new System.Drawing.Point(199, 69);
            this.loginBox.Name = "loginBox";
            this.loginBox.Size = new System.Drawing.Size(330, 262);
            this.loginBox.TabIndex = 0;
            this.loginBox.TabStop = false;
            // 
            // passLabel
            // 
            this.passLabel.AutoSize = true;
            this.passLabel.Location = new System.Drawing.Point(39, 132);
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(78, 20);
            this.passLabel.TabIndex = 4;
            this.passLabel.Text = "Password";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(35, 62);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(26, 20);
            this.idLabel.TabIndex = 3;
            this.idLabel.Text = "ID";
            // 
            // passBox
            // 
            this.passBox.Location = new System.Drawing.Point(132, 129);
            this.passBox.Name = "passBox";
            this.passBox.Size = new System.Drawing.Size(139, 26);
            this.passBox.TabIndex = 2;
            // 
            // idBox
            // 
            this.idBox.Location = new System.Drawing.Point(132, 56);
            this.idBox.Name = "idBox";
            this.idBox.Size = new System.Drawing.Size(139, 26);
            this.idBox.TabIndex = 1;
            // 
            // loginBtn
            // 
            this.loginBtn.Location = new System.Drawing.Point(132, 208);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(75, 30);
            this.loginBtn.TabIndex = 0;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Login";
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            this.loginBox.ResumeLayout(false);
            this.loginBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox loginBox;
        private System.Windows.Forms.Label passLabel;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.MaskedTextBox passBox;
        private System.Windows.Forms.TextBox idBox;
        private System.Windows.Forms.Button loginBtn;
        public System.Windows.Forms.Panel panel1;
    }
}