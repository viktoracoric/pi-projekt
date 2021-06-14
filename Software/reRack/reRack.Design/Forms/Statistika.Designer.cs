
namespace reRack.Design.Forms
{
    partial class Statistika
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
            this.uiStatistika = new System.Windows.Forms.DataGridView();
            this.korisnikidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teretanaidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intervalidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idrezervacijaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.korisnikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teretanaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vrIntervalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rezervacijaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.uiBrojSati = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.uiSredstva = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.uiUplati = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.uiStatistika)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rezervacijaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tvoje prošle rezervacije:";
            // 
            // uiStatistika
            // 
            this.uiStatistika.AllowUserToAddRows = false;
            this.uiStatistika.AllowUserToDeleteRows = false;
            this.uiStatistika.AutoGenerateColumns = false;
            this.uiStatistika.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uiStatistika.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.korisnikidDataGridViewTextBoxColumn,
            this.teretanaidDataGridViewTextBoxColumn,
            this.intervalidDataGridViewTextBoxColumn,
            this.idrezervacijaDataGridViewTextBoxColumn,
            this.korisnikDataGridViewTextBoxColumn,
            this.teretanaDataGridViewTextBoxColumn,
            this.datum,
            this.vrIntervalDataGridViewTextBoxColumn});
            this.uiStatistika.DataSource = this.rezervacijaBindingSource;
            this.uiStatistika.Location = new System.Drawing.Point(15, 52);
            this.uiStatistika.Name = "uiStatistika";
            this.uiStatistika.ReadOnly = true;
            this.uiStatistika.Size = new System.Drawing.Size(345, 184);
            this.uiStatistika.TabIndex = 1;
            // 
            // korisnikidDataGridViewTextBoxColumn
            // 
            this.korisnikidDataGridViewTextBoxColumn.DataPropertyName = "korisnik_id";
            this.korisnikidDataGridViewTextBoxColumn.HeaderText = "korisnik_id";
            this.korisnikidDataGridViewTextBoxColumn.Name = "korisnikidDataGridViewTextBoxColumn";
            this.korisnikidDataGridViewTextBoxColumn.ReadOnly = true;
            this.korisnikidDataGridViewTextBoxColumn.Visible = false;
            // 
            // teretanaidDataGridViewTextBoxColumn
            // 
            this.teretanaidDataGridViewTextBoxColumn.DataPropertyName = "teretana_id";
            this.teretanaidDataGridViewTextBoxColumn.HeaderText = "teretana_id";
            this.teretanaidDataGridViewTextBoxColumn.Name = "teretanaidDataGridViewTextBoxColumn";
            this.teretanaidDataGridViewTextBoxColumn.ReadOnly = true;
            this.teretanaidDataGridViewTextBoxColumn.Visible = false;
            // 
            // intervalidDataGridViewTextBoxColumn
            // 
            this.intervalidDataGridViewTextBoxColumn.DataPropertyName = "interval_id";
            this.intervalidDataGridViewTextBoxColumn.HeaderText = "interval_id";
            this.intervalidDataGridViewTextBoxColumn.Name = "intervalidDataGridViewTextBoxColumn";
            this.intervalidDataGridViewTextBoxColumn.ReadOnly = true;
            this.intervalidDataGridViewTextBoxColumn.Visible = false;
            // 
            // idrezervacijaDataGridViewTextBoxColumn
            // 
            this.idrezervacijaDataGridViewTextBoxColumn.DataPropertyName = "id_rezervacija";
            this.idrezervacijaDataGridViewTextBoxColumn.HeaderText = "id_rezervacija";
            this.idrezervacijaDataGridViewTextBoxColumn.Name = "idrezervacijaDataGridViewTextBoxColumn";
            this.idrezervacijaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idrezervacijaDataGridViewTextBoxColumn.Visible = false;
            // 
            // korisnikDataGridViewTextBoxColumn
            // 
            this.korisnikDataGridViewTextBoxColumn.DataPropertyName = "Korisnik";
            this.korisnikDataGridViewTextBoxColumn.HeaderText = "Korisnik";
            this.korisnikDataGridViewTextBoxColumn.Name = "korisnikDataGridViewTextBoxColumn";
            this.korisnikDataGridViewTextBoxColumn.ReadOnly = true;
            this.korisnikDataGridViewTextBoxColumn.Visible = false;
            // 
            // teretanaDataGridViewTextBoxColumn
            // 
            this.teretanaDataGridViewTextBoxColumn.DataPropertyName = "Teretana";
            this.teretanaDataGridViewTextBoxColumn.HeaderText = "Teretana";
            this.teretanaDataGridViewTextBoxColumn.Name = "teretanaDataGridViewTextBoxColumn";
            this.teretanaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datum
            // 
            this.datum.DataPropertyName = "datum";
            this.datum.HeaderText = "Datum";
            this.datum.Name = "datum";
            this.datum.ReadOnly = true;
            // 
            // vrIntervalDataGridViewTextBoxColumn
            // 
            this.vrIntervalDataGridViewTextBoxColumn.DataPropertyName = "VrInterval";
            this.vrIntervalDataGridViewTextBoxColumn.HeaderText = "Vremenski interval";
            this.vrIntervalDataGridViewTextBoxColumn.Name = "vrIntervalDataGridViewTextBoxColumn";
            this.vrIntervalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rezervacijaBindingSource
            // 
            this.rezervacijaBindingSource.DataSource = typeof(reRack.Design.Rezervacija);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Do sada ste u teretani proveli:";
            // 
            // uiBrojSati
            // 
            this.uiBrojSati.Location = new System.Drawing.Point(166, 262);
            this.uiBrojSati.Name = "uiBrojSati";
            this.uiBrojSati.ReadOnly = true;
            this.uiBrojSati.Size = new System.Drawing.Size(100, 20);
            this.uiBrojSati.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(273, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "sati";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 311);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Preostala novčana sredstva:";
            // 
            // uiSredstva
            // 
            this.uiSredstva.Location = new System.Drawing.Point(166, 308);
            this.uiSredstva.Name = "uiSredstva";
            this.uiSredstva.ReadOnly = true;
            this.uiSredstva.Size = new System.Drawing.Size(100, 20);
            this.uiSredstva.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(273, 311);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "kn";
            // 
            // uiUplati
            // 
            this.uiUplati.Location = new System.Drawing.Point(166, 351);
            this.uiUplati.Name = "uiUplati";
            this.uiUplati.Size = new System.Drawing.Size(99, 23);
            this.uiUplati.TabIndex = 8;
            this.uiUplati.Text = "Uplati sredstva";
            this.uiUplati.UseVisualStyleBackColor = true;
            this.uiUplati.Click += new System.EventHandler(this.uiUplati_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 356);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Ponestaje vam novaca?";
            // 
            // Statistika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.uiUplati);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.uiSredstva);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.uiBrojSati);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.uiStatistika);
            this.Controls.Add(this.label1);
            this.Name = "Statistika";
            this.Text = "Statistika";
            this.Load += new System.EventHandler(this.Statistika_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uiStatistika)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rezervacijaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView uiStatistika;
        private System.Windows.Forms.BindingSource rezervacijaBindingSource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox uiBrojSati;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn korisnikidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teretanaidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn intervalidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idrezervacijaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn korisnikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teretanaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datum;
        private System.Windows.Forms.DataGridViewTextBoxColumn vrIntervalDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox uiSredstva;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button uiUplati;
        private System.Windows.Forms.Label label6;
    }
}