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
    public partial class UrediTeretanu : Form
    {
        Entities entities = new Entities();
        Korisnik prijavljeniKorisnik = new Korisnik();
        public UrediTeretanu(Korisnik prijavljeniKorisnik)
        {
            InitializeComponent();
            this.prijavljeniKorisnik = prijavljeniKorisnik;
            if(prijavljeniKorisnik.uloga_id < 2)
            {
                uiObrisiTeretanu.Hide();
            }
        }

        private void UrediTeretanu_Load(object sender, EventArgs e)
        {
                var teretane = from t in entities.Teretana
                               select t;
            if(prijavljeniKorisnik.uloga_id == 1)
            {
                teretane = teretane.Where(x => x.korisnik_id == prijavljeniKorisnik.id_korisnik);
                uiKorisnik.Enabled = false;
            }
            foreach(var item in teretane)
            {
                uiIme.Items.Add(item);
            }
        }

        private void uiIme_SelectedValueChanged(object sender, EventArgs e)
        {
            uiKorisnik.DataSource = entities.Korisnik.ToList();
            uiKorisnik.Text = (uiIme.SelectedItem as Teretana).Korisnik.korisnicko_ime;
            uiGrad.DataSource = entities.Grad.ToList();
            uiGrad.Text = (uiIme.SelectedItem as Teretana).Grad.naziv;
            uiAdresa.Text = (uiIme.SelectedItem as Teretana).adresa;
            uiKapacitet.Value = (uiIme.SelectedItem as Teretana).kapacitet;
            uiKvadratura.Value = (uiIme.SelectedItem as Teretana).kvadratura;
            uiCijena.Value = (uiIme.SelectedItem as Teretana).cijena_clanstva;
        }

        private void uxActionOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void uxActionSpremi_Click(object sender, EventArgs e)
        {
            int idTer = (uiIme.SelectedItem as Teretana).id_teretana;
            var teretana = (from t in entities.Teretana
                       where t.id_teretana == idTer
                       select t).First();
            teretana.korisnik_id = (uiKorisnik.SelectedItem as Korisnik).id_korisnik;
            teretana.grad_id = (uiGrad.SelectedItem as Grad).id_grad;
            teretana.adresa = uiAdresa.Text;
            teretana.kapacitet = (int)uiKapacitet.Value;
            teretana.kvadratura = (int)uiKvadratura.Value;
            teretana.cijena_clanstva = (int)uiCijena.Value;
            entities.SaveChanges();
            MessageBox.Show("Izmjene uspješno spremljene!");
            Close();
        }

        private void uiObrisiTeretanu_Click(object sender, EventArgs e)
        {
            Teretana obrisiMe = (uiIme.SelectedItem as Teretana);
            entities.Teretana.Remove(obrisiMe);
            entities.SaveChanges();
            MessageBox.Show("Teretana uspješno obrisana!");
            Close();
        }
    }
}
