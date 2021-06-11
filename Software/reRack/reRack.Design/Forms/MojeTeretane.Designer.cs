
namespace reRack.Design.Forms
{
    partial class MojeTeretane
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
            this.dgvMojeTeretane = new System.Windows.Forms.DataGridView();
            this.btnRecenzija = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMojeTeretane)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMojeTeretane
            // 
            this.dgvMojeTeretane.AllowUserToAddRows = false;
            this.dgvMojeTeretane.AllowUserToDeleteRows = false;
            this.dgvMojeTeretane.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMojeTeretane.Location = new System.Drawing.Point(13, 13);
            this.dgvMojeTeretane.Name = "dgvMojeTeretane";
            this.dgvMojeTeretane.ReadOnly = true;
            this.dgvMojeTeretane.Size = new System.Drawing.Size(426, 390);
            this.dgvMojeTeretane.TabIndex = 0;
            // 
            // btnRecenzija
            // 
            this.btnRecenzija.Location = new System.Drawing.Point(490, 13);
            this.btnRecenzija.Name = "btnRecenzija";
            this.btnRecenzija.Size = new System.Drawing.Size(115, 48);
            this.btnRecenzija.TabIndex = 1;
            this.btnRecenzija.Text = "Ostavi recenziju";
            this.btnRecenzija.UseVisualStyleBackColor = true;
            this.btnRecenzija.Click += new System.EventHandler(this.btnRecenzija_Click);
            // 
            // MojeTeretane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 432);
            this.Controls.Add(this.btnRecenzija);
            this.Controls.Add(this.dgvMojeTeretane);
            this.Name = "MojeTeretane";
            this.Text = "MojeTeretane";
            this.Load += new System.EventHandler(this.MojeTeretane_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMojeTeretane)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMojeTeretane;
        private System.Windows.Forms.Button btnRecenzija;
    }
}