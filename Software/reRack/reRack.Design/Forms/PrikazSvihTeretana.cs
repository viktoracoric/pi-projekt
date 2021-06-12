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
    public partial class PrikazSvihTeretana : Form
    {
        Entities entities = new Entities();
        private  Korisnik prijavljeniKorisnik;

        public PrikazSvihTeretana(Korisnik prijavljeniKorisnik)
        {
            InitializeComponent();
            this.prijavljeniKorisnik = prijavljeniKorisnik;
        }

        private void PrikazSvihTeretana_Load(object sender, EventArgs e)
        {
            var query = from t in entities.Teretana
                        select t;
            teretanaBindingSource.DataSource = query.ToList();
        }

        private void uiFilterCijena_ValueChanged(object sender, EventArgs e)
        {
            var query = from t in entities.Teretana
                        where t.cijena_clanstva < uiFilterCijena.Value && t.kvadratura < uiFilterKvadratura.Value
                        select t;
            teretanaBindingSource.DataSource = query.ToList();
        }

        private void uiFilterKvadratura_ValueChanged(object sender, EventArgs e)
        {
            var query = from t in entities.Teretana
                        where t.cijena_clanstva < uiFilterCijena.Value && t.kvadratura < uiFilterKvadratura.Value
                        select t;
            teretanaBindingSource.DataSource = query.ToList();
        }

        private void uiActionPosaljiZahtjev_Click(object sender, EventArgs e)
        {
            SlanjeZahtjev form = new SlanjeZahtjev(prijavljeniKorisnik);
            form.ShowDialog();
        }

        private void uiActionNazad_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void uiActionPrikazTeretane_Click(object sender, EventArgs e)
        {
            Teretana teretana = teretanaBindingSource.Current as Teretana;
            DetaljanPrikazOTeretani detaljanPrikazOTeretani = new DetaljanPrikazOTeretani(teretana);
            detaljanPrikazOTeretani.ShowDialog();
        }

        private void uiUclaniSe_Click(object sender, EventArgs e)
        {
            try
            {
                Teretana teretana = teretanaBindingSource.Current as Teretana;
                Clanstvo clanstvo = new Clanstvo();
                if (prijavljeniKorisnik.raspoloziva_sredstva > teretana.cijena_clanstva)
                {
                    var upit = from k in entities.Korisnik
                               select k;
                    foreach (var item in upit)
                    {
                        if (item.id_korisnik == prijavljeniKorisnik.id_korisnik)
                        {
                            item.raspoloziva_sredstva = prijavljeniKorisnik.raspoloziva_sredstva - teretana.cijena_clanstva;
                        }
                    }
                    clanstvo.korisnik_id = prijavljeniKorisnik.id_korisnik;
                    clanstvo.teretana_id = teretana.id_teretana;
                    clanstvo.datum_pocetak = DateTime.Now;
                    clanstvo.datum_kraj = DateTime.Now.AddDays(30);

                    entities.Clanstvo.Add(clanstvo);
                    entities.SaveChanges();
                    MessageBox.Show("Cestitamo, uspjesno ste se uclanili u teretanu, vidimo se");
                }
                else
                {
                    MessageBox.Show("Nemate dovoljno raspolozivih sredstava");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Već ste član ove teretane");
            }

        }
    }
}
