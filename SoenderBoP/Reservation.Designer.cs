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
            this.loebeNr = new System.Windows.Forms.MaskedTextBox();
            this.rId = new System.Windows.Forms.MaskedTextBox();
            this.dStartDag = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dSlutDag = new System.Windows.Forms.MaskedTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dStartMaaned = new System.Windows.Forms.MaskedTextBox();
            this.dStartAar = new System.Windows.Forms.MaskedTextBox();
            this.dStartTime = new System.Windows.Forms.MaskedTextBox();
            this.dSlutAar = new System.Windows.Forms.MaskedTextBox();
            this.dStartMinut = new System.Windows.Forms.MaskedTextBox();
            this.kl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dSlutMaaned = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dSlutMinut = new System.Windows.Forms.MaskedTextBox();
            this.dSlutTime = new System.Windows.Forms.MaskedTextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // reserveBtn
            // 
            this.reserveBtn.Location = new System.Drawing.Point(42, 199);
            this.reserveBtn.Name = "reserveBtn";
            this.reserveBtn.Size = new System.Drawing.Size(439, 32);
            this.reserveBtn.TabIndex = 13;
            this.reserveBtn.Text = "Reserver";
            this.reserveBtn.UseVisualStyleBackColor = true;
            this.reserveBtn.Click += new System.EventHandler(this.reserveBtn_Click);
            // 
            // loebeNr
            // 
            this.loebeNr.Location = new System.Drawing.Point(161, 25);
            this.loebeNr.Name = "loebeNr";
            this.loebeNr.Size = new System.Drawing.Size(84, 26);
            this.loebeNr.TabIndex = 1;
            // 
            // rId
            // 
            this.rId.Location = new System.Drawing.Point(161, 67);
            this.rId.Name = "rId";
            this.rId.Size = new System.Drawing.Size(84, 26);
            this.rId.TabIndex = 2;
            // 
            // dStartDag
            // 
            this.dStartDag.Location = new System.Drawing.Point(160, 109);
            this.dStartDag.Name = "dStartDag";
            this.dStartDag.Size = new System.Drawing.Size(40, 26);
            this.dStartDag.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Løbe Nr.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ressource ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Dato start";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Dato slut";
            // 
            // dSlutDag
            // 
            this.dSlutDag.Location = new System.Drawing.Point(160, 146);
            this.dSlutDag.Name = "dSlutDag";
            this.dSlutDag.Size = new System.Drawing.Size(40, 26);
            this.dSlutDag.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.dSlutDag);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.dSlutMinut);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.loebeNr);
            this.panel1.Controls.Add(this.dSlutTime);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.rId);
            this.panel1.Controls.Add(this.dSlutMaaned);
            this.panel1.Controls.Add(this.kl);
            this.panel1.Controls.Add(this.reserveBtn);
            this.panel1.Controls.Add(this.dStartMinut);
            this.panel1.Controls.Add(this.dSlutAar);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dStartTime);
            this.panel1.Controls.Add(this.dStartAar);
            this.panel1.Controls.Add(this.dStartDag);
            this.panel1.Controls.Add(this.dStartMaaned);
            this.panel1.Location = new System.Drawing.Point(36, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(510, 262);
            this.panel1.TabIndex = 9;
            // 
            // dStartMaaned
            // 
            this.dStartMaaned.Location = new System.Drawing.Point(206, 109);
            this.dStartMaaned.Name = "dStartMaaned";
            this.dStartMaaned.Size = new System.Drawing.Size(39, 26);
            this.dStartMaaned.TabIndex = 4;
            // 
            // dStartAar
            // 
            this.dStartAar.Location = new System.Drawing.Point(251, 109);
            this.dStartAar.Name = "dStartAar";
            this.dStartAar.Size = new System.Drawing.Size(100, 26);
            this.dStartAar.TabIndex = 5;
            // 
            // dStartTime
            // 
            this.dStartTime.Location = new System.Drawing.Point(389, 109);
            this.dStartTime.Name = "dStartTime";
            this.dStartTime.Size = new System.Drawing.Size(34, 26);
            this.dStartTime.TabIndex = 6;
            this.dStartTime.Text = "00";
            // 
            // dSlutAar
            // 
            this.dSlutAar.Location = new System.Drawing.Point(251, 146);
            this.dSlutAar.Name = "dSlutAar";
            this.dSlutAar.Size = new System.Drawing.Size(100, 26);
            this.dSlutAar.TabIndex = 10;
            // 
            // dStartMinut
            // 
            this.dStartMinut.Location = new System.Drawing.Point(448, 109);
            this.dStartMinut.Name = "dStartMinut";
            this.dStartMinut.Size = new System.Drawing.Size(33, 26);
            this.dStartMinut.TabIndex = 7;
            this.dStartMinut.Text = "00";
            // 
            // kl
            // 
            this.kl.AutoSize = true;
            this.kl.Location = new System.Drawing.Point(357, 112);
            this.kl.Name = "kl";
            this.kl.Size = new System.Drawing.Size(26, 20);
            this.kl.TabIndex = 5;
            this.kl.Text = "Kl.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(339, 335);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 20);
            this.label5.TabIndex = 6;
            // 
            // dSlutMaaned
            // 
            this.dSlutMaaned.Location = new System.Drawing.Point(206, 146);
            this.dSlutMaaned.Name = "dSlutMaaned";
            this.dSlutMaaned.Size = new System.Drawing.Size(39, 26);
            this.dSlutMaaned.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(429, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = ":";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(429, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = ":";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(357, 149);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 20);
            this.label8.TabIndex = 11;
            this.label8.Text = "Kl.";
            // 
            // dSlutMinut
            // 
            this.dSlutMinut.Location = new System.Drawing.Point(448, 146);
            this.dSlutMinut.Name = "dSlutMinut";
            this.dSlutMinut.Size = new System.Drawing.Size(33, 26);
            this.dSlutMinut.TabIndex = 12;
            this.dSlutMinut.Text = "00";
            // 
            // dSlutTime
            // 
            this.dSlutTime.Location = new System.Drawing.Point(389, 146);
            this.dSlutTime.Name = "dSlutTime";
            this.dSlutTime.Size = new System.Drawing.Size(34, 26);
            this.dSlutTime.TabIndex = 11;
            this.dSlutTime.Text = "00";
            // 
            // Reservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Name = "Reservation";
            this.Text = "Reservation";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button reserveBtn;
        private System.Windows.Forms.MaskedTextBox loebeNr;
        private System.Windows.Forms.MaskedTextBox rId;
        private System.Windows.Forms.MaskedTextBox dStartDag;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox dSlutDag;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MaskedTextBox dSlutAar;
        private System.Windows.Forms.MaskedTextBox dStartTime;
        private System.Windows.Forms.MaskedTextBox dStartAar;
        private System.Windows.Forms.MaskedTextBox dStartMaaned;
        private System.Windows.Forms.Label kl;
        private System.Windows.Forms.MaskedTextBox dStartMinut;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox dSlutMaaned;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox dSlutMinut;
        private System.Windows.Forms.MaskedTextBox dSlutTime;
        private System.Windows.Forms.Label label6;
    }
}