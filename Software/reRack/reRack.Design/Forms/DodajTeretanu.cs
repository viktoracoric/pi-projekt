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
    public partial class DodajTeretanu : Form
    {
        Entities entities = new Entities();
        public DodajTeretanu(Zahtjev zahtjev)
        {
            InitializeComponent();
            uiGrad.DataSource = entities.Grad.ToList();
            uiKorisnik.DataSource = entities.Korisnik.ToList();
            uiIme.Text = zahtjev.naziv;
            uiKorisnik.Text = zahtjev.Korisnik.korisnicko_ime;
            uiGrad.Text = zahtjev.Grad.naziv;
            uiAdresa.Text = zahtjev.adresa;
            uiKapacitet.Value = zahtjev.kapacitet;
            uiCijena.Value = zahtjev.cijena_clanstva;
            uiKvadratura.Value = zahtjev.kvadratura;
        }
        public DodajTeretanu()
        {
            InitializeComponent();
        }

        private void DodajTeretanu_Load(object sender, EventArgs e)
        {
            
        }

        private void uxActionOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void uxActionSpremi_Click(object sender, EventArgs e)
        {
            Teretana teretana = new Teretana();
            teretana.kapacitet = (int)uiKapacitet.Value;
            teretana.korisnik_id = (uiKorisnik.SelectedItem as Korisnik).id_korisnik;
            teretana.adresa = uiAdresa.Text;
            teretana.naziv = uiIme.Text;
            teretana.grad_id = (uiGrad.SelectedItem as Grad).id_grad;
            teretana.cijena_clanstva = (int)uiCijena.Value;
            teretana.kvadratura = (int)uiKvadratura.Value;
            entities.Teretana.Add(teretana);
            entities.SaveChanges();
            Close();
        }
    }
}
