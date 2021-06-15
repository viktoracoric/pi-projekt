
namespace reRack.Design.Forms
{
    partial class Pocetna
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pocetna));
            this.uxActionPregledZahtjeva = new System.Windows.Forms.Button();
            this.uxActionDodajTeretanu = new System.Windows.Forms.Button();
            this.uxActionUrediPodatkeTeretane = new System.Windows.Forms.Button();
            this.uxActionProfil = new System.Windows.Forms.Button();
            this.uxActionPrikazTeretana = new System.Windows.Forms.Button();
            this.uxActionMojeTeretane = new System.Windows.Forms.Button();
            this.uiDobrodosli = new System.Windows.Forms.Label();
            this.uiSlika = new System.Windows.Forms.PictureBox();
            this.pocetnaHelpProvider = new System.Windows.Forms.HelpProvider();
            ((System.ComponentModel.ISupportInitialize)(this.uiSlika)).BeginInit();
            this.SuspendLayout();
            // 
            // uxActionPregledZahtjeva
            // 
            this.uxActionPregledZahtjeva.Location = new System.Drawing.Point(325, 361);
            this.uxActionPregledZahtjeva.Name = "uxActionPregledZahtjeva";
            this.uxActionPregledZahtjeva.Size = new System.Drawing.Size(100, 51);
            this.uxActionPregledZahtjeva.TabIndex = 13;
            this.uxActionPregledZahtjeva.Text = "Pregled zahtjeva";
            this.uxActionPregledZahtjeva.UseVisualStyleBackColor = true;
            this.uxActionPregledZahtjeva.Click += new System.EventHandler(this.uiActionDodajVlasnika_Click);
            // 
            // uxActionDodajTeretanu
            // 
            this.uxActionDodajTeretanu.Location = new System.Drawing.Point(181, 361);
            this.uxActionDodajTeretanu.Name = "uxActionDodajTeretanu";
            this.uxActionDodajTeretanu.Size = new System.Drawing.Size(100, 51);
            this.uxActionDodajTeretanu.TabIndex = 12;
            this.uxActionDodajTeretanu.Text = "Dodaj teretanu";
            this.uxActionDodajTeretanu.UseVisualStyleBackColor = true;
            this.uxActionDodajTeretanu.Click += new System.EventHandler(this.uiActionDodajTeretanu_Click);
            // 
            // uxActionUrediPodatkeTeretane
            // 
            this.uxActionUrediPodatkeTeretane.Location = new System.Drawing.Point(45, 361);
            this.uxActionUrediPodatkeTeretane.Name = "uxActionUrediPodatkeTeretane";
            this.uxActionUrediPodatkeTeretane.Size = new System.Drawing.Size(100, 51);
            this.uxActionUrediPodatkeTeretane.TabIndex = 11;
            this.uxActionUrediPodatkeTeretane.Text = "Uredi podatke teretane";
            this.uxActionUrediPodatkeTeretane.UseVisualStyleBackColor = true;
            this.uxActionUrediPodatkeTeretane.Click += new System.EventHandler(this.uiActionUrediPodatkeTeretane_Click);
            // 
            // uxActionProfil
            // 
            this.uxActionProfil.Location = new System.Drawing.Point(325, 256);
            this.uxActionProfil.Name = "uxActionProfil";
            this.uxActionProfil.Size = new System.Drawing.Size(100, 51);
            this.uxActionProfil.TabIndex = 10;
            this.uxActionProfil.Text = "Profil";
            this.uxActionProfil.UseVisualStyleBackColor = true;
            this.uxActionProfil.Click += new System.EventHandler(this.uiActionUrediPodatke_Click);
            // 
            // uxActionPrikazTeretana
            // 
            this.uxActionPrikazTeretana.Location = new System.Drawing.Point(181, 256);
            this.uxActionPrikazTeretana.Name = "uxActionPrikazTeretana";
            this.uxActionPrikazTeretana.Size = new System.Drawing.Size(100, 51);
            this.uxActionPrikazTeretana.TabIndex = 9;
            this.uxActionPrikazTeretana.Text = "Prikaži sve teretane";
            this.uxActionPrikazTeretana.UseVisualStyleBackColor = true;
            this.uxActionPrikazTeretana.Click += new System.EventHandler(this.uiActionPrikazTeretana_Click);
            // 
            // uxActionMojeTeretane
            // 
            this.uxActionMojeTeretane.Location = new System.Drawing.Point(45, 256);
            this.uxActionMojeTeretane.Name = "uxActionMojeTeretane";
            this.uxActionMojeTeretane.Size = new System.Drawing.Size(100, 51);
            this.uxActionMojeTeretane.TabIndex = 8;
            this.uxActionMojeTeretane.Text = "Prikaži moje teretane";
            this.uxActionMojeTeretane.UseVisualStyleBackColor = true;
            this.uxActionMojeTeretane.Click += new System.EventHandler(this.uiActionMojeTeretane_Click);
            // 
            // uiDobrodosli
            // 
            this.uiDobrodosli.AutoSize = true;
            this.uiDobrodosli.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.25F);
            this.uiDobrodosli.Location = new System.Drawing.Point(147, 29);
            this.uiDobrodosli.Name = "uiDobrodosli";
            this.uiDobrodosli.Size = new System.Drawing.Size(168, 36);
            this.uiDobrodosli.TabIndex = 7;
            this.uiDobrodosli.Text = "Dobrodošli!";
            // 
            // uiSlika
            // 
            this.uiSlika.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.uiSlika.Image = ((System.Drawing.Image)(resources.GetObject("uiSlika.Image")));
            this.uiSlika.Location = new System.Drawing.Point(31, 88);
            this.uiSlika.Name = "uiSlika";
            this.uiSlika.Size = new System.Drawing.Size(404, 113);
            this.uiSlika.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.uiSlika.TabIndex = 16;
            this.uiSlika.TabStop = false;
            // 
            // pocetnaHelpProvider
            // 
            this.pocetnaHelpProvider.HelpNamespace = "reRack.chm";
            // 
            // Pocetna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 450);
            this.Controls.Add(this.uiSlika);
            this.Controls.Add(this.uxActionPregledZahtjeva);
            this.Controls.Add(this.uxActionDodajTeretanu);
            this.Controls.Add(this.uxActionUrediPodatkeTeretane);
            this.Controls.Add(this.uxActionProfil);
            this.Controls.Add(this.uxActionPrikazTeretana);
            this.Controls.Add(this.uxActionMojeTeretane);
            this.Controls.Add(this.uiDobrodosli);
            this.pocetnaHelpProvider.SetHelpKeyword(this, "pocetna.htm");
            this.pocetnaHelpProvider.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.Topic);
            this.pocetnaHelpProvider.SetHelpString(this, "pocetna.htm");
            this.Name = "Pocetna";
            this.pocetnaHelpProvider.SetShowHelp(this, true);
            this.Text = "Pocetna";
            ((System.ComponentModel.ISupportInitialize)(this.uiSlika)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uxActionPregledZahtjeva;
        private System.Windows.Forms.Button uxActionDodajTeretanu;
        private System.Windows.Forms.Button uxActionUrediPodatkeTeretane;
        private System.Windows.Forms.Button uxActionProfil;
        private System.Windows.Forms.Button uxActionPrikazTeretana;
        private System.Windows.Forms.Button uxActionMojeTeretane;
        private System.Windows.Forms.Label uiDobrodosli;
        private System.Windows.Forms.PictureBox uiSlika;
        private System.Windows.Forms.HelpProvider pocetnaHelpProvider;
    }
}