using reRack.Design.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace reRack.Design
{
    public partial class Prijava : Form
    {
        Entities entities = new Entities();
        public Prijava()
        {
            InitializeComponent();
        }

        private void uxRegistracijaButton_Click(object sender, EventArgs e)
        {
            Registracija registracija = new Registracija();
            this.Hide();
            registracija.Closed += (s, args) => this.Close();
            registracija.Show();
        }

        private void uxPrijavaButton_Click(object sender, EventArgs e)
        {
            string korime = uiKorIme.Text;
            string lozinka = uiLozinka.Text;
            var prijava = from k in entities.Korisnik
                          where k.korisnicko_ime == korime && k.lozinka == lozinka
                          select k;
            if(prijava.Count() == 0)
            {
                MessageBox.Show("Neuspješna prijava!");
            }
            else
            {
                Pocetna pocetna = new Pocetna(prijava.First().uloga_id);
                this.Hide();
                pocetna.Closed += (s, args) => this.Close();
                pocetna.Show();
            }
        }
    }
}
