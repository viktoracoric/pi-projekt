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
                uxActionUrediPodatkeTeretane.Hide();
                uxActionPregledZahtjeva.Hide();
                uxActionDodajTeretanu.Hide();
            }
            if (prijavljeniKorisnik.uloga_id == 1)
            {
                uxActionPregledZahtjeva.Hide();
                uxActionDodajTeretanu.Hide();
            }

            this.prijavljeniKorisnik = prijavljeniKorisnik;
        }

        private void uiActionUrediPodatke_Click(object sender, EventArgs e)
        {
            Profil form = new Profil(prijavljeniKorisnik);
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

        private void uiActionDodajTeretanu_Click(object sender, EventArgs e)
        {
            DodajTeretanu form = new DodajTeretanu();
            form.ShowDialog();
        }

        private void uiActionPrikazTeretana_Click(object sender, EventArgs e)
        {
            PrikazSvihTeretana prikazSvihTeretana  = new PrikazSvihTeretana(prijavljeniKorisnik);
            prikazSvihTeretana.ShowDialog();
            
        }

        private void uiActionUrediPodatkeTeretane_Click(object sender, EventArgs e)
        {
            UrediTeretanu urediTeretanu = new UrediTeretanu(prijavljeniKorisnik);
            urediTeretanu.ShowDialog();
        }

        private void uiActionDodajVlasnika_Click(object sender, EventArgs e)
        {
            PrikazZahtjeva prikazZahtjeva = new PrikazZahtjeva();
            prikazZahtjeva.ShowDialog();
        }
    }
}
