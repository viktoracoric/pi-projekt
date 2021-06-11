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
    public partial class SlanjeZahtjev : Form
    {
        Entities entities = new Entities();
        private Korisnik prijavljeniKorisnik;

        public SlanjeZahtjev(Korisnik prijavljeniKorisnik)
        {
            InitializeComponent();
            this.prijavljeniKorisnik = prijavljeniKorisnik;
        }

        private void Zahtjev_Load(object sender, EventArgs e)
        {
            uiGrad.DataSource = entities.Grad.ToList();
        }

        private void uxActionOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void uxActionSpremi_Click(object sender, EventArgs e)
        {
            Zahtjev zahtjev = new Zahtjev();

            zahtjev.adresa = uiAdresa.Text;
            zahtjev.grad_id = uiGrad.SelectedIndex;
            zahtjev.korisnik_id = prijavljeniKorisnik.id_korisnik;
            zahtjev.naziv = uiNaziv.Text;
            zahtjev.cijena_clanstva = int.Parse(uiCijena.Text);
            zahtjev.kapacitet = int.Parse(uiKapacitet.Text);
            zahtjev.kvadratura = int.Parse(uiKvadratura.Text);
            entities.Zahtjev.Add(zahtjev);
            entities.SaveChanges();
            Close();
        }
    }
}
