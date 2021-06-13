
namespace reRack.Design.Forms
{
    partial class DodajTeretanu
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
            this.label1 = new System.Windows.Forms.Label();
            this.uiIme = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.uiAdresa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.uiGrad = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.uiCijena = new System.Windows.Forms.NumericUpDown();
            this.uiKvadratura = new System.Windows.Forms.NumericUpDown();
            this.uxActionPotvrdi = new System.Windows.Forms.Button();
            this.uxActionOdbij = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.uiKapacitet = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.uiKorisnik = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.uiCijena)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiKvadratura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiKapacitet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime teretane:";
            // 
            // uiIme
            // 
            this.uiIme.Location = new System.Drawing.Point(113, 14);
            this.uiIme.Name = "uiIme";
            this.uiIme.Size = new System.Drawing.Size(121, 20);
            this.uiIme.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Adresa:";
            // 
            // uiAdresa
            // 
            this.uiAdresa.Location = new System.Drawing.Point(113, 97);
            this.uiAdresa.Name = "uiAdresa";
            this.uiAdresa.Size = new System.Drawing.Size(121, 20);
            this.uiAdresa.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Grad:";
            // 
            // uiGrad
            // 
            this.uiGrad.FormattingEnabled = true;
            this.uiGrad.Location = new System.Drawing.Point(113, 69);
            this.uiGrad.Name = "uiGrad";
            this.uiGrad.Size = new System.Drawing.Size(121, 21);
            this.uiGrad.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Cijena:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Kvadratura:";
            // 
            // uiCijena
            // 
            this.uiCijena.Location = new System.Drawing.Point(113, 151);
            this.uiCijena.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.uiCijena.Name = "uiCijena";
            this.uiCijena.Size = new System.Drawing.Size(120, 20);
            this.uiCijena.TabIndex = 3;
            // 
            // uiKvadratura
            // 
            this.uiKvadratura.Location = new System.Drawing.Point(114, 178);
            this.uiKvadratura.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.uiKvadratura.Name = "uiKvadratura";
            this.uiKvadratura.Size = new System.Drawing.Size(120, 20);
            this.uiKvadratura.TabIndex = 3;
            // 
            // uxActionPotvrdi
            // 
            this.uxActionPotvrdi.Location = new System.Drawing.Point(166, 229);
            this.uxActionPotvrdi.Name = "uxActionPotvrdi";
            this.uxActionPotvrdi.Size = new System.Drawing.Size(91, 38);
            this.uxActionPotvrdi.TabIndex = 4;
            this.uxActionPotvrdi.Text = "Potvrdi zahtjev";
            this.uxActionPotvrdi.UseVisualStyleBackColor = true;
            this.uxActionPotvrdi.Click += new System.EventHandler(this.uxActionSpremi_Click);
            // 
            // uxActionOdbij
            // 
            this.uxActionOdbij.Location = new System.Drawing.Point(12, 229);
            this.uxActionOdbij.Name = "uxActionOdbij";
            this.uxActionOdbij.Size = new System.Drawing.Size(91, 38);
            this.uxActionOdbij.TabIndex = 4;
            this.uxActionOdbij.Text = "Odbij zahtjev";
            this.uxActionOdbij.UseVisualStyleBackColor = true;
            this.uxActionOdbij.Click += new System.EventHandler(this.uxActionOdustani_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Kapacitet:";
            // 
            // uiKapacitet
            // 
            this.uiKapacitet.Location = new System.Drawing.Point(113, 124);
            this.uiKapacitet.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.uiKapacitet.Name = "uiKapacitet";
            this.uiKapacitet.Size = new System.Drawing.Size(120, 20);
            this.uiKapacitet.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(40, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Korisnik:";
            // 
            // uiKorisnik
            // 
            this.uiKorisnik.FormattingEnabled = true;
            this.uiKorisnik.Location = new System.Drawing.Point(112, 41);
            this.uiKorisnik.Name = "uiKorisnik";
            this.uiKorisnik.Size = new System.Drawing.Size(121, 21);
            this.uiKorisnik.TabIndex = 2;
            // 
            // DodajTeretanu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 279);
            this.Controls.Add(this.uxActionOdbij);
            this.Controls.Add(this.uxActionPotvrdi);
            this.Controls.Add(this.uiKvadratura);
            this.Controls.Add(this.uiKapacitet);
            this.Controls.Add(this.uiCijena);
            this.Controls.Add(this.uiKorisnik);
            this.Controls.Add(this.uiGrad);
            this.Controls.Add(this.uiAdresa);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.uiIme);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "DodajTeretanu";
            this.Text = "DodajTeretanu";
            this.Load += new System.EventHandler(this.DodajTeretanu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uiCijena)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiKvadratura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiKapacitet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox uiIme;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox uiAdresa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox uiGrad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown uiCijena;
        private System.Windows.Forms.NumericUpDown uiKvadratura;
        private System.Windows.Forms.Button uxActionPotvrdi;
        private System.Windows.Forms.Button uxActionOdbij;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown uiKapacitet;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox uiKorisnik;
    }
}