
namespace reRack.Design.Forms
{
    partial class PrikazZahtjeva
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
            this.uiPopisZahtjeva = new System.Windows.Forms.DataGridView();
            this.uxActionOdustani = new System.Windows.Forms.Button();
            this.uxActionUpravljaj = new System.Windows.Forms.Button();
            this.idzahtjevDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gradidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kapacitetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kvadraturaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cijenaclanstvaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.korisnikidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gradDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.korisnikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zahtjevBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.uiPopisZahtjeva)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zahtjevBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // uiPopisZahtjeva
            // 
            this.uiPopisZahtjeva.AllowUserToAddRows = false;
            this.uiPopisZahtjeva.AllowUserToDeleteRows = false;
            this.uiPopisZahtjeva.AutoGenerateColumns = false;
            this.uiPopisZahtjeva.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uiPopisZahtjeva.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idzahtjevDataGridViewTextBoxColumn,
            this.nazivDataGridViewTextBoxColumn,
            this.adresaDataGridViewTextBoxColumn,
            this.gradidDataGridViewTextBoxColumn,
            this.kapacitetDataGridViewTextBoxColumn,
            this.kvadraturaDataGridViewTextBoxColumn,
            this.cijenaclanstvaDataGridViewTextBoxColumn,
            this.korisnikidDataGridViewTextBoxColumn,
            this.gradDataGridViewTextBoxColumn,
            this.korisnikDataGridViewTextBoxColumn});
            this.uiPopisZahtjeva.DataSource = this.zahtjevBindingSource;
            this.uiPopisZahtjeva.Location = new System.Drawing.Point(12, 23);
            this.uiPopisZahtjeva.Name = "uiPopisZahtjeva";
            this.uiPopisZahtjeva.ReadOnly = true;
            this.uiPopisZahtjeva.Size = new System.Drawing.Size(596, 174);
            this.uiPopisZahtjeva.TabIndex = 0;
            // 
            // uxActionOdustani
            // 
            this.uxActionOdustani.Location = new System.Drawing.Point(165, 250);
            this.uxActionOdustani.Name = "uxActionOdustani";
            this.uxActionOdustani.Size = new System.Drawing.Size(99, 35);
            this.uxActionOdustani.TabIndex = 1;
            this.uxActionOdustani.Text = "Odustani";
            this.uxActionOdustani.UseVisualStyleBackColor = true;
            this.uxActionOdustani.Click += new System.EventHandler(this.uxActionOdustani_Click);
            // 
            // uxActionUpravljaj
            // 
            this.uxActionUpravljaj.Location = new System.Drawing.Point(290, 250);
            this.uxActionUpravljaj.Name = "uxActionUpravljaj";
            this.uxActionUpravljaj.Size = new System.Drawing.Size(99, 35);
            this.uxActionUpravljaj.TabIndex = 1;
            this.uxActionUpravljaj.Text = "Upravljaj zahtjevom";
            this.uxActionUpravljaj.UseVisualStyleBackColor = true;
            this.uxActionUpravljaj.Click += new System.EventHandler(this.uxActionUpravljaj_Click);
            // 
            // idzahtjevDataGridViewTextBoxColumn
            // 
            this.idzahtjevDataGridViewTextBoxColumn.DataPropertyName = "id_zahtjev";
            this.idzahtjevDataGridViewTextBoxColumn.HeaderText = "id_zahtjev";
            this.idzahtjevDataGridViewTextBoxColumn.Name = "idzahtjevDataGridViewTextBoxColumn";
            this.idzahtjevDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nazivDataGridViewTextBoxColumn
            // 
            this.nazivDataGridViewTextBoxColumn.DataPropertyName = "naziv";
            this.nazivDataGridViewTextBoxColumn.HeaderText = "naziv";
            this.nazivDataGridViewTextBoxColumn.Name = "nazivDataGridViewTextBoxColumn";
            this.nazivDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adresaDataGridViewTextBoxColumn
            // 
            this.adresaDataGridViewTextBoxColumn.DataPropertyName = "adresa";
            this.adresaDataGridViewTextBoxColumn.HeaderText = "adresa";
            this.adresaDataGridViewTextBoxColumn.Name = "adresaDataGridViewTextBoxColumn";
            this.adresaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gradidDataGridViewTextBoxColumn
            // 
            this.gradidDataGridViewTextBoxColumn.DataPropertyName = "grad_id";
            this.gradidDataGridViewTextBoxColumn.HeaderText = "grad_id";
            this.gradidDataGridViewTextBoxColumn.Name = "gradidDataGridViewTextBoxColumn";
            this.gradidDataGridViewTextBoxColumn.ReadOnly = true;
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
            // korisnikidDataGridViewTextBoxColumn
            // 
            this.korisnikidDataGridViewTextBoxColumn.DataPropertyName = "korisnik_id";
            this.korisnikidDataGridViewTextBoxColumn.HeaderText = "korisnik_id";
            this.korisnikidDataGridViewTextBoxColumn.Name = "korisnikidDataGridViewTextBoxColumn";
            this.korisnikidDataGridViewTextBoxColumn.ReadOnly = true;
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
            // zahtjevBindingSource
            // 
            this.zahtjevBindingSource.DataSource = typeof(reRack.Design.Zahtjev);
            // 
            // PrikazZahtjeva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 336);
            this.Controls.Add(this.uxActionUpravljaj);
            this.Controls.Add(this.uxActionOdustani);
            this.Controls.Add(this.uiPopisZahtjeva);
            this.Name = "PrikazZahtjeva";
            this.Text = "<";
            this.Load += new System.EventHandler(this.PrikazZahtjeva_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uiPopisZahtjeva)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zahtjevBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView uiPopisZahtjeva;
        private System.Windows.Forms.Button uxActionOdustani;
        private System.Windows.Forms.Button uxActionUpravljaj;
        private System.Windows.Forms.DataGridViewTextBoxColumn idzahtjevDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gradidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kapacitetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kvadraturaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cijenaclanstvaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn korisnikidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gradDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn korisnikDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource zahtjevBindingSource;
    }
}