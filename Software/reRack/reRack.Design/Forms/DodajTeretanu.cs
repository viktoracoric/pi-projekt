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
                if (uiIme.Text != "" && uiKorisnik.Text != "" && uiGrad.Text != "" && uiAdresa.Text != "")
                {
                    Teretana teretana = new Teretana();
                    teretana.korisnik_id = (uiKorisnik.SelectedItem as Korisnik).id_korisnik;
                    teretana.adresa = uiAdresa.Text;
                    teretana.naziv = uiIme.Text;
                    teretana.grad_id = (uiGrad.SelectedItem as Grad).id_grad;
                    int broj;
                    if (Int32.TryParse(uiKapacitet.Value.ToString(), out broj))
                    {
                        teretana.kapacitet = broj;
                    }
                    else
                    {
                        uiKapacitet.Value = (int)Math.Round(uiKapacitet.Value);
                        throw new DataException("Vrijednost kapaciteta mora biti cijeli broj!");
                    }
                    if (Int32.TryParse(uiKvadratura.Value.ToString(), out broj))
                    {
                        teretana.kvadratura = broj;
                    }
                    else
                    {
                        uiKvadratura.Value = (int)Math.Round(uiKvadratura.Value);
                        throw new DataException("Vrijednost kvadrature mora biti cijeli broj!");
                    }
                    if (Int32.TryParse(uiCijena.Value.ToString(), out broj))
                    {
                        teretana.cijena_clanstva = broj;
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
