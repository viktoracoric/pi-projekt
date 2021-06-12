
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
            this.components = new System.ComponentModel.Container();
            this.uiActionPosaljiZahtjev = new System.Windows.Forms.Button();
            this.uiActionNazad = new System.Windows.Forms.Button();
            this.uiActionPrikazTeretane = new System.Windows.Forms.Button();
            this.uiFilterKvadraturaLabel = new System.Windows.Forms.Label();
            this.uiFilterCijenaLabel = new System.Windows.Forms.Label();
            this.uiFilterCijena = new System.Windows.Forms.NumericUpDown();
            this.uiFilterKvadratura = new System.Windows.Forms.NumericUpDown();
            this.uiPopisTeretana = new System.Windows.Forms.DataGridView();
            this.idteretanaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.korisnikidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.korisnikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gradDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kapacitetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kvadraturaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cijenaclanstvaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gradidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clanstvoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recenzijaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rezervacijaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teretanaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uiUclaniSe = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.uiFilterCijena)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiFilterKvadratura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiPopisTeretana)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teretanaBindingSource)).BeginInit();
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
            this.uiActionNazad.Location = new System.Drawing.Point(687, 312);
            this.uiActionNazad.Name = "uiActionNazad";
            this.uiActionNazad.Size = new System.Drawing.Size(97, 35);
            this.uiActionNazad.TabIndex = 14;
            this.uiActionNazad.Text = "Nazad";
            this.uiActionNazad.UseVisualStyleBackColor = true;
            this.uiActionNazad.Click += new System.EventHandler(this.uiActionNazad_Click);
            // 
            // uiActionPrikazTeretane
            // 
            this.uiActionPrikazTeretane.Location = new System.Drawing.Point(687, 195);
            this.uiActionPrikazTeretane.Name = "uiActionPrikazTeretane";
            this.uiActionPrikazTeretane.Size = new System.Drawing.Size(97, 35);
            this.uiActionPrikazTeretane.TabIndex = 13;
            this.uiActionPrikazTeretane.Text = "Prikaz teretane";
            this.uiActionPrikazTeretane.UseVisualStyleBackColor = true;
            this.uiActionPrikazTeretane.Click += new System.EventHandler(this.uiActionPrikazTeretane_Click);
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
            this.uiPopisTeretana.AllowUserToAddRows = false;
            this.uiPopisTeretana.AllowUserToDeleteRows = false;
            this.uiPopisTeretana.AutoGenerateColumns = false;
            this.uiPopisTeretana.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uiPopisTeretana.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idteretanaDataGridViewTextBoxColumn,
            this.korisnikidDataGridViewTextBoxColumn,
            this.nazivDataGridViewTextBoxColumn,
            this.korisnikDataGridViewTextBoxColumn,
            this.gradDataGridViewTextBoxColumn,
            this.adresaDataGridViewTextBoxColumn,
            this.kapacitetDataGridViewTextBoxColumn,
            this.kvadraturaDataGridViewTextBoxColumn,
            this.cijenaclanstvaDataGridViewTextBoxColumn,
            this.gradidDataGridViewTextBoxColumn,
            this.clanstvoDataGridViewTextBoxColumn,
            this.recenzijaDataGridViewTextBoxColumn,
            this.rezervacijaDataGridViewTextBoxColumn});
            this.uiPopisTeretana.DataSource = this.teretanaBindingSource;
            this.uiPopisTeretana.Location = new System.Drawing.Point(6, 1);
            this.uiPopisTeretana.Name = "uiPopisTeretana";
            this.uiPopisTeretana.ReadOnly = true;
            this.uiPopisTeretana.Size = new System.Drawing.Size(661, 368);
            this.uiPopisTeretana.TabIndex = 8;
            // 
            // idteretanaDataGridViewTextBoxColumn
            // 
            this.idteretanaDataGridViewTextBoxColumn.DataPropertyName = "id_teretana";
            this.idteretanaDataGridViewTextBoxColumn.HeaderText = "id_teretana";
            this.idteretanaDataGridViewTextBoxColumn.Name = "idteretanaDataGridViewTextBoxColumn";
            this.idteretanaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idteretanaDataGridViewTextBoxColumn.Visible = false;
            // 
            // korisnikidDataGridViewTextBoxColumn
            // 
            this.korisnikidDataGridViewTextBoxColumn.DataPropertyName = "korisnik_id";
            this.korisnikidDataGridViewTextBoxColumn.HeaderText = "korisnik_id";
            this.korisnikidDataGridViewTextBoxColumn.Name = "korisnikidDataGridViewTextBoxColumn";
            this.korisnikidDataGridViewTextBoxColumn.ReadOnly = true;
            this.korisnikidDataGridViewTextBoxColumn.Visible = false;
            // 
            // nazivDataGridViewTextBoxColumn
            // 
            this.nazivDataGridViewTextBoxColumn.DataPropertyName = "naziv";
            this.nazivDataGridViewTextBoxColumn.HeaderText = "Naziv";
            this.nazivDataGridViewTextBoxColumn.Name = "nazivDataGridViewTextBoxColumn";
            this.nazivDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // korisnikDataGridViewTextBoxColumn
            // 
            this.korisnikDataGridViewTextBoxColumn.DataPropertyName = "Korisnik";
            this.korisnikDataGridViewTextBoxColumn.HeaderText = "Vlasnik";
            this.korisnikDataGridViewTextBoxColumn.Name = "korisnikDataGridViewTextBoxColumn";
            this.korisnikDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gradDataGridViewTextBoxColumn
            // 
            this.gradDataGridViewTextBoxColumn.DataPropertyName = "Grad";
            this.gradDataGridViewTextBoxColumn.HeaderText = "Grad";
            this.gradDataGridViewTextBoxColumn.Name = "gradDataGridViewTextBoxColumn";
            this.gradDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adresaDataGridViewTextBoxColumn
            // 
            this.adresaDataGridViewTextBoxColumn.DataPropertyName = "adresa";
            this.adresaDataGridViewTextBoxColumn.HeaderText = "Adresa";
            this.adresaDataGridViewTextBoxColumn.Name = "adresaDataGridViewTextBoxColumn";
            this.adresaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kapacitetDataGridViewTextBoxColumn
            // 
            this.kapacitetDataGridViewTextBoxColumn.DataPropertyName = "kapacitet";
            this.kapacitetDataGridViewTextBoxColumn.HeaderText = "Kapacitet";
            this.kapacitetDataGridViewTextBoxColumn.Name = "kapacitetDataGridViewTextBoxColumn";
            this.kapacitetDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kvadraturaDataGridViewTextBoxColumn
            // 
            this.kvadraturaDataGridViewTextBoxColumn.DataPropertyName = "kvadratura";
            this.kvadraturaDataGridViewTextBoxColumn.HeaderText = "Kvadratura";
            this.kvadraturaDataGridViewTextBoxColumn.Name = "kvadraturaDataGridViewTextBoxColumn";
            this.kvadraturaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cijenaclanstvaDataGridViewTextBoxColumn
            // 
            this.cijenaclanstvaDataGridViewTextBoxColumn.DataPropertyName = "cijena_clanstva";
            this.cijenaclanstvaDataGridViewTextBoxColumn.HeaderText = "Cijena";
            this.cijenaclanstvaDataGridViewTextBoxColumn.Name = "cijenaclanstvaDataGridViewTextBoxColumn";
            this.cijenaclanstvaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gradidDataGridViewTextBoxColumn
            // 
            this.gradidDataGridViewTextBoxColumn.DataPropertyName = "grad_id";
            this.gradidDataGridViewTextBoxColumn.HeaderText = "grad_id";
            this.gradidDataGridViewTextBoxColumn.Name = "gradidDataGridViewTextBoxColumn";
            this.gradidDataGridViewTextBoxColumn.ReadOnly = true;
            this.gradidDataGridViewTextBoxColumn.Visible = false;
            // 
            // clanstvoDataGridViewTextBoxColumn
            // 
            this.clanstvoDataGridViewTextBoxColumn.DataPropertyName = "Clanstvo";
            this.clanstvoDataGridViewTextBoxColumn.HeaderText = "Clanstvo";
            this.clanstvoDataGridViewTextBoxColumn.Name = "clanstvoDataGridViewTextBoxColumn";
            this.clanstvoDataGridViewTextBoxColumn.ReadOnly = true;
            this.clanstvoDataGridViewTextBoxColumn.Visible = false;
            // 
            // recenzijaDataGridViewTextBoxColumn
            // 
            this.recenzijaDataGridViewTextBoxColumn.DataPropertyName = "Recenzija";
            this.recenzijaDataGridViewTextBoxColumn.HeaderText = "Recenzija";
            this.recenzijaDataGridViewTextBoxColumn.Name = "recenzijaDataGridViewTextBoxColumn";
            this.recenzijaDataGridViewTextBoxColumn.ReadOnly = true;
            this.recenzijaDataGridViewTextBoxColumn.Visible = false;
            // 
            // rezervacijaDataGridViewTextBoxColumn
            // 
            this.rezervacijaDataGridViewTextBoxColumn.DataPropertyName = "Rezervacija";
            this.rezervacijaDataGridViewTextBoxColumn.HeaderText = "Rezervacija";
            this.rezervacijaDataGridViewTextBoxColumn.Name = "rezervacijaDataGridViewTextBoxColumn";
            this.rezervacijaDataGridViewTextBoxColumn.ReadOnly = true;
            this.rezervacijaDataGridViewTextBoxColumn.Visible = false;
            // 
            // teretanaBindingSource
            // 
            this.teretanaBindingSource.DataSource = typeof(reRack.Design.Teretana);
            // 
            // uiUclaniSe
            // 
            this.uiUclaniSe.Location = new System.Drawing.Point(687, 252);
            this.uiUclaniSe.Name = "uiUclaniSe";
            this.uiUclaniSe.Size = new System.Drawing.Size(97, 35);
            this.uiUclaniSe.TabIndex = 16;
            this.uiUclaniSe.Text = "Uclani se";
            this.uiUclaniSe.UseVisualStyleBackColor = true;
            this.uiUclaniSe.Click += new System.EventHandler(this.uiUclaniSe_Click);
            // 
            // PrikazSvihTeretana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 376);
            this.Controls.Add(this.uiUclaniSe);
            this.Controls.Add(this.uiActionPosaljiZahtjev);
            this.Controls.Add(this.uiActionNazad);
            this.Controls.Add(this.uiActionPrikazTeretane);
            this.Controls.Add(this.uiFilterKvadraturaLabel);
            this.Controls.Add(this.uiFilterCijenaLabel);
            this.Controls.Add(this.uiFilterCijena);
            this.Controls.Add(this.uiFilterKvadratura);
            this.Controls.Add(this.uiPopisTeretana);
            this.Name = "PrikazSvihTeretana";
            this.Text = "Prikaz svih teretana";
            this.Load += new System.EventHandler(this.PrikazSvihTeretana_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uiFilterCijena)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiFilterKvadratura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiPopisTeretana)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teretanaBindingSource)).EndInit();
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
        private System.Windows.Forms.BindingSource teretanaBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idteretanaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn korisnikidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn korisnikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gradDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kapacitetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kvadraturaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cijenaclanstvaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gradidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clanstvoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn recenzijaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rezervacijaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button uiUclaniSe;
    }
}