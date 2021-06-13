
namespace reRack.Design.Forms
{
    partial class UrediTeretanu
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
            this.uxActionOdustani = new System.Windows.Forms.Button();
            this.uxActionSpremi = new System.Windows.Forms.Button();
            this.uiKvadratura = new System.Windows.Forms.NumericUpDown();
            this.uiKapacitet = new System.Windows.Forms.NumericUpDown();
            this.uiCijena = new System.Windows.Forms.NumericUpDown();
            this.uiKorisnik = new System.Windows.Forms.ComboBox();
            this.uiGrad = new System.Windows.Forms.ComboBox();
            this.uiAdresa = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.uiOdaberiTeretanuLabel = new System.Windows.Forms.Label();
            this.uiIme = new System.Windows.Forms.ComboBox();
            this.uiObrisiTeretanu = new System.Windows.Forms.Button();
            this.urediTeretanuHelpProvider = new System.Windows.Forms.HelpProvider();
            ((System.ComponentModel.ISupportInitialize)(this.uiKvadratura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiKapacitet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiCijena)).BeginInit();
            this.SuspendLayout();
            // 
            // uxActionOdustani
            // 
            this.uxActionOdustani.Location = new System.Drawing.Point(12, 238);
            this.uxActionOdustani.Name = "uxActionOdustani";
            this.uxActionOdustani.Size = new System.Drawing.Size(91, 38);
            this.uxActionOdustani.TabIndex = 19;
            this.uxActionOdustani.Text = "Odustani";
            this.uxActionOdustani.UseVisualStyleBackColor = true;
            this.uxActionOdustani.Click += new System.EventHandler(this.uxActionOdustani_Click);
            // 
            // uxActionSpremi
            // 
            this.uxActionSpremi.Location = new System.Drawing.Point(147, 238);
            this.uxActionSpremi.Name = "uxActionSpremi";
            this.uxActionSpremi.Size = new System.Drawing.Size(91, 38);
            this.uxActionSpremi.TabIndex = 20;
            this.uxActionSpremi.Text = "Spremi";
            this.uxActionSpremi.UseVisualStyleBackColor = true;
            this.uxActionSpremi.Click += new System.EventHandler(this.uxActionSpremi_Click);
            // 
            // uiKvadratura
            // 
            this.uiKvadratura.Location = new System.Drawing.Point(117, 187);
            this.uiKvadratura.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.uiKvadratura.Name = "uiKvadratura";
            this.uiKvadratura.Size = new System.Drawing.Size(120, 20);
            this.uiKvadratura.TabIndex = 16;
            // 
            // uiKapacitet
            // 
            this.uiKapacitet.Location = new System.Drawing.Point(116, 133);
            this.uiKapacitet.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.uiKapacitet.Name = "uiKapacitet";
            this.uiKapacitet.Size = new System.Drawing.Size(120, 20);
            this.uiKapacitet.TabIndex = 17;
            // 
            // uiCijena
            // 
            this.uiCijena.Location = new System.Drawing.Point(116, 160);
            this.uiCijena.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.uiCijena.Name = "uiCijena";
            this.uiCijena.Size = new System.Drawing.Size(120, 20);
            this.uiCijena.TabIndex = 18;
            // 
            // uiKorisnik
            // 
            this.uiKorisnik.FormattingEnabled = true;
            this.uiKorisnik.Location = new System.Drawing.Point(115, 50);
            this.uiKorisnik.Name = "uiKorisnik";
            this.uiKorisnik.Size = new System.Drawing.Size(121, 21);
            this.uiKorisnik.TabIndex = 14;
            // 
            // uiGrad
            // 
            this.uiGrad.FormattingEnabled = true;
            this.uiGrad.Location = new System.Drawing.Point(116, 78);
            this.uiGrad.Name = "uiGrad";
            this.uiGrad.Size = new System.Drawing.Size(121, 21);
            this.uiGrad.TabIndex = 15;
            // 
            // uiAdresa
            // 
            this.uiAdresa.Location = new System.Drawing.Point(116, 106);
            this.uiAdresa.Name = "uiAdresa";
            this.uiAdresa.Size = new System.Drawing.Size(121, 20);
            this.uiAdresa.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Kvadratura:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Kapacitet:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Adresa:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Cijena:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Korisnik:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Grad:";
            // 
            // uiOdaberiTeretanuLabel
            // 
            this.uiOdaberiTeretanuLabel.AutoSize = true;
            this.uiOdaberiTeretanuLabel.Location = new System.Drawing.Point(22, 29);
            this.uiOdaberiTeretanuLabel.Name = "uiOdaberiTeretanuLabel";
            this.uiOdaberiTeretanuLabel.Size = new System.Drawing.Size(89, 13);
            this.uiOdaberiTeretanuLabel.TabIndex = 11;
            this.uiOdaberiTeretanuLabel.Text = "Odaberi teretanu:";
            // 
            // uiIme
            // 
            this.uiIme.FormattingEnabled = true;
            this.uiIme.Location = new System.Drawing.Point(116, 21);
            this.uiIme.Name = "uiIme";
            this.uiIme.Size = new System.Drawing.Size(121, 21);
            this.uiIme.TabIndex = 21;
            this.uiIme.SelectedValueChanged += new System.EventHandler(this.uiIme_SelectedValueChanged);
            // 
            // uiObrisiTeretanu
            // 
            this.uiObrisiTeretanu.Location = new System.Drawing.Point(71, 282);
            this.uiObrisiTeretanu.Name = "uiObrisiTeretanu";
            this.uiObrisiTeretanu.Size = new System.Drawing.Size(99, 38);
            this.uiObrisiTeretanu.TabIndex = 23;
            this.uiObrisiTeretanu.Text = "Obriši teretanu";
            this.uiObrisiTeretanu.UseVisualStyleBackColor = true;
            this.uiObrisiTeretanu.Click += new System.EventHandler(this.uiObrisiTeretanu_Click);
            // 
            // urediTeretanuHelpProvider
            // 
            this.urediTeretanuHelpProvider.HelpNamespace = "reRack.chm";
            // 
            // UrediTeretanu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 328);
            this.Controls.Add(this.uiObrisiTeretanu);
            this.Controls.Add(this.uiIme);
            this.Controls.Add(this.uxActionOdustani);
            this.Controls.Add(this.uxActionSpremi);
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
            this.Controls.Add(this.label3);
            this.Controls.Add(this.uiOdaberiTeretanuLabel);
            this.urediTeretanuHelpProvider.SetHelpKeyword(this, "urediTeretanu.htm");
            this.urediTeretanuHelpProvider.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.Topic);
            this.urediTeretanuHelpProvider.SetHelpString(this, "urediTeretanu.htm");
            this.Name = "UrediTeretanu";
            this.urediTeretanuHelpProvider.SetShowHelp(this, true);
            this.Text = "Uredi Teretanu";
            this.Load += new System.EventHandler(this.UrediTeretanu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uiKvadratura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiKapacitet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiCijena)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uxActionOdustani;
        private System.Windows.Forms.Button uxActionSpremi;
        private System.Windows.Forms.NumericUpDown uiKvadratura;
        private System.Windows.Forms.NumericUpDown uiKapacitet;
        private System.Windows.Forms.NumericUpDown uiCijena;
        private System.Windows.Forms.ComboBox uiKorisnik;
        private System.Windows.Forms.ComboBox uiGrad;
        private System.Windows.Forms.TextBox uiAdresa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label uiOdaberiTeretanuLabel;
        private System.Windows.Forms.ComboBox uiIme;
        private System.Windows.Forms.Button uiObrisiTeretanu;
        private System.Windows.Forms.HelpProvider urediTeretanuHelpProvider;
    }
}