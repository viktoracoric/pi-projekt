
namespace reRack.Design.Forms
{
    partial class Uplata
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Uplata));
            this.uiSlika = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.uiIBAN = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.uiCVV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.uiNovci = new System.Windows.Forms.TextBox();
            this.uxActionPotvrdi = new System.Windows.Forms.Button();
            this.uxActionOdustani = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.uiSlika)).BeginInit();
            this.SuspendLayout();
            // 
            // uiSlika
            // 
            this.uiSlika.Image = ((System.Drawing.Image)(resources.GetObject("uiSlika.Image")));
            this.uiSlika.Location = new System.Drawing.Point(91, 12);
            this.uiSlika.Name = "uiSlika";
            this.uiSlika.Size = new System.Drawing.Size(100, 103);
            this.uiSlika.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.uiSlika.TabIndex = 0;
            this.uiSlika.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Unesite IBAN:";
            // 
            // uiIBAN
            // 
            this.uiIBAN.Location = new System.Drawing.Point(59, 171);
            this.uiIBAN.Name = "uiIBAN";
            this.uiIBAN.Size = new System.Drawing.Size(170, 20);
            this.uiIBAN.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Unesite CCV2";
            // 
            // uiCVV
            // 
            this.uiCVV.Location = new System.Drawing.Point(108, 239);
            this.uiCVV.Name = "uiCVV";
            this.uiCVV.Size = new System.Drawing.Size(66, 20);
            this.uiCVV.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 282);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Koliko novaca želite uplatiti?";
            // 
            // uiNovci
            // 
            this.uiNovci.Location = new System.Drawing.Point(108, 314);
            this.uiNovci.Name = "uiNovci";
            this.uiNovci.Size = new System.Drawing.Size(66, 20);
            this.uiNovci.TabIndex = 6;
            // 
            // uxActionPotvrdi
            // 
            this.uxActionPotvrdi.Location = new System.Drawing.Point(22, 366);
            this.uxActionPotvrdi.Name = "uxActionPotvrdi";
            this.uxActionPotvrdi.Size = new System.Drawing.Size(75, 23);
            this.uxActionPotvrdi.TabIndex = 7;
            this.uxActionPotvrdi.Text = "Potvrdi";
            this.uxActionPotvrdi.UseVisualStyleBackColor = true;
            this.uxActionPotvrdi.Click += new System.EventHandler(this.uiPotvrdi_Click);
            // 
            // uxActionOdustani
            // 
            this.uxActionOdustani.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.uxActionOdustani.Location = new System.Drawing.Point(183, 366);
            this.uxActionOdustani.Name = "uxActionOdustani";
            this.uxActionOdustani.Size = new System.Drawing.Size(75, 23);
            this.uxActionOdustani.TabIndex = 8;
            this.uxActionOdustani.Text = "Odustani";
            this.uxActionOdustani.UseVisualStyleBackColor = true;
            this.uxActionOdustani.Click += new System.EventHandler(this.uiOdustani_Click);
            // 
            // Uplata
            // 
            this.AcceptButton = this.uxActionPotvrdi;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.uxActionOdustani;
            this.ClientSize = new System.Drawing.Size(295, 450);
            this.Controls.Add(this.uxActionOdustani);
            this.Controls.Add(this.uxActionPotvrdi);
            this.Controls.Add(this.uiNovci);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.uiCVV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.uiIBAN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uiSlika);
            this.Name = "Uplata";
            this.Text = "Uplata";
            ((System.ComponentModel.ISupportInitialize)(this.uiSlika)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox uiSlika;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox uiIBAN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox uiCVV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox uiNovci;
        private System.Windows.Forms.Button uxActionPotvrdi;
        private System.Windows.Forms.Button uxActionOdustani;
    }
}