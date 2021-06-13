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

            rezervacija.interval_id = (uiTermin.SelectedItem as VrInterval).id_interval;
            rezervacija.korisnik_id = prijavljeniKorisnik.id_korisnik;
            try
            {
                if(teretanaBindingSource.Current != null)
                {
                    rezervacija.teretana_id = (teretanaBindingSource.Current as Teretana).id_teretana;
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
            entities.Rezervacija.Add(rezervacija);
           // MessageBox.Show("Uspjeh");
            entities.SaveChanges();
        }

        private void uxActionPrikazMojihTermina_Click(object sender, EventArgs e)
        {
            MojiTermini mojiTermini = new MojiTermini(prijavljeniKorisnik);
            mojiTermini.ShowDialog();
        }

        private void teretanaBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            /*

            try
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

                var query = from t in entities.Rezervacija
                            where t.teretana_id == teretana.id_teretana && t.interval_id == interval
                            select t;

                uiObavjest.Text = "Teretana " + teretana.naziv + " ima ukupno " + teretana.kapacitet + " mjesta, a u terminu "
                                   + vrIntervals.First().vrijeme_pocetak + " - " + vrIntervals.First().vrijeme_kraj + " je trenutno zauzeto "
                                   + query.Count() + " mjesta";

            }
            catch (Exception ex)
            {

                MessageBox.Show( ex.Message);
            } */

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

            if(vrIntervals.Count() > 0)
            {
                var query = from t in entities.Rezervacija
                            where t.teretana_id == teretana.id_teretana && t.interval_id == interval
                            select t;

                uiObavjest.Text = "Teretana " + teretana.naziv + " ima ukupno " + teretana.kapacitet + " mjesta, a u terminu "
                                   + vrIntervals.First().vrijeme_pocetak + " - " + vrIntervals.First().vrijeme_kraj + " je trenutno zauzeto "
                                   + query.Count() + " mjesta";
            }
        }

        private void uxActionNazad_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
