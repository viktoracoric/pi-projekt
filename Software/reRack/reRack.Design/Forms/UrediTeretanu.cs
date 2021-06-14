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
        Validacija.Validacija validacija = new Validacija.Validacija();
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
            try
            {
                if (validacija.ValidirajOdabraniObjekt(uiIme.SelectedItem))
                {
                    if(!validacija.ValidirajUnos(uiAdresa.Text))
                    {
                        throw new DataException("Polja ne smiju biti prazna!");
                    }
                    int idTer = (uiIme.SelectedItem as Teretana).id_teretana;
                    var teretana = (from t in entities.Teretana
                                    where t.id_teretana == idTer
                                    select t).First();
                    teretana.korisnik_id = (uiKorisnik.SelectedItem as Korisnik).id_korisnik;
                    teretana.grad_id = (uiGrad.SelectedItem as Grad).id_grad;
                    teretana.adresa = uiAdresa.Text;
                    if (validacija.ValidirajBroj(uiKapacitet.Text) != -1)
                    {
                        teretana.kapacitet = validacija.ValidirajBroj(uiKapacitet.Text);
                    }
                    else
                    {
                        uiKapacitet.Value = (int)Math.Round(uiKapacitet.Value);
                        throw new DataException("Vrijednost kapaciteta mora biti cijeli broj!");
                    }
                    if (validacija.ValidirajBroj(uiKvadratura.Text) != -1)
                    {
                        teretana.kvadratura = validacija.ValidirajBroj(uiKvadratura.Text);
                    }
                    else
                    {
                        uiKvadratura.Value = (int)Math.Round(uiKvadratura.Value);
                        throw new DataException("Vrijednost kvadrature mora biti cijeli broj!");
                    }
                    if (validacija.ValidirajBroj(uiCijena.Text) != -1)
                    {
                        teretana.cijena_clanstva = validacija.ValidirajBroj(uiCijena.Text);
                    }
                    else
                    {
                        uiCijena.Value = (int)Math.Round(uiCijena.Value);
                        throw new DataException("Vrijednost cijene članstva mora biti cijeli broj!");
                    }
                    entities.SaveChanges();
                    MessageBox.Show("Izmjene uspješno spremljene!");
                    Close();
                }
                else
                {
                    throw new DataException("Nijedna teretana nije odabrana!");
                }
            }
            catch(DataException ex)
            {
                MessageBox.Show(ex.Poruka);
            }
            
        }

        private void uiObrisiTeretanu_Click(object sender, EventArgs e)
        {
            try
            {
                if(uiIme.SelectedItem != null)
                {
                    Teretana obrisiMe = (uiIme.SelectedItem as Teretana);
                    entities.Teretana.Remove(obrisiMe);
                    entities.SaveChanges();
                    MessageBox.Show("Teretana uspješno obrisana!");
                    Close();
                }
               else
                {
                    throw new DataException("Nijedna teretana nije odabrana!");
                }
            }
            catch (DataException ex)
            {
                MessageBox.Show(ex.Poruka);
            }
        }
    }
}
