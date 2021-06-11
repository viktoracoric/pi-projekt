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
    public partial class Registracija : Form
    {
        Entities entities = new Entities();
        public Registracija()
        {
            InitializeComponent();
        }

        private void Registracija_Load(object sender, EventArgs e)
        {
            var gradovi = from g in entities.Grad
                          select g.naziv;
            uiGrad.DataSource = gradovi.ToList();
        }

        private void uxActionRegistrirajSe_Click(object sender, EventArgs e)
        {
            /*string ime = uiIme.Text;
            string prezime = uiPrezime.Text;
            string email = uiEmail.Text;
            string grad = uiGrad.SelectedItem.ToString();
            string brojTelefona = uiBrojTelefona.Text;
            string lozinka = uiLozinka.Text;
            string potvrdaLozinke = uiPotvrdaLozinke.Text; */

            if(uiLozinka.Text == uiPotvrdaLozinke.Text)
            {
                Prijava prijava = new Prijava();
                this.Hide();
                prijava.Closed += (s, args) => this.Close();
                prijava.Show();
                //TODO: unijeti u bazu
                Korisnik korisnik = new Korisnik();
                korisnik.ime = uiIme.Text;
                korisnik.uloga_id = 0;
                korisnik.korisnicko_ime = uiIme.Text.Substring(0, 1).ToLower() + uiPrezime.Text.ToLower();
                korisnik.prezime = uiPrezime.Text;
                korisnik.mail = uiEmail.Text;
                korisnik.grad_id = uiGrad.SelectedIndex;
                korisnik.broj_telefona = uiBrojTelefona.Text;
                korisnik.lozinka = uiLozinka.Text;
                korisnik.datum_registracije = DateTime.Now;
                korisnik.raspoloziva_sredstva = 0;
                entities.Korisnik.Add(korisnik);
                entities.SaveChanges();
                Close();
            }
            else
            {
                MessageBox.Show("Lozinke se ne podudaraju");
            }
        }
    }
}
