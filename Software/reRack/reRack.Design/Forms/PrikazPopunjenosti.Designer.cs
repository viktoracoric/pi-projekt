
namespace reRack.Design.Forms
{
    partial class PrikazPopunjenosti
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
            this.label1 = new System.Windows.Forms.Label();
            this.uiNaziv = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.uiKapacitet = new System.Windows.Forms.TextBox();
            this.uxActionZatvori = new System.Windows.Forms.Button();
            this.uiPopunjenost = new System.Windows.Forms.DataGridView();
            this.vrijemepocetakDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vrijemekrajDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postotakPopunjenostiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idintervalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rezervacijaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.popunjenostTerminaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.uiPopunjenost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popunjenostTerminaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naziv teretane:";
            // 
            // uiNaziv
            // 
            this.uiNaziv.Location = new System.Drawing.Point(200, 31);
            this.uiNaziv.Name = "uiNaziv";
            this.uiNaziv.ReadOnly = true;
            this.uiNaziv.Size = new System.Drawing.Size(100, 20);
            this.uiNaziv.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Kapacitet teretane:";
            // 
            // uiKapacitet
            // 
            this.uiKapacitet.Location = new System.Drawing.Point(200, 67);
            this.uiKapacitet.Name = "uiKapacitet";
            this.uiKapacitet.ReadOnly = true;
            this.uiKapacitet.Size = new System.Drawing.Size(100, 20);
            this.uiKapacitet.TabIndex = 1;
            // 
            // uxActionZatvori
            // 
            this.uxActionZatvori.Location = new System.Drawing.Point(134, 271);
            this.uxActionZatvori.Name = "uxActionZatvori";
            this.uxActionZatvori.Size = new System.Drawing.Size(123, 44);
            this.uxActionZatvori.TabIndex = 3;
            this.uxActionZatvori.Text = "Zatvori";
            this.uxActionZatvori.UseVisualStyleBackColor = true;
            this.uxActionZatvori.Click += new System.EventHandler(this.uxActionZatvori_Click);
            // 
            // uiPopunjenost
            // 
            this.uiPopunjenost.AllowUserToAddRows = false;
            this.uiPopunjenost.AllowUserToDeleteRows = false;
            this.uiPopunjenost.AutoGenerateColumns = false;
            this.uiPopunjenost.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uiPopunjenost.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vrijemepocetakDataGridViewTextBoxColumn,
            this.vrijemekrajDataGridViewTextBoxColumn,
            this.postotakPopunjenostiDataGridViewTextBoxColumn,
            this.idintervalDataGridViewTextBoxColumn,
            this.rezervacijaDataGridViewTextBoxColumn});
            this.uiPopunjenost.DataSource = this.popunjenostTerminaBindingSource;
            this.uiPopunjenost.Location = new System.Drawing.Point(29, 103);
            this.uiPopunjenost.Name = "uiPopunjenost";
            this.uiPopunjenost.ReadOnly = true;
            this.uiPopunjenost.Size = new System.Drawing.Size(345, 150);
            this.uiPopunjenost.TabIndex = 4;
            // 
            // vrijemepocetakDataGridViewTextBoxColumn
            // 
            this.vrijemepocetakDataGridViewTextBoxColumn.DataPropertyName = "vrijeme_pocetak";
            this.vrijemepocetakDataGridViewTextBoxColumn.HeaderText = "Početak";
            this.vrijemepocetakDataGridViewTextBoxColumn.Name = "vrijemepocetakDataGridViewTextBoxColumn";
            this.vrijemepocetakDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vrijemekrajDataGridViewTextBoxColumn
            // 
            this.vrijemekrajDataGridViewTextBoxColumn.DataPropertyName = "vrijeme_kraj";
            this.vrijemekrajDataGridViewTextBoxColumn.HeaderText = "Kraj";
            this.vrijemekrajDataGridViewTextBoxColumn.Name = "vrijemekrajDataGridViewTextBoxColumn";
            this.vrijemekrajDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // postotakPopunjenostiDataGridViewTextBoxColumn
            // 
            this.postotakPopunjenostiDataGridViewTextBoxColumn.DataPropertyName = "PostotakPopunjenosti";
            this.postotakPopunjenostiDataGridViewTextBoxColumn.HeaderText = "Popunjenost";
            this.postotakPopunjenostiDataGridViewTextBoxColumn.Name = "postotakPopunjenostiDataGridViewTextBoxColumn";
            this.postotakPopunjenostiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idintervalDataGridViewTextBoxColumn
            // 
            this.idintervalDataGridViewTextBoxColumn.DataPropertyName = "id_interval";
            this.idintervalDataGridViewTextBoxColumn.HeaderText = "id_interval";
            this.idintervalDataGridViewTextBoxColumn.Name = "idintervalDataGridViewTextBoxColumn";
            this.idintervalDataGridViewTextBoxColumn.ReadOnly = true;
            this.idintervalDataGridViewTextBoxColumn.Visible = false;
            // 
            // rezervacijaDataGridViewTextBoxColumn
            // 
            this.rezervacijaDataGridViewTextBoxColumn.DataPropertyName = "Rezervacija";
            this.rezervacijaDataGridViewTextBoxColumn.HeaderText = "Rezervacija";
            this.rezervacijaDataGridViewTextBoxColumn.Name = "rezervacijaDataGridViewTextBoxColumn";
            this.rezervacijaDataGridViewTextBoxColumn.ReadOnly = true;
            this.rezervacijaDataGridViewTextBoxColumn.Visible = false;
            // 
            // popunjenostTerminaBindingSource
            // 
            this.popunjenostTerminaBindingSource.DataSource = typeof(reRack.Design.PopunjenostTermina);
            // 
            // PrikazPopunjenosti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 336);
            this.Controls.Add(this.uiPopunjenost);
            this.Controls.Add(this.uxActionZatvori);
            this.Controls.Add(this.uiKapacitet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.uiNaziv);
            this.Controls.Add(this.label1);
            this.Name = "PrikazPopunjenosti";
            this.Text = "Prikaz Popunjenosti";
            this.Load += new System.EventHandler(this.PrikazPopunjenosti_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uiPopunjenost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popunjenostTerminaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox uiNaziv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox uiKapacitet;
        private System.Windows.Forms.Button uxActionZatvori;
        private System.Windows.Forms.DataGridView uiPopunjenost;
        private System.Windows.Forms.DataGridViewTextBoxColumn vrijemepocetakDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vrijemekrajDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postotakPopunjenostiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idintervalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rezervacijaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource popunjenostTerminaBindingSource;
    }
}