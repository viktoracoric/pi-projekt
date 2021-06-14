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
    public partial class Uplata : Form
    {
        Entities entities = new Entities();
        private Korisnik prijavljeniKorisnik;

        public Uplata(Korisnik prijavljeniKorisnik)
        {
            InitializeComponent();
            var upit = from k in entities.Korisnik
                       where k.id_korisnik == prijavljeniKorisnik.id_korisnik
                       select k;
            this.prijavljeniKorisnik = upit.FirstOrDefault();
        }

        private void uiPotvrdi_Click(object sender, EventArgs e)
        { 
            var iban = uiIBAN.Text;
            var cvv = uiCVV.Text;
            var novac = uiNovci.Text;
            try
            {
                if (iban == "" && cvv == "" && novac == "")
                {
                    throw new DataException("Polja moraju biti popunjena");
                }
                else
                {
                    if (iban.Length != 20)
                    {
                        throw new DataException("IBAN mora imati 20 znakova");
                    }
                    else if (int.Parse(novac) < 0)
                    {
                        throw new DataException("Ne mozete unijeti negativan broj novca");
                    }
                    else
                    {
                        prijavljeniKorisnik.raspoloziva_sredstva += decimal.Parse(novac);
                        entities.SaveChanges();
                        MessageBox.Show("Uspješno ste uplatili novac");
                    }
                }
                
            }
            catch (DataException ex)
            {
                MessageBox.Show(ex.Poruka);
            }
        }

        private void uiOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
