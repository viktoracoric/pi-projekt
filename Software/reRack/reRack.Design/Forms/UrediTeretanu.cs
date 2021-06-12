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
        public UrediTeretanu()
        {
            InitializeComponent();
        }

        private void UrediTeretanu_Load(object sender, EventArgs e)
        {
            var teretane = from t in entities.Teretana
                           select t;
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
            var upit = from t in entities.Teretana
                       where t.id_teretana == uiIme.SelectedIndex
                       select t;
            var teretana = upit.FirstOrDefault();
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
    }
}
