
namespace reRack.Design
{
    partial class uiPrijavaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uiPrijavaForm));
            this.uxPrijavaLabel = new System.Windows.Forms.Label();
            this.uxRegistracijaButton = new System.Windows.Forms.Button();
            this.uxZaboravljenaLozinkaButton = new System.Windows.Forms.Button();
            this.uxPrijavaButton = new System.Windows.Forms.Button();
            this.uiLozinka = new System.Windows.Forms.TextBox();
            this.uxLozinkaLabel = new System.Windows.Forms.Label();
            this.uiKorIme = new System.Windows.Forms.TextBox();
            this.uxKorImeLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // uxPrijavaLabel
            // 
            this.uxPrijavaLabel.AutoSize = true;
            this.uxPrijavaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.uxPrijavaLabel.Location = new System.Drawing.Point(165, 20);
            this.uxPrijavaLabel.Name = "uxPrijavaLabel";
            this.uxPrijavaLabel.Size = new System.Drawing.Size(138, 29);
            this.uxPrijavaLabel.TabIndex = 1;
            this.uxPrijavaLabel.Text = "Prijavite se";
            // 
            // uxRegistracijaButton
            // 
            this.uxRegistracijaButton.Location = new System.Drawing.Point(74, 419);
            this.uxRegistracijaButton.Name = "uxRegistracijaButton";
            this.uxRegistracijaButton.Size = new System.Drawing.Size(133, 23);
            this.uxRegistracijaButton.TabIndex = 14;
            this.uxRegistracijaButton.Text = "Registriraj se";
            this.uxRegistracijaButton.UseVisualStyleBackColor = true;
            this.uxRegistracijaButton.Click += new System.EventHandler(this.uxRegistracijaButton_Click);
            // 
            // uxZaboravljenaLozinkaButton
            // 
            this.uxZaboravljenaLozinkaButton.Location = new System.Drawing.Point(244, 419);
            this.uxZaboravljenaLozinkaButton.Name = "uxZaboravljenaLozinkaButton";
            this.uxZaboravljenaLozinkaButton.Size = new System.Drawing.Size(133, 23);
            this.uxZaboravljenaLozinkaButton.TabIndex = 13;
            this.uxZaboravljenaLozinkaButton.Text = "Zaboraljena lozinka?";
            this.uxZaboravljenaLozinkaButton.UseVisualStyleBackColor = true;
            // 
            // uxPrijavaButton
            // 
            this.uxPrijavaButton.Location = new System.Drawing.Point(161, 358);
            this.uxPrijavaButton.Name = "uxPrijavaButton";
            this.uxPrijavaButton.Size = new System.Drawing.Size(133, 33);
            this.uxPrijavaButton.TabIndex = 12;
            this.uxPrijavaButton.Text = "Prijavi se";
            this.uxPrijavaButton.UseVisualStyleBackColor = true;
            this.uxPrijavaButton.Click += new System.EventHandler(this.uxPrijavaButton_Click);
            // 
            // uiLozinka
            // 
            this.uiLozinka.Location = new System.Drawing.Point(161, 309);
            this.uiLozinka.Name = "uiLozinka";
            this.uiLozinka.PasswordChar = '*';
            this.uiLozinka.Size = new System.Drawing.Size(133, 20);
            this.uiLozinka.TabIndex = 11;
            // 
            // uxLozinkaLabel
            // 
            this.uxLozinkaLabel.AutoSize = true;
            this.uxLozinkaLabel.Location = new System.Drawing.Point(203, 277);
            this.uxLozinkaLabel.Name = "uxLozinkaLabel";
            this.uxLozinkaLabel.Size = new System.Drawing.Size(44, 13);
            this.uxLozinkaLabel.TabIndex = 10;
            this.uxLozinkaLabel.Text = "Lozinka";
            // 
            // uiKorIme
            // 
            this.uiKorIme.Location = new System.Drawing.Point(161, 226);
            this.uiKorIme.Name = "uiKorIme";
            this.uiKorIme.Size = new System.Drawing.Size(133, 20);
            this.uiKorIme.TabIndex = 9;
            // 
            // uxKorImeLabel
            // 
            this.uxKorImeLabel.AutoSize = true;
            this.uxKorImeLabel.Location = new System.Drawing.Point(189, 196);
            this.uxKorImeLabel.Name = "uxKorImeLabel";
            this.uxKorImeLabel.Size = new System.Drawing.Size(75, 13);
            this.uxKorImeLabel.TabIndex = 8;
            this.uxKorImeLabel.Text = "Korisničko ime";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(34, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(404, 113);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // uiPrijavaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 464);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.uxRegistracijaButton);
            this.Controls.Add(this.uxZaboravljenaLozinkaButton);
            this.Controls.Add(this.uxPrijavaButton);
            this.Controls.Add(this.uiLozinka);
            this.Controls.Add(this.uxLozinkaLabel);
            this.Controls.Add(this.uiKorIme);
            this.Controls.Add(this.uxKorImeLabel);
            this.Controls.Add(this.uxPrijavaLabel);
            this.Name = "uiPrijavaForm";
            this.Text = "Prijava";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label uxPrijavaLabel;
        private System.Windows.Forms.Button uxRegistracijaButton;
        private System.Windows.Forms.Button uxZaboravljenaLozinkaButton;
        private System.Windows.Forms.Button uxPrijavaButton;
        private System.Windows.Forms.TextBox uiLozinka;
        private System.Windows.Forms.Label uxLozinkaLabel;
        private System.Windows.Forms.TextBox uiKorIme;
        private System.Windows.Forms.Label uxKorImeLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

