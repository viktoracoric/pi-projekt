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
        Validacija.Validacija validacija = new Validacija.Validacija();
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
            try
            {
                if (validacija.ValidirajBroj(uiCijena.Text) != -1)
                {
                    zahtjev.cijena_clanstva = validacija.ValidirajBroj(uiCijena.Text);
                }
                else
                {
                    throw new DataException("Cijena mora biti cijeli broj!");
                }
                if(validacija.ValidirajBroj(uiKapacitet.Text) != -1)
                {
                    zahtjev.kapacitet = validacija.ValidirajBroj(uiKapacitet.Text);
                }
                else
                {
                    throw new DataException("Kapacitet mora biti cijeli broj!");
                }
                if(validacija.ValidirajBroj(uiKvadratura.Text) != -1)
                {
                    zahtjev.kvadratura = validacija.ValidirajBroj(uiKvadratura.Text);
                }
                else
                {
                    throw new DataException("Kvadratura mora biti cijeli broj!");
                }
                entities.Zahtjev.Add(zahtjev);
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
