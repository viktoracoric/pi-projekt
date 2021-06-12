
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
            this.teretanaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idteretanaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.korisnikidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gradidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kapacitetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kvadraturaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cijenaclanstvaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clanstvoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gradDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.korisnikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recenzijaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rezervacijaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.adresaDataGridViewTextBoxColumn,
            this.kapacitetDataGridViewTextBoxColumn,
            this.kvadraturaDataGridViewTextBoxColumn,
            this.cijenaclanstvaDataGridViewTextBoxColumn,
            this.nazivDataGridViewTextBoxColumn,
            this.clanstvoDataGridViewTextBoxColumn,
            this.gradDataGridViewTextBoxColumn,
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
            this.btnRecenzija.Location = new System.Drawing.Point(490, 13);
            this.btnRecenzija.Name = "btnRecenzija";
            this.btnRecenzija.Size = new System.Drawing.Size(115, 48);
            this.btnRecenzija.TabIndex = 1;
            this.btnRecenzija.Text = "Ostavi recenziju";
            this.btnRecenzija.UseVisualStyleBackColor = true;
            this.btnRecenzija.Click += new System.EventHandler(this.btnRecenzija_Click);
            // 
            // teretanaBindingSource
            // 
            this.teretanaBindingSource.DataSource = typeof(reRack.Design.Teretana);
            // 
            // idteretanaDataGridViewTextBoxColumn
            // 
            this.idteretanaDataGridViewTextBoxColumn.DataPropertyName = "id_teretana";
            this.idteretanaDataGridViewTextBoxColumn.HeaderText = "id_teretana";
            this.idteretanaDataGridViewTextBoxColumn.Name = "idteretanaDataGridViewTextBoxColumn";
            this.idteretanaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // korisnikidDataGridViewTextBoxColumn
            // 
            this.korisnikidDataGridViewTextBoxColumn.DataPropertyName = "korisnik_id";
            this.korisnikidDataGridViewTextBoxColumn.HeaderText = "korisnik_id";
            this.korisnikidDataGridViewTextBoxColumn.Name = "korisnikidDataGridViewTextBoxColumn";
            this.korisnikidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gradidDataGridViewTextBoxColumn
            // 
            this.gradidDataGridViewTextBoxColumn.DataPropertyName = "grad_id";
            this.gradidDataGridViewTextBoxColumn.HeaderText = "grad_id";
            this.gradidDataGridViewTextBoxColumn.Name = "gradidDataGridViewTextBoxColumn";
            this.gradidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adresaDataGridViewTextBoxColumn
            // 
            this.adresaDataGridViewTextBoxColumn.DataPropertyName = "adresa";
            this.adresaDataGridViewTextBoxColumn.HeaderText = "adresa";
            this.adresaDataGridViewTextBoxColumn.Name = "adresaDataGridViewTextBoxColumn";
            this.adresaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kapacitetDataGridViewTextBoxColumn
            // 
            this.kapacitetDataGridViewTextBoxColumn.DataPropertyName = "kapacitet";
            this.kapacitetDataGridViewTextBoxColumn.HeaderText = "kapacitet";
            this.kapacitetDataGridViewTextBoxColumn.Name = "kapacitetDataGridViewTextBoxColumn";
            this.kapacitetDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kvadraturaDataGridViewTextBoxColumn
            // 
            this.kvadraturaDataGridViewTextBoxColumn.DataPropertyName = "kvadratura";
            this.kvadraturaDataGridViewTextBoxColumn.HeaderText = "kvadratura";
            this.kvadraturaDataGridViewTextBoxColumn.Name = "kvadraturaDataGridViewTextBoxColumn";
            this.kvadraturaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cijenaclanstvaDataGridViewTextBoxColumn
            // 
            this.cijenaclanstvaDataGridViewTextBoxColumn.DataPropertyName = "cijena_clanstva";
            this.cijenaclanstvaDataGridViewTextBoxColumn.HeaderText = "cijena_clanstva";
            this.cijenaclanstvaDataGridViewTextBoxColumn.Name = "cijenaclanstvaDataGridViewTextBoxColumn";
            this.cijenaclanstvaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nazivDataGridViewTextBoxColumn
            // 
            this.nazivDataGridViewTextBoxColumn.DataPropertyName = "naziv";
            this.nazivDataGridViewTextBoxColumn.HeaderText = "naziv";
            this.nazivDataGridViewTextBoxColumn.Name = "nazivDataGridViewTextBoxColumn";
            this.nazivDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clanstvoDataGridViewTextBoxColumn
            // 
            this.clanstvoDataGridViewTextBoxColumn.DataPropertyName = "Clanstvo";
            this.clanstvoDataGridViewTextBoxColumn.HeaderText = "Clanstvo";
            this.clanstvoDataGridViewTextBoxColumn.Name = "clanstvoDataGridViewTextBoxColumn";
            this.clanstvoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gradDataGridViewTextBoxColumn
            // 
            this.gradDataGridViewTextBoxColumn.DataPropertyName = "Grad";
            this.gradDataGridViewTextBoxColumn.HeaderText = "Grad";
            this.gradDataGridViewTextBoxColumn.Name = "gradDataGridViewTextBoxColumn";
            this.gradDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // korisnikDataGridViewTextBoxColumn
            // 
            this.korisnikDataGridViewTextBoxColumn.DataPropertyName = "Korisnik";
            this.korisnikDataGridViewTextBoxColumn.HeaderText = "Korisnik";
            this.korisnikDataGridViewTextBoxColumn.Name = "korisnikDataGridViewTextBoxColumn";
            this.korisnikDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // recenzijaDataGridViewTextBoxColumn
            // 
            this.recenzijaDataGridViewTextBoxColumn.DataPropertyName = "Recenzija";
            this.recenzijaDataGridViewTextBoxColumn.HeaderText = "Recenzija";
            this.recenzijaDataGridViewTextBoxColumn.Name = "recenzijaDataGridViewTextBoxColumn";
            this.recenzijaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rezervacijaDataGridViewTextBoxColumn
            // 
            this.rezervacijaDataGridViewTextBoxColumn.DataPropertyName = "Rezervacija";
            this.rezervacijaDataGridViewTextBoxColumn.HeaderText = "Rezervacija";
            this.rezervacijaDataGridViewTextBoxColumn.Name = "rezervacijaDataGridViewTextBoxColumn";
            this.rezervacijaDataGridViewTextBoxColumn.ReadOnly = true;
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
            ((System.ComponentModel.ISupportInitialize)(this.teretanaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMojeTeretane;
        private System.Windows.Forms.Button btnRecenzija;
        private System.Windows.Forms.DataGridViewTextBoxColumn idteretanaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn korisnikidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gradidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kapacitetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kvadraturaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cijenaclanstvaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clanstvoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gradDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn korisnikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn recenzijaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rezervacijaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource teretanaBindingSource;
    }
}