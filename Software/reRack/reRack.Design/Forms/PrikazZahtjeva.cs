using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace reRack.Design.Forms
{
    public partial class PrikazZahtjeva : Form
    {
        Entities entities = new Entities();
        Zahtjev zahtjev;
        public PrikazZahtjeva()
        {
            InitializeComponent();
        }

        private void PrikazZahtjeva_Load(object sender, EventArgs e)
        {
            OsvjeziDGV();
        }

        private void uxActionOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void uxActionUpravljaj_Click(object sender, EventArgs e)
        {
            zahtjev = new Zahtjev();
            try
            {
                if(zahtjevBindingSource.Current != null)
                {
                    zahtjev = zahtjevBindingSource.Current as Zahtjev;
                    DodajTeretanu dodajTeretanu = new DodajTeretanu(zahtjev);
                    dodajTeretanu.ShowDialog();

                    OsvjeziDGV();
                }
                else
                {
                    throw new DataException("Nije odabran nijedan zahtjev!");
                }
            }
            catch (DataException ex)
            {
                MessageBox.Show(ex.Poruka);
            }
            
        }

        public void OsvjeziDGV()
        {
            zahtjevBindingSource.DataSource = null;
            var query = from z in entities.Zahtjev
                        select z;
            zahtjevBindingSource.DataSource = query.ToList();
        }
    }
}
