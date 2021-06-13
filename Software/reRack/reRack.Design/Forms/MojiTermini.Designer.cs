
namespace reRack.Design.Forms
{
    partial class MojiTermini
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.korisnikidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teretanaidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intervalidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.korisnikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vrIntervalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teretanaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rezervacijaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uxActionObrisi = new System.Windows.Forms.Button();
            this.mojiTerminiHelpProvider = new System.Windows.Forms.HelpProvider();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rezervacijaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.korisnikidDataGridViewTextBoxColumn,
            this.teretanaidDataGridViewTextBoxColumn,
            this.intervalidDataGridViewTextBoxColumn,
            this.korisnikDataGridViewTextBoxColumn,
            this.vrIntervalDataGridViewTextBoxColumn,
            this.teretanaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.rezervacijaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(73, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(245, 170);
            this.dataGridView1.TabIndex = 0;
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
            // korisnikDataGridViewTextBoxColumn
            // 
            this.korisnikDataGridViewTextBoxColumn.DataPropertyName = "Korisnik";
            this.korisnikDataGridViewTextBoxColumn.HeaderText = "Korisnik";
            this.korisnikDataGridViewTextBoxColumn.Name = "korisnikDataGridViewTextBoxColumn";
            this.korisnikDataGridViewTextBoxColumn.ReadOnly = true;
            this.korisnikDataGridViewTextBoxColumn.Visible = false;
            // 
            // vrIntervalDataGridViewTextBoxColumn
            // 
            this.vrIntervalDataGridViewTextBoxColumn.DataPropertyName = "VrInterval";
            this.vrIntervalDataGridViewTextBoxColumn.HeaderText = "VrInterval";
            this.vrIntervalDataGridViewTextBoxColumn.Name = "vrIntervalDataGridViewTextBoxColumn";
            this.vrIntervalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // teretanaDataGridViewTextBoxColumn
            // 
            this.teretanaDataGridViewTextBoxColumn.DataPropertyName = "Teretana";
            this.teretanaDataGridViewTextBoxColumn.HeaderText = "Teretana";
            this.teretanaDataGridViewTextBoxColumn.Name = "teretanaDataGridViewTextBoxColumn";
            this.teretanaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rezervacijaBindingSource
            // 
            this.rezervacijaBindingSource.DataSource = typeof(reRack.Design.Rezervacija);
            // 
            // uxActionObrisi
            // 
            this.uxActionObrisi.Location = new System.Drawing.Point(117, 202);
            this.uxActionObrisi.Name = "uxActionObrisi";
            this.uxActionObrisi.Size = new System.Drawing.Size(140, 50);
            this.uxActionObrisi.TabIndex = 1;
            this.uxActionObrisi.Text = "Obriši rezervirani termin";
            this.uxActionObrisi.UseVisualStyleBackColor = true;
            this.uxActionObrisi.Click += new System.EventHandler(this.uxActionObrisi_Click);
            // 
            // mojiTerminiHelpProvider
            // 
            this.mojiTerminiHelpProvider.HelpNamespace = "reRack.chm";
            // 
            // MojiTermini
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 285);
            this.Controls.Add(this.uxActionObrisi);
            this.Controls.Add(this.dataGridView1);
            this.mojiTerminiHelpProvider.SetHelpKeyword(this, "mojiTermini.htm");
            this.mojiTerminiHelpProvider.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.Topic);
            this.mojiTerminiHelpProvider.SetHelpString(this, "mojiTermini.htm");
            this.Name = "MojiTermini";
            this.mojiTerminiHelpProvider.SetShowHelp(this, true);
            this.Text = "Moji termini";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rezervacijaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button uxActionObrisi;
        private System.Windows.Forms.BindingSource rezervacijaBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn korisnikidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teretanaidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn intervalidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn korisnikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vrIntervalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teretanaDataGridViewTextBoxColumn;
        private System.Windows.Forms.HelpProvider mojiTerminiHelpProvider;
    }
}