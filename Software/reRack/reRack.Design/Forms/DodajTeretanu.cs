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
        Validacija.Validacija validacija = new Validacija.Validacija();
        public DodajTeretanu(Zahtjev zahtjev)
        {
            InitializeComponent();

            uiIme.Text = zahtjev.naziv;
            uiGrad.DataSource = entities.Grad.ToList();
            uiKorisnik.DataSource = entities.Korisnik.ToList();
            uiKorisnik.Text = zahtjev.Korisnik.korisnicko_ime;
            uiGrad.Text = zahtjev.Grad.naziv;
            uiAdresa.Text = zahtjev.adresa;
            uiKapacitet.Value = zahtjev.kapacitet;
            uiCijena.Value = zahtjev.cijena_clanstva;
            uiKvadratura.Value = zahtjev.kvadratura;
            var q = (from x in entities.Zahtjev where x.id_zahtjev == zahtjev.id_zahtjev select x).First();
            entities.Zahtjev.Remove(q);
        }
        public DodajTeretanu()
        {
            InitializeComponent();
            uiGrad.DataSource = entities.Grad.ToList();
            uiKorisnik.DataSource = entities.Korisnik.ToList();
        }

        private void DodajTeretanu_Load(object sender, EventArgs e)
        {
        }

        private void uxActionOdustani_Click(object sender, EventArgs e)
        {
            entities.SaveChanges();
            Close();
        }

        private void uxActionSpremi_Click(object sender, EventArgs e)
        {
            try
            {
                if(validacija.ValidirajUnos(uiAdresa.Text) && validacija.ValidirajUnos(uiIme.Text) && validacija.ValidirajUnos(uiGrad.Text) && validacija.ValidirajUnos(uiKorisnik.Text))
                {
                    Teretana teretana = new Teretana();
                    teretana.korisnik_id = (uiKorisnik.SelectedItem as Korisnik).id_korisnik;
                    teretana.adresa = uiAdresa.Text;
                    teretana.naziv = uiIme.Text;
                    teretana.grad_id = (uiGrad.SelectedItem as Grad).id_grad;
                    if (validacija.ValidirajBroj(uiKapacitet.Value.ToString()) != -1)
                    {
                        teretana.kapacitet = validacija.ValidirajBroj(uiKapacitet.Value.ToString());
                    }
                    else
                    {
                        uiKapacitet.Value = (int)Math.Round(uiKapacitet.Value);
                        throw new DataException("Vrijednost kapaciteta mora biti cijeli broj!");
                    }
                    if (validacija.ValidirajBroj(uiKvadratura.Value.ToString()) != -1)
                    {
                        teretana.kvadratura = validacija.ValidirajBroj(uiKvadratura.Value.ToString());
                    }
                    else
                    {
                        uiKvadratura.Value = (int)Math.Round(uiKvadratura.Value);
                        throw new DataException("Vrijednost kvadrature mora biti cijeli broj!");
                    }
                    if (validacija.ValidirajBroj(uiCijena.Value.ToString()) != -1)
                    {
                        teretana.cijena_clanstva = validacija.ValidirajBroj(uiCijena.Value.ToString());
                    }
                    else
                    {
                        uiCijena.Value = (int)Math.Round(uiCijena.Value);
                        throw new DataException("Vrijednost cijene članstva mora biti cijeli broj!");
                    }
                    entities.Teretana.Add(teretana);

                    entities.SaveChanges();
                    Close();
                }
                else
                {
                    throw new DataException("Polja ne smiju biti prazna!");
                }
            }
            catch(DataException ex)
            {
                MessageBox.Show(ex.Poruka);
            }
        }
    }
}
