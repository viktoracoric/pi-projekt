
namespace reRack.Design
{
    partial class Prijava
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Prijava));
            this.uxPrijavaLabel = new System.Windows.Forms.Label();
            this.uxActionRegistracija = new System.Windows.Forms.Button();
            this.uxActionPrijava = new System.Windows.Forms.Button();
            this.uiLozinka = new System.Windows.Forms.TextBox();
            this.uxLozinkaLabel = new System.Windows.Forms.Label();
            this.uiKorIme = new System.Windows.Forms.TextBox();
            this.uxKorImeLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.prijavaHelpProvider = new System.Windows.Forms.HelpProvider();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // uxPrijavaLabel
            // 
            this.uxPrijavaLabel.AutoSize = true;
            this.uxPrijavaLabel.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxPrijavaLabel.Location = new System.Drawing.Point(154, 19);
            this.uxPrijavaLabel.Name = "uxPrijavaLabel";
            this.uxPrijavaLabel.Size = new System.Drawing.Size(151, 42);
            this.uxPrijavaLabel.TabIndex = 1;
            this.uxPrijavaLabel.Text = "Prijavite se";
            // 
            // uxActionRegistracija
            // 
            this.uxActionRegistracija.Location = new System.Drawing.Point(161, 429);
            this.uxActionRegistracija.Name = "uxActionRegistracija";
            this.uxActionRegistracija.Size = new System.Drawing.Size(133, 23);
            this.uxActionRegistracija.TabIndex = 14;
            this.uxActionRegistracija.Text = "Registriraj se";
            this.uxActionRegistracija.UseVisualStyleBackColor = true;
            this.uxActionRegistracija.Click += new System.EventHandler(this.uxRegistracijaButton_Click);
            // 
            // uxActionPrijava
            // 
            this.uxActionPrijava.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uxActionPrijava.ForeColor = System.Drawing.SystemColors.InfoText;
            this.uxActionPrijava.Location = new System.Drawing.Point(146, 328);
            this.uxActionPrijava.Name = "uxActionPrijava";
            this.uxActionPrijava.Size = new System.Drawing.Size(161, 41);
            this.uxActionPrijava.TabIndex = 12;
            this.uxActionPrijava.Text = "Prijavi se";
            this.uxActionPrijava.UseVisualStyleBackColor = true;
            this.uxActionPrijava.Click += new System.EventHandler(this.uxPrijavaButton_Click);
            // 
            // uiLozinka
            // 
            this.uiLozinka.Location = new System.Drawing.Point(161, 289);
            this.uiLozinka.Name = "uiLozinka";
            this.uiLozinka.PasswordChar = '*';
            this.uiLozinka.Size = new System.Drawing.Size(133, 22);
            this.uiLozinka.TabIndex = 11;
            // 
            // uxLozinkaLabel
            // 
            this.uxLozinkaLabel.AutoSize = true;
            this.uxLozinkaLabel.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uxLozinkaLabel.ForeColor = System.Drawing.SystemColors.WindowText;
            this.uxLozinkaLabel.Location = new System.Drawing.Point(211, 273);
            this.uxLozinkaLabel.Name = "uxLozinkaLabel";
            this.uxLozinkaLabel.Size = new System.Drawing.Size(43, 13);
            this.uxLozinkaLabel.TabIndex = 10;
            this.uxLozinkaLabel.Text = "Lozinka";
            // 
            // uiKorIme
            // 
            this.uiKorIme.Location = new System.Drawing.Point(161, 226);
            this.uiKorIme.Name = "uiKorIme";
            this.prijavaHelpProvider.SetShowHelp(this.uiKorIme, false);
            this.uiKorIme.Size = new System.Drawing.Size(133, 22);
            this.uiKorIme.TabIndex = 9;
            // 
            // uxKorImeLabel
            // 
            this.uxKorImeLabel.AutoSize = true;
            this.uxKorImeLabel.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uxKorImeLabel.ForeColor = System.Drawing.SystemColors.WindowText;
            this.uxKorImeLabel.Location = new System.Drawing.Point(193, 210);
            this.uxKorImeLabel.Name = "uxKorImeLabel";
            this.uxKorImeLabel.Size = new System.Drawing.Size(78, 13);
            this.uxKorImeLabel.TabIndex = 8;
            this.uxKorImeLabel.Text = "Korisničko ime";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(34, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.prijavaHelpProvider.SetShowHelp(this.pictureBox1, false);
            this.pictureBox1.Size = new System.Drawing.Size(404, 113);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // prijavaHelpProvider
            // 
            this.prijavaHelpProvider.HelpNamespace = "C:\\Users\\Viktor\\source\\repos\\pi21-vcoric-kculina-jmatokovi\\Software\\reRack\\reRack" +
    ".Design\\reRack.chm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label1.Location = new System.Drawing.Point(163, 413);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Nemate korisnički račun?";
            // 
            // Prijava
            // 
            this.AcceptButton = this.uxActionPrijava;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 464);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.uxActionRegistracija);
            this.Controls.Add(this.uxActionPrijava);
            this.Controls.Add(this.uiLozinka);
            this.Controls.Add(this.uxLozinkaLabel);
            this.Controls.Add(this.uiKorIme);
            this.Controls.Add(this.uxKorImeLabel);
            this.Controls.Add(this.uxPrijavaLabel);
            this.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.prijavaHelpProvider.SetHelpKeyword(this, "prijava.htm");
            this.prijavaHelpProvider.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.Topic);
            this.prijavaHelpProvider.SetHelpString(this, "prijava.htm");
            this.Name = "Prijava";
            this.prijavaHelpProvider.SetShowHelp(this, true);
            this.Text = "Prijava";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label uxPrijavaLabel;
        private System.Windows.Forms.Button uxActionRegistracija;
        private System.Windows.Forms.Button uxActionPrijava;
        private System.Windows.Forms.TextBox uiLozinka;
        private System.Windows.Forms.Label uxLozinkaLabel;
        private System.Windows.Forms.TextBox uiKorIme;
        private System.Windows.Forms.Label uxKorImeLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.HelpProvider prijavaHelpProvider;
        private System.Windows.Forms.Label label1;
    }
}

