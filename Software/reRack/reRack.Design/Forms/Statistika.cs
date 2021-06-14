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
    public partial class Statistika : Form
    {
        Entities entities = new Entities();
        private Korisnik prijavljeniKorisnik;

        public Statistika(Korisnik prijavljeniKorisnik)
        {
            InitializeComponent();
            this.prijavljeniKorisnik = prijavljeniKorisnik;
        }

        private void DohvatiSredstva()
        {
            entities = new Entities();
            var upitKorisnik = from k in entities.Korisnik
                               where k.id_korisnik == prijavljeniKorisnik.id_korisnik
                               select k;
            prijavljeniKorisnik = upitKorisnik.FirstOrDefault();
            uiSredstva.Text = null;
            uiSredstva.Text = prijavljeniKorisnik.raspoloziva_sredstva.ToString();
        }

        private void Statistika_Load(object sender, EventArgs e)
        {
            DohvatiSredstva();
            DateTime danasnjiDatum = DateTime.Today;
            var upit = from r in entities.Rezervacija
                       where r.korisnik_id == prijavljeniKorisnik.id_korisnik && r.datum < danasnjiDatum
                       select r;


            rezervacijaBindingSource.DataSource = null;
            rezervacijaBindingSource.DataSource = upit.ToList();

            uiBrojSati.Text = upit.Count().ToString();

        }

        private void uiUplati_Click(object sender, EventArgs e)
        {
            Uplata form = new Uplata(prijavljeniKorisnik);
            form.ShowDialog();
            DohvatiSredstva();
        }
    }
}
