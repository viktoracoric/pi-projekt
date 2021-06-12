using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace reRack.Design.Forms
{
    public partial class OstavljanjeRecenzija : Form
    {
        private  Korisnik prijavljeniKorisnik;
        private Teretana selektiranaTeretana;
        Entities entities = new Entities();


        public OstavljanjeRecenzija(Teretana selektiranaTeretana, Korisnik prijavljeniKorisnik)
        {
            InitializeComponent();
            this.selektiranaTeretana = selektiranaTeretana;
            this.prijavljeniKorisnik = prijavljeniKorisnik;
        }

        public OstavljanjeRecenzija()
        {
            InitializeComponent();
        }
        private void Recenzija_Load(object sender, EventArgs e)
        {
            uiTeretana.Text = selektiranaTeretana.naziv;
        }

        private void uiDodaj_Click(object sender, EventArgs e)
        {
            Recenzija recenzija = new Recenzija();
            recenzija.korisnik_id = prijavljeniKorisnik.id_korisnik;
            recenzija.teretana_id = selektiranaTeretana.id_teretana;
            recenzija.ocjena = int.Parse(uiOcjena.Text);
            recenzija.komentar = uiKomentar.Text;

            entities.Recenzija.Add(recenzija);
            entities.SaveChanges();
            Close();
        }

        private void uiOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
