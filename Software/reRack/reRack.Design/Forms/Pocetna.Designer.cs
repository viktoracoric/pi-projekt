﻿
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
            this.uiActionDodajVlasnika = new System.Windows.Forms.Button();
            this.uiActionDodajTeretanu = new System.Windows.Forms.Button();
            this.uiActionUrediPodatkeTeretane = new System.Windows.Forms.Button();
            this.uiActionUrediPodatke = new System.Windows.Forms.Button();
            this.uiActionPrikazTeretana = new System.Windows.Forms.Button();
            this.uiActionMojeTeretane = new System.Windows.Forms.Button();
            this.uiDobrodosli = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pocetnaHelpProvider = new System.Windows.Forms.HelpProvider();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // uiActionDodajVlasnika
            // 
            this.uiActionDodajVlasnika.Location = new System.Drawing.Point(325, 361);
            this.uiActionDodajVlasnika.Name = "uiActionDodajVlasnika";
            this.uiActionDodajVlasnika.Size = new System.Drawing.Size(100, 51);
            this.uiActionDodajVlasnika.TabIndex = 13;
            this.uiActionDodajVlasnika.Text = "Pregled zahtjeva";
            this.uiActionDodajVlasnika.UseVisualStyleBackColor = true;
            this.uiActionDodajVlasnika.Click += new System.EventHandler(this.uiActionDodajVlasnika_Click);
            // 
            // uiActionDodajTeretanu
            // 
            this.uiActionDodajTeretanu.Location = new System.Drawing.Point(181, 361);
            this.uiActionDodajTeretanu.Name = "uiActionDodajTeretanu";
            this.uiActionDodajTeretanu.Size = new System.Drawing.Size(100, 51);
            this.uiActionDodajTeretanu.TabIndex = 12;
            this.uiActionDodajTeretanu.Text = "Dodaj teretanu";
            this.uiActionDodajTeretanu.UseVisualStyleBackColor = true;
            this.uiActionDodajTeretanu.Click += new System.EventHandler(this.uiActionDodajTeretanu_Click);
            // 
            // uiActionUrediPodatkeTeretane
            // 
            this.uiActionUrediPodatkeTeretane.Location = new System.Drawing.Point(45, 361);
            this.uiActionUrediPodatkeTeretane.Name = "uiActionUrediPodatkeTeretane";
            this.uiActionUrediPodatkeTeretane.Size = new System.Drawing.Size(100, 51);
            this.uiActionUrediPodatkeTeretane.TabIndex = 11;
            this.uiActionUrediPodatkeTeretane.Text = "Uredi podatke teretane";
            this.uiActionUrediPodatkeTeretane.UseVisualStyleBackColor = true;
            this.uiActionUrediPodatkeTeretane.Click += new System.EventHandler(this.uiActionUrediPodatkeTeretane_Click);
            // 
            // uiActionUrediPodatke
            // 
            this.uiActionUrediPodatke.Location = new System.Drawing.Point(325, 256);
            this.uiActionUrediPodatke.Name = "uiActionUrediPodatke";
            this.uiActionUrediPodatke.Size = new System.Drawing.Size(100, 51);
            this.uiActionUrediPodatke.TabIndex = 10;
            this.uiActionUrediPodatke.Text = "Profil";
            this.uiActionUrediPodatke.UseVisualStyleBackColor = true;
            this.uiActionUrediPodatke.Click += new System.EventHandler(this.uiActionUrediPodatke_Click);
            // 
            // uiActionPrikazTeretana
            // 
            this.uiActionPrikazTeretana.Location = new System.Drawing.Point(181, 256);
            this.uiActionPrikazTeretana.Name = "uiActionPrikazTeretana";
            this.uiActionPrikazTeretana.Size = new System.Drawing.Size(100, 51);
            this.uiActionPrikazTeretana.TabIndex = 9;
            this.uiActionPrikazTeretana.Text = "Prikaži sve teretane";
            this.uiActionPrikazTeretana.UseVisualStyleBackColor = true;
            this.uiActionPrikazTeretana.Click += new System.EventHandler(this.uiActionPrikazTeretana_Click);
            // 
            // uiActionMojeTeretane
            // 
            this.uiActionMojeTeretane.Location = new System.Drawing.Point(45, 256);
            this.uiActionMojeTeretane.Name = "uiActionMojeTeretane";
            this.uiActionMojeTeretane.Size = new System.Drawing.Size(100, 51);
            this.uiActionMojeTeretane.TabIndex = 8;
            this.uiActionMojeTeretane.Text = "Prikaži moje teretane";
            this.uiActionMojeTeretane.UseVisualStyleBackColor = true;
            this.uiActionMojeTeretane.Click += new System.EventHandler(this.uiActionMojeTeretane_Click);
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
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(31, 88);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(404, 113);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
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
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.uiActionDodajVlasnika);
            this.Controls.Add(this.uiActionDodajTeretanu);
            this.Controls.Add(this.uiActionUrediPodatkeTeretane);
            this.Controls.Add(this.uiActionUrediPodatke);
            this.Controls.Add(this.uiActionPrikazTeretana);
            this.Controls.Add(this.uiActionMojeTeretane);
            this.Controls.Add(this.uiDobrodosli);
            this.pocetnaHelpProvider.SetHelpKeyword(this, "pocetna.htm");
            this.pocetnaHelpProvider.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.Topic);
            this.pocetnaHelpProvider.SetHelpString(this, "pocetna.htm");
            this.Name = "Pocetna";
            this.pocetnaHelpProvider.SetShowHelp(this, true);
            this.Text = "Pocetna";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uiActionDodajVlasnika;
        private System.Windows.Forms.Button uiActionDodajTeretanu;
        private System.Windows.Forms.Button uiActionUrediPodatkeTeretane;
        private System.Windows.Forms.Button uiActionUrediPodatke;
        private System.Windows.Forms.Button uiActionPrikazTeretana;
        private System.Windows.Forms.Button uiActionMojeTeretane;
        private System.Windows.Forms.Label uiDobrodosli;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.HelpProvider pocetnaHelpProvider;
    }
}