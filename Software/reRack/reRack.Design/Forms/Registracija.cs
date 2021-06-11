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
            string ime = uiIme.Text;
            string prezime = uiPrezime.Text;
            string email = uiEmail.Text;
            string grad = uiGrad.SelectedItem.ToString();
            string brojTelefona = uiBrojTelefona.Text;
            string lozinka = uiLozinka.Text;
            string potvrdaLozinke = uiPotvrdaLozinke.Text;
            if(lozinka == potvrdaLozinke)
            {
                Prijava prijava = new Prijava();
                this.Hide();
                prijava.Closed += (s, args) => this.Close();
                prijava.Show();
                //TODO: unijeti u bazu
            }
            else
            {
                MessageBox.Show("Lozinke se ne podudaraju");
            }
        }
    }
}
