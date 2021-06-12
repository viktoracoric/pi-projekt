
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
            this.components = new System.ComponentModel.Container();
            this.dgvMojeTeretane = new System.Windows.Forms.DataGridView();
            this.btnRecenzija = new System.Windows.Forms.Button();
            this.uiRezerviraj = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.uiTermin = new System.Windows.Forms.ComboBox();
            this.uxActionPrikazMojihTermina = new System.Windows.Forms.Button();
            this.uiObavjest = new System.Windows.Forms.Label();
            this.uxActionNazad = new System.Windows.Forms.Button();
            this.idteretanaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.korisnikidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gradidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gradDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kapacitetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kvadraturaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cijenaclanstvaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clanstvoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.korisnikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recenzijaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rezervacijaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teretanaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMojeTeretane)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teretanaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMojeTeretane
            // 
            this.dgvMojeTeretane.AllowUserToAddRows = false;
            this.dgvMojeTeretane.AllowUserToDeleteRows = false;
            this.dgvMojeTeretane.AutoGenerateColumns = false;
            this.dgvMojeTeretane.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMojeTeretane.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idteretanaDataGridViewTextBoxColumn,
            this.korisnikidDataGridViewTextBoxColumn,
            this.gradidDataGridViewTextBoxColumn,
            this.nazivDataGridViewTextBoxColumn,
            this.gradDataGridViewTextBoxColumn,
            this.adresaDataGridViewTextBoxColumn,
            this.kapacitetDataGridViewTextBoxColumn,
            this.kvadraturaDataGridViewTextBoxColumn,
            this.cijenaclanstvaDataGridViewTextBoxColumn,
            this.clanstvoDataGridViewTextBoxColumn,
            this.korisnikDataGridViewTextBoxColumn,
            this.recenzijaDataGridViewTextBoxColumn,
            this.rezervacijaDataGridViewTextBoxColumn});
            this.dgvMojeTeretane.DataSource = this.teretanaBindingSource;
            this.dgvMojeTeretane.Location = new System.Drawing.Point(13, 13);
            this.dgvMojeTeretane.Name = "dgvMojeTeretane";
            this.dgvMojeTeretane.ReadOnly = true;
            this.dgvMojeTeretane.Size = new System.Drawing.Size(426, 390);
            this.dgvMojeTeretane.TabIndex = 0;
            // 
            // btnRecenzija
            // 
            this.btnRecenzija.Location = new System.Drawing.Point(490, 167);
            this.btnRecenzija.Name = "btnRecenzija";
            this.btnRecenzija.Size = new System.Drawing.Size(121, 48);
            this.btnRecenzija.TabIndex = 1;
            this.btnRecenzija.Text = "Ostavi recenziju";
            this.btnRecenzija.UseVisualStyleBackColor = true;
            this.btnRecenzija.Click += new System.EventHandler(this.btnRecenzija_Click);
            // 
            // uiRezerviraj
            // 
            this.uiRezerviraj.Location = new System.Drawing.Point(490, 91);
            this.uiRezerviraj.Name = "uiRezerviraj";
            this.uiRezerviraj.Size = new System.Drawing.Size(121, 48);
            this.uiRezerviraj.TabIndex = 2;
            this.uiRezerviraj.Text = "Rezerviraj termin";
            this.uiRezerviraj.UseVisualStyleBackColor = true;
            this.uiRezerviraj.Click += new System.EventHandler(this.uiRezerviraj_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(487, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Termini:";
            // 
            // uiTermin
            // 
            this.uiTermin.FormattingEnabled = true;
            this.uiTermin.Location = new System.Drawing.Point(490, 29);
            this.uiTermin.Name = "uiTermin";
            this.uiTermin.Size = new System.Drawing.Size(121, 21);
            this.uiTermin.TabIndex = 4;
            // 
            // uxActionPrikazMojihTermina
            // 
            this.uxActionPrikazMojihTermina.Location = new System.Drawing.Point(490, 244);
            this.uxActionPrikazMojihTermina.Name = "uxActionPrikazMojihTermina";
            this.uxActionPrikazMojihTermina.Size = new System.Drawing.Size(121, 51);
            this.uxActionPrikazMojihTermina.TabIndex = 5;
            this.uxActionPrikazMojihTermina.Text = "Moji rezervirani termini";
            this.uxActionPrikazMojihTermina.UseVisualStyleBackColor = true;
            this.uxActionPrikazMojihTermina.Click += new System.EventHandler(this.uxActionPrikazMojihTermina_Click);
            // 
            // uiObavjest
            // 
            this.uiObavjest.AutoSize = true;
            this.uiObavjest.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiObavjest.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.uiObavjest.Location = new System.Drawing.Point(24, 427);
            this.uiObavjest.Name = "uiObavjest";
            this.uiObavjest.Size = new System.Drawing.Size(0, 16);
            this.uiObavjest.TabIndex = 6;
            // 
            // uxActionNazad
            // 
            this.uxActionNazad.Location = new System.Drawing.Point(490, 360);
            this.uxActionNazad.Name = "uxActionNazad";
            this.uxActionNazad.Size = new System.Drawing.Size(102, 43);
            this.uxActionNazad.TabIndex = 7;
            this.uxActionNazad.Text = "Nazad";
            this.uxActionNazad.UseVisualStyleBackColor = true;
            this.uxActionNazad.Click += new System.EventHandler(this.uxActionNazad_Click);
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
            // gradidDataGridViewTextBoxColumn
            // 
            this.gradidDataGridViewTextBoxColumn.DataPropertyName = "grad_id";
            this.gradidDataGridViewTextBoxColumn.HeaderText = "grad_id";
            this.gradidDataGridViewTextBoxColumn.Name = "gradidDataGridViewTextBoxColumn";
            this.gradidDataGridViewTextBoxColumn.ReadOnly = true;
            this.gradidDataGridViewTextBoxColumn.Visible = false;
            // 
            // nazivDataGridViewTextBoxColumn
            // 
            this.nazivDataGridViewTextBoxColumn.DataPropertyName = "naziv";
            this.nazivDataGridViewTextBoxColumn.HeaderText = "Naziv";
            this.nazivDataGridViewTextBoxColumn.Name = "nazivDataGridViewTextBoxColumn";
            this.nazivDataGridViewTextBoxColumn.ReadOnly = true;
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
            // clanstvoDataGridViewTextBoxColumn
            // 
            this.clanstvoDataGridViewTextBoxColumn.DataPropertyName = "Clanstvo";
            this.clanstvoDataGridViewTextBoxColumn.HeaderText = "Clanstvo";
            this.clanstvoDataGridViewTextBoxColumn.Name = "clanstvoDataGridViewTextBoxColumn";
            this.clanstvoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // korisnikDataGridViewTextBoxColumn
            // 
            this.korisnikDataGridViewTextBoxColumn.DataPropertyName = "Korisnik";
            this.korisnikDataGridViewTextBoxColumn.HeaderText = "Korisnik";
            this.korisnikDataGridViewTextBoxColumn.Name = "korisnikDataGridViewTextBoxColumn";
            this.korisnikDataGridViewTextBoxColumn.ReadOnly = true;
            this.korisnikDataGridViewTextBoxColumn.Visible = false;
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
            this.teretanaBindingSource.CurrentChanged += new System.EventHandler(this.teretanaBindingSource_CurrentChanged);
            // 
            // MojeTeretane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 460);
            this.Controls.Add(this.uxActionNazad);
            this.Controls.Add(this.uiObavjest);
            this.Controls.Add(this.uxActionPrikazMojihTermina);
            this.Controls.Add(this.uiTermin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uiRezerviraj);
            this.Controls.Add(this.btnRecenzija);
            this.Controls.Add(this.dgvMojeTeretane);
            this.Name = "MojeTeretane";
            this.Text = "MojeTeretane";
            this.Load += new System.EventHandler(this.MojeTeretane_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMojeTeretane)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teretanaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMojeTeretane;
        private System.Windows.Forms.Button btnRecenzija;
        private System.Windows.Forms.BindingSource teretanaBindingSource;
        private System.Windows.Forms.Button uiRezerviraj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox uiTermin;
        private System.Windows.Forms.DataGridViewTextBoxColumn idteretanaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn korisnikidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gradidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gradDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kapacitetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kvadraturaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cijenaclanstvaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clanstvoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn korisnikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn recenzijaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rezervacijaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button uxActionPrikazMojihTermina;
        private System.Windows.Forms.Label uiObavjest;
        private System.Windows.Forms.Button uxActionNazad;
    }
}