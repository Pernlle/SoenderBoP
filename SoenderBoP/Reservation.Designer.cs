namespace SoenderBoP
{
    partial class Reservation
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
            this.reserveBtn = new System.Windows.Forms.Button();
            this.loebeNrMTxt = new System.Windows.Forms.MaskedTextBox();
            this.rIdMTxt = new System.Windows.Forms.MaskedTextBox();
            this.datoSlutMTxt = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.datoStartMTxt = new System.Windows.Forms.MaskedTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // reserveBtn
            // 
            this.reserveBtn.Location = new System.Drawing.Point(95, 226);
            this.reserveBtn.Name = "reserveBtn";
            this.reserveBtn.Size = new System.Drawing.Size(219, 32);
            this.reserveBtn.TabIndex = 0;
            this.reserveBtn.Text = "Reserver";
            this.reserveBtn.UseVisualStyleBackColor = true;
            this.reserveBtn.Click += new System.EventHandler(this.reserveBtn_Click);
            // 
            // loebeNrMTxt
            // 
            this.loebeNrMTxt.Location = new System.Drawing.Point(213, 55);
            this.loebeNrMTxt.Name = "loebeNrMTxt";
            this.loebeNrMTxt.Size = new System.Drawing.Size(100, 26);
            this.loebeNrMTxt.TabIndex = 1;
            // 
            // rIdMTxt
            // 
            this.rIdMTxt.Location = new System.Drawing.Point(213, 94);
            this.rIdMTxt.Name = "rIdMTxt";
            this.rIdMTxt.Size = new System.Drawing.Size(100, 26);
            this.rIdMTxt.TabIndex = 2;
            // 
            // datoSlutMTxt
            // 
            this.datoSlutMTxt.Location = new System.Drawing.Point(213, 136);
            this.datoSlutMTxt.Name = "datoSlutMTxt";
            this.datoSlutMTxt.Size = new System.Drawing.Size(100, 26);
            this.datoSlutMTxt.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Løbe Nr.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ressource ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(91, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Dato start";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(91, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Dato slut";
            // 
            // datoStartMTxt
            // 
            this.datoStartMTxt.Location = new System.Drawing.Point(213, 176);
            this.datoStartMTxt.Name = "datoStartMTxt";
            this.datoStartMTxt.Size = new System.Drawing.Size(100, 26);
            this.datoStartMTxt.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(53, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(296, 262);
            this.panel1.TabIndex = 9;
            // 
            // Reservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 450);
            this.Controls.Add(this.datoStartMTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.datoSlutMTxt);
            this.Controls.Add(this.rIdMTxt);
            this.Controls.Add(this.loebeNrMTxt);
            this.Controls.Add(this.reserveBtn);
            this.Controls.Add(this.panel1);
            this.Name = "Reservation";
            this.Text = "Reservation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button reserveBtn;
        private System.Windows.Forms.MaskedTextBox loebeNrMTxt;
        private System.Windows.Forms.MaskedTextBox rIdMTxt;
        private System.Windows.Forms.MaskedTextBox datoSlutMTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox datoStartMTxt;
        private System.Windows.Forms.Panel panel1;
    }
}