using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace reRack.Design.Forms
{
    public partial class MojeTeretane : Form
    {
        private Korisnik prijavljeniKorisnik;
        Teretana odabranaTeretana;

        Entities entities = new Entities();
        public MojeTeretane(Korisnik prijavljeniKorisnik)
        {
            InitializeComponent();
            this.prijavljeniKorisnik = prijavljeniKorisnik;
        }

        private void MojeTeretane_Load(object sender, EventArgs e)
        {
            List<Teretana> listaTeretana = new List<Teretana>();
            var query = from c in entities.Clanstvo.Include(cla => cla.Korisnik).Include(cla => cla.Teretana)
                        where c.korisnik_id == prijavljeniKorisnik.id_korisnik select c;
            foreach (var item in query)
            {
                listaTeretana.Add(item.Teretana);
            }
            teretanaBindingSource.DataSource = listaTeretana;

            uiTermin.DataSource = entities.VrInterval.ToList();
        }

        private void btnRecenzija_Click(object sender, EventArgs e)
        {

            Teretana teretana = teretanaBindingSource.Current as Teretana;
            OstavljanjeRecenzija recenzija = new OstavljanjeRecenzija(teretana, prijavljeniKorisnik);
            recenzija.ShowDialog();
        }

        private void uiRezerviraj_Click(object sender, EventArgs e)
        {
            Rezervacija rezervacija = new Rezervacija();

            //TODO ako je kapacitet popunjen da ne moze rezervirat taj termin
            // ako je kapacitet popunjen ne moze rezervirat

            rezervacija.interval_id = (uiTermin.SelectedItem as VrInterval).id_interval;
            rezervacija.korisnik_id = prijavljeniKorisnik.id_korisnik;
            rezervacija.datum = uiDatum.Value.Date;
            try
            {
                if (teretanaBindingSource.Current != null)
                {
                    rezervacija.teretana_id = (teretanaBindingSource.Current as Teretana).id_teretana;

                    var query = from r in entities.Rezervacija
                                where r.interval_id == rezervacija.interval_id && r.datum == rezervacija.datum 
                                && prijavljeniKorisnik.id_korisnik == r.korisnik_id
                                select r;

                    if (query.Count() > 0)
                    {
                        throw new DataException("Već imate rezervaciju u tom terminu!");
                    }

                    //upit.kapacitet 

                    int interval = uiTermin.SelectedIndex;

                    Teretana teretana = teretanaBindingSource.Current as Teretana;

                    var queryovski = from t in entities.Rezervacija
                                where t.teretana_id == teretana.id_teretana && t.interval_id == interval && t.datum == uiDatum.Value.Date
                                select t;

                    if (queryovski.Count() >= teretana.kapacitet)
                    {
                        throw new DataException("Kapaciteti teretane u ovom terminu su popunjeni!");
                    }
                    else
                    {
                        MessageBox.Show("Uspješna rezervacija!");
                    }

                }
                else
                {
                    throw new DataException("Nijedna teretana nije odabrana!");
                }
                entities.Rezervacija.Add(rezervacija);
                entities.SaveChanges();
            }
            catch (DataException ex)
            {
                MessageBox.Show(ex.Poruka);
            }
 
        }

        private void uxActionPrikazMojihTermina_Click(object sender, EventArgs e)
        {
            MojiTermini mojiTermini = new MojiTermini(prijavljeniKorisnik);
            mojiTermini.ShowDialog();
        }

        private void teretanaBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            DohvatiZauzetost();  
            odabranaTeretana = teretanaBindingSource.Current as Teretana;
        }

        private void uxActionNazad_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void uiDatum_ValueChanged(object sender, EventArgs e)
        {
            DohvatiZauzetost();
        }

        private void DohvatiZauzetost()
        {
            Teretana teretana = teretanaBindingSource.Current as Teretana;

            int interval = uiTermin.SelectedIndex;

            var upit = from v in entities.VrInterval
                       where v.id_interval == interval
                       select v;

            List<VrInterval> vrIntervals = new List<VrInterval>();

            foreach (var item in upit)
            {
                vrIntervals.Add(item);
            }

            if (vrIntervals.Count() > 0)
            {
                var query = from t in entities.Rezervacija
                            where t.teretana_id == teretana.id_teretana && t.interval_id == interval && t.datum == uiDatum.Value.Date
                            select t;

                uiObavjest.MaximumSize = new Size(500, 0);
                uiObavjest.AutoSize = true;

                uiObavjest.Text = "Teretana " + teretana.naziv + " ima ukupno " + teretana.kapacitet + " mjesta, a u terminu "
                                   + vrIntervals.First().vrijeme_pocetak + " - " + vrIntervals.First().vrijeme_kraj + " na datum: " + uiDatum.Value.Date.ToShortDateString()
                                   + " je trenutno zauzeto "
                                   + query.Count() + " mjesta";
            }
        }

        private void uiTermin_TextChanged(object sender, EventArgs e)
        {
            DohvatiZauzetost();
        }

        private void uxActionPopunjenost_Click(object sender, EventArgs e)
        {
            PrikazPopunjenosti prikazPopunjenosti = new PrikazPopunjenosti(odabranaTeretana);
            prikazPopunjenosti.ShowDialog();
        }
    }
}
