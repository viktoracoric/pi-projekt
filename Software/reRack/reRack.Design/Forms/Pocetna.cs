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
    public partial class Pocetna : Form
    {
        private Korisnik prijavljeniKorisnik;
        Entities entities = new Entities();

        public Pocetna(Korisnik prijavljeniKorisnik)
        {
            InitializeComponent();
            if(prijavljeniKorisnik.uloga_id == 0)
            {
                uiActionUrediPodatkeTeretane.Hide();
                uiActionDodajVlasnika.Hide();
                uiActionDodajTeretanu.Hide();
            }
            if (prijavljeniKorisnik.uloga_id == 1)
            {
                uiActionDodajVlasnika.Hide();
                uiActionDodajTeretanu.Hide();
            }

            this.prijavljeniKorisnik = prijavljeniKorisnik;
        }

        private void uiActionUrediPodatke_Click(object sender, EventArgs e)
        {
            UrediPodatke form = new UrediPodatke(prijavljeniKorisnik);
            form.ShowDialog();
            int id = prijavljeniKorisnik.id_korisnik;
            prijavljeniKorisnik = null;
            prijavljeniKorisnik = (from k in entities.Korisnik
                                   where k.id_korisnik == id
                                   select k).Single();
        }


        private void uiActionMojeTeretane_Click(object sender, EventArgs e)
        {
            MojeTeretane form = new MojeTeretane(prijavljeniKorisnik);
            form.ShowDialog();
        }
    }
}
