
namespace reRack.Design.Forms
{
    partial class PrikazSvihTeretana
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
            this.uiActionPosaljiZahtjev = new System.Windows.Forms.Button();
            this.uiActionNazad = new System.Windows.Forms.Button();
            this.uiActionPrikazTeretane = new System.Windows.Forms.Button();
            this.uiFilterKvadraturaLabel = new System.Windows.Forms.Label();
            this.uiFilterCijenaLabel = new System.Windows.Forms.Label();
            this.uiFilterCijena = new System.Windows.Forms.NumericUpDown();
            this.uiFilterKvadratura = new System.Windows.Forms.NumericUpDown();
            this.uiPopisTeretana = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.uiFilterCijena)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiFilterKvadratura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiPopisTeretana)).BeginInit();
            this.SuspendLayout();
            // 
            // uiActionPosaljiZahtjev
            // 
            this.uiActionPosaljiZahtjev.Location = new System.Drawing.Point(687, 142);
            this.uiActionPosaljiZahtjev.Name = "uiActionPosaljiZahtjev";
            this.uiActionPosaljiZahtjev.Size = new System.Drawing.Size(97, 35);
            this.uiActionPosaljiZahtjev.TabIndex = 15;
            this.uiActionPosaljiZahtjev.Text = "Pošalji zahtjev";
            this.uiActionPosaljiZahtjev.UseVisualStyleBackColor = true;
            this.uiActionPosaljiZahtjev.Click += new System.EventHandler(this.uiActionPosaljiZahtjev_Click);
            // 
            // uiActionNazad
            // 
            this.uiActionNazad.Location = new System.Drawing.Point(687, 247);
            this.uiActionNazad.Name = "uiActionNazad";
            this.uiActionNazad.Size = new System.Drawing.Size(97, 35);
            this.uiActionNazad.TabIndex = 14;
            this.uiActionNazad.Text = "Nazad";
            this.uiActionNazad.UseVisualStyleBackColor = true;
            // 
            // uiActionPrikazTeretane
            // 
            this.uiActionPrikazTeretane.Location = new System.Drawing.Point(687, 195);
            this.uiActionPrikazTeretane.Name = "uiActionPrikazTeretane";
            this.uiActionPrikazTeretane.Size = new System.Drawing.Size(97, 35);
            this.uiActionPrikazTeretane.TabIndex = 13;
            this.uiActionPrikazTeretane.Text = "Prikaz teretane";
            this.uiActionPrikazTeretane.UseVisualStyleBackColor = true;
            // 
            // uiFilterKvadraturaLabel
            // 
            this.uiFilterKvadraturaLabel.AutoSize = true;
            this.uiFilterKvadraturaLabel.Location = new System.Drawing.Point(673, 79);
            this.uiFilterKvadraturaLabel.Name = "uiFilterKvadraturaLabel";
            this.uiFilterKvadraturaLabel.Size = new System.Drawing.Size(59, 13);
            this.uiFilterKvadraturaLabel.TabIndex = 12;
            this.uiFilterKvadraturaLabel.Text = "Kvadratura";
            // 
            // uiFilterCijenaLabel
            // 
            this.uiFilterCijenaLabel.AutoSize = true;
            this.uiFilterCijenaLabel.Location = new System.Drawing.Point(673, 19);
            this.uiFilterCijenaLabel.Name = "uiFilterCijenaLabel";
            this.uiFilterCijenaLabel.Size = new System.Drawing.Size(36, 13);
            this.uiFilterCijenaLabel.TabIndex = 11;
            this.uiFilterCijenaLabel.Text = "Cijena";
            // 
            // uiFilterCijena
            // 
            this.uiFilterCijena.DecimalPlaces = 2;
            this.uiFilterCijena.Location = new System.Drawing.Point(673, 45);
            this.uiFilterCijena.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.uiFilterCijena.Name = "uiFilterCijena";
            this.uiFilterCijena.Size = new System.Drawing.Size(121, 20);
            this.uiFilterCijena.TabIndex = 10;
            this.uiFilterCijena.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.uiFilterCijena.ValueChanged += new System.EventHandler(this.uiFilterCijena_ValueChanged);
            // 
            // uiFilterKvadratura
            // 
            this.uiFilterKvadratura.Location = new System.Drawing.Point(674, 105);
            this.uiFilterKvadratura.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.uiFilterKvadratura.Name = "uiFilterKvadratura";
            this.uiFilterKvadratura.Size = new System.Drawing.Size(120, 20);
            this.uiFilterKvadratura.TabIndex = 9;
            this.uiFilterKvadratura.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.uiFilterKvadratura.ValueChanged += new System.EventHandler(this.uiFilterKvadratura_ValueChanged);
            // 
            // uiPopisTeretana
            // 
            this.uiPopisTeretana.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uiPopisTeretana.Location = new System.Drawing.Point(6, 1);
            this.uiPopisTeretana.Name = "uiPopisTeretana";
            this.uiPopisTeretana.Size = new System.Drawing.Size(661, 448);
            this.uiPopisTeretana.TabIndex = 8;
            // 
            // PrikazSvihTeretana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.uiActionPosaljiZahtjev);
            this.Controls.Add(this.uiActionNazad);
            this.Controls.Add(this.uiActionPrikazTeretane);
            this.Controls.Add(this.uiFilterKvadraturaLabel);
            this.Controls.Add(this.uiFilterCijenaLabel);
            this.Controls.Add(this.uiFilterCijena);
            this.Controls.Add(this.uiFilterKvadratura);
            this.Controls.Add(this.uiPopisTeretana);
            this.Name = "PrikazSvihTeretana";
            this.Text = "PrikazSvihTeretana";
            this.Load += new System.EventHandler(this.PrikazSvihTeretana_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uiFilterCijena)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiFilterKvadratura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiPopisTeretana)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uiActionPosaljiZahtjev;
        private System.Windows.Forms.Button uiActionNazad;
        private System.Windows.Forms.Button uiActionPrikazTeretane;
        private System.Windows.Forms.Label uiFilterKvadraturaLabel;
        private System.Windows.Forms.Label uiFilterCijenaLabel;
        private System.Windows.Forms.NumericUpDown uiFilterCijena;
        private System.Windows.Forms.NumericUpDown uiFilterKvadratura;
        private System.Windows.Forms.DataGridView uiPopisTeretana;
    }
}