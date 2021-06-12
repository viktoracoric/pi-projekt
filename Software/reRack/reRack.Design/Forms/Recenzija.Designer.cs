
namespace reRack.Design.Forms
{
    partial class Recenzija
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
            this.label2 = new System.Windows.Forms.Label();
            this.uiOcjena = new System.Windows.Forms.TextBox();
            this.uiKomentar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.uiTeretana = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ocjena:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Komentar:";
            // 
            // uiOcjena
            // 
            this.uiOcjena.Location = new System.Drawing.Point(94, 101);
            this.uiOcjena.Name = "uiOcjena";
            this.uiOcjena.Size = new System.Drawing.Size(137, 20);
            this.uiOcjena.TabIndex = 2;
            // 
            // uiKomentar
            // 
            this.uiKomentar.Location = new System.Drawing.Point(94, 178);
            this.uiKomentar.Multiline = true;
            this.uiKomentar.Name = "uiKomentar";
            this.uiKomentar.Size = new System.Drawing.Size(137, 76);
            this.uiKomentar.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ostavite osvrt za teretanu:";
            // 
            // uiTeretana
            // 
            this.uiTeretana.Location = new System.Drawing.Point(151, 26);
            this.uiTeretana.Name = "uiTeretana";
            this.uiTeretana.Size = new System.Drawing.Size(80, 20);
            this.uiTeretana.TabIndex = 5;
            // 
            // Recenzija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 391);
            this.Controls.Add(this.uiTeretana);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.uiKomentar);
            this.Controls.Add(this.uiOcjena);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Recenzija";
            this.Text = "Recenzija";
            this.Load += new System.EventHandler(this.Recenzija_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox uiOcjena;
        private System.Windows.Forms.TextBox uiKomentar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox uiTeretana;
    }
}