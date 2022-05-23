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
            this.passLabel = new System.Windows.Forms.Label();
            this.loginBox = new System.Windows.Forms.GroupBox();
            this.idLabel = new System.Windows.Forms.Label();
            this.passBox = new System.Windows.Forms.MaskedTextBox();
            this.loginBtn = new System.Windows.Forms.Button();
            this.idBox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Linen;
            this.panel1.Controls.Add(this.passLabel);
            this.panel1.Controls.Add(this.loginBox);
            this.panel1.Controls.Add(this.idLabel);
            this.panel1.Controls.Add(this.passBox);
            this.panel1.Controls.Add(this.loginBtn);
            this.panel1.Controls.Add(this.idBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(362, 338);
            this.panel1.TabIndex = 0;
            // 
            // passLabel
            // 
            this.passLabel.AutoSize = true;
            this.passLabel.Location = new System.Drawing.Point(32, 141);
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(78, 20);
            this.passLabel.TabIndex = 4;
            this.passLabel.Text = "Password";
            // 
            // loginBox
            // 
            this.loginBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.loginBox.Location = new System.Drawing.Point(769, 413);
            this.loginBox.Name = "loginBox";
            this.loginBox.Size = new System.Drawing.Size(10, 10);
            this.loginBox.TabIndex = 0;
            this.loginBox.TabStop = false;
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(32, 71);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(26, 20);
            this.idLabel.TabIndex = 3;
            this.idLabel.Text = "ID";
            // 
            // passBox
            // 
            this.passBox.Location = new System.Drawing.Point(125, 138);
            this.passBox.Name = "passBox";
            this.passBox.Size = new System.Drawing.Size(149, 26);
            this.passBox.TabIndex = 2;
            // 
            // loginBtn
            // 
            this.loginBtn.Location = new System.Drawing.Point(125, 216);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(149, 42);
            this.loginBtn.TabIndex = 0;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // idBox
            // 
            this.idBox.Location = new System.Drawing.Point(125, 65);
            this.idBox.Name = "idBox";
            this.idBox.Size = new System.Drawing.Size(149, 26);
            this.idBox.TabIndex = 1;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 338);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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