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
        Validacija.Validacija validacija = new Validacija.Validacija();
        public Registracija()
        {
            InitializeComponent();
        }

        private void Registracija_Load(object sender, EventArgs e)
        {
            var gradovi = from g in entities.Grad
                          select g;
            uiGrad.DataSource = gradovi.ToList();
        }

        private void uxActionRegistrirajSe_Click(object sender, EventArgs e)
        {
            try
            {
                if (validacija.ValidirajJednakostLozinki(uiLozinka.Text, uiPotvrdaLozinke.Text))
                {
                    Prijava prijava = new Prijava();
                    this.Hide();
                    prijava.Closed += (s, args) => this.Close();
                    prijava.Show();
                    //TODO: unijeti u bazu
                    Korisnik korisnik = new Korisnik();
                    if(!validacija.ValidirajUnos(uiIme.Text) || !validacija.ValidirajUnos(uiPrezime.Text) || !validacija.ValidirajUnos(uiEmail.Text) || !validacija.ValidirajUnos(uiBrojTelefona.Text) || !validacija.ValidirajUnos(uiLozinka.Text))
                    {
                        throw new DataException("Polja ne smiju biti prazna!");
                    }
                    korisnik.ime = uiIme.Text;
                    korisnik.uloga_id = 0;
                    korisnik.korisnicko_ime = uiIme.Text.Substring(0, 1).ToLower() + uiPrezime.Text.ToLower();
                    korisnik.prezime = uiPrezime.Text;
                    korisnik.mail = uiEmail.Text;
                    if(!validacija.ValidirajEmail(korisnik.mail))
                    {
                        throw new DataException("E-mail adresa nije ispravna!");
                    }
                    korisnik.grad_id = (uiGrad.SelectedItem as Grad).id_grad;
                    korisnik.broj_telefona = uiBrojTelefona.Text;
                    korisnik.lozinka = uiLozinka.Text;
                    if (!validacija.ValidirajJakostLozinke(korisnik.lozinka))
                    {
                        throw new DataException("Lozinka mora imati najmanje 6 znakova");
                    }
                    korisnik.datum_registracije = DateTime.Now;
                    korisnik.raspoloziva_sredstva = 0;
                    entities.Korisnik.Add(korisnik);
                    entities.SaveChanges();
                    Close();
                }
                else
                {
                    throw new DataException("Lozinke se ne podudaraju!");
                }
            }
            catch(DataException ex)
            {
                MessageBox.Show(ex.Poruka);
            }
        }
    }
}
