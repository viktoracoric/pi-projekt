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
    public partial class MojiTermini : Form
    {
        private Korisnik prijavljeniKorisnik;
        Entities entities = new Entities();
        public MojiTermini(Korisnik prijavljeniKorisnik)
        {
            InitializeComponent();
            this.prijavljeniKorisnik = prijavljeniKorisnik;

            var query = from r in entities.Rezervacija
                        where r.korisnik_id == prijavljeniKorisnik.id_korisnik
                        select r;

            rezervacijaBindingSource.DataSource = null;
            rezervacijaBindingSource.DataSource = query.ToList();
        }

        private void uxActionObrisi_Click(object sender, EventArgs e)
        {
            try
            {
                if(rezervacijaBindingSource.Current != null)
                {
                    Rezervacija rezervacija = rezervacijaBindingSource.Current as Rezervacija;
                    entities.Rezervacija.Remove(rezervacija);
                    entities.SaveChanges();
                }
                else
                {
                    throw new DataException("Nijedan termin nije odabran!");
                }
            }
            catch (DataException ex)
            {
                MessageBox.Show(ex.Poruka);
            }
            

            var query = from r in entities.Rezervacija
                        where r.korisnik_id == prijavljeniKorisnik.id_korisnik
                        select r;

            rezervacijaBindingSource.DataSource = null;
            rezervacijaBindingSource.DataSource = query.ToList();
            
        }
    }
}
