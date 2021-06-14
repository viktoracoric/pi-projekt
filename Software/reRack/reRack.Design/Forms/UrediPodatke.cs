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
    public partial class UrediPodatke : Form
    {
        private Korisnik prijavljeniKorisnik;
        Entities entities = new Entities();
        Validacija.Validacija validacija = new Validacija.Validacija();

        public UrediPodatke(Korisnik prijavljeniKorisnik)
        {
            InitializeComponent();
            this.prijavljeniKorisnik = prijavljeniKorisnik;
        }

        public void DohvatiPodatke()
        {
            uiImeEdit.Text = prijavljeniKorisnik.ime;
            uiPrezimeEdit.Text = prijavljeniKorisnik.prezime;
            uiEmailEdit.Text = prijavljeniKorisnik.mail;
            var gradovi = from g in entities.Grad
                          select g;
            uiGradEdit.DataSource = gradovi.ToList();
            uiGradEdit.SelectedIndex = uiGradEdit.FindStringExact(prijavljeniKorisnik.Grad.naziv);
            uiBrojTelefonaEdit.Text = prijavljeniKorisnik.broj_telefona;
            uiLozinkaEdit.Text = prijavljeniKorisnik.lozinka;
        }

        private void UrediPodatke_Load(object sender, EventArgs e)
        {
            DohvatiPodatke();
        }

        private void odustaniBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void potvrdiBtn_Click(object sender, EventArgs e)
        {
            var upit = from k in entities.Korisnik 
                       where k.id_korisnik == prijavljeniKorisnik.id_korisnik 
                       select k;
            var korisnik = upit.Single();
            try
            {
                if (!validacija.ValidirajUnos(uiImeEdit.Text) || !validacija.ValidirajUnos(uiPrezimeEdit.Text) || !validacija.ValidirajUnos(uiEmailEdit.Text) || !validacija.ValidirajUnos(uiBrojTelefonaEdit.Text) || !validacija.ValidirajUnos(uiLozinkaEdit.Text))
                {
                    throw new DataException("Polja ne smiju biti prazna!");
                }
                korisnik.ime = uiImeEdit.Text;
                korisnik.prezime = uiPrezimeEdit.Text;
                korisnik.mail = uiEmailEdit.Text;
                if (!validacija.ValidirajEmail(korisnik.mail))
                {
                    throw new DataException("E-mail adresa nije ispravna!");
                }
                korisnik.grad_id = (uiGradEdit.SelectedItem as Grad).id_grad;
                korisnik.broj_telefona = uiBrojTelefonaEdit.Text;
                korisnik.lozinka = uiLozinkaEdit.Text;
                if(!validacija.ValidirajJakostLozinke(uiLozinkaEdit.Text))
                {
                    throw new DataException("Lozinka mora imati najmanje 6 znakova");
                }
                entities.SaveChanges();
                Close();
            }
            catch(DataException ex)
            {
                MessageBox.Show(ex.Poruka);
            }
        }
    }
}
