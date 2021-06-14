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
    public partial class PrikazPopunjenosti : Form
    {
        private Teretana odabranaTeretana;
        Entities entities = new Entities();


        public PrikazPopunjenosti(Teretana odabranaTeretana)
        {
            InitializeComponent();
            this.odabranaTeretana = odabranaTeretana;
        }

        private void PrikazPopunjenosti_Load(object sender, EventArgs e)
        {
            uiNaziv.Text = odabranaTeretana.naziv;
            uiKapacitet.Text = odabranaTeretana.kapacitet.ToString();


            DohvatiPodatke();
        }

        private void uxActionZatvori_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DohvatiPodatke()
        {
            var sqlQ = from i in entities.VrInterval
                       select i;

            List < PopunjenostTermina > listaTermina = new List<PopunjenostTermina>();


            foreach (var item in sqlQ)
            {
                PopunjenostTermina termin = new PopunjenostTermina();

                termin.vrijeme_pocetak = item.vrijeme_pocetak;
                termin.vrijeme_kraj = item.vrijeme_kraj;

                DateTime datum = DateTime.Today;

                var upitDohvatID = (from i in entities.VrInterval
                                    where i.vrijeme_pocetak == item.vrijeme_pocetak && i.vrijeme_kraj == item.vrijeme_kraj
                                    select i).FirstOrDefault();

                double zbr = 0;

                for (int i = 1; i<8; i++)
                {
                    DateTime dateTime = datum.AddDays(-i);

                    var upit = from r in entities.Rezervacija
                               where r.teretana_id == odabranaTeretana.id_teretana && r.interval_id == upitDohvatID.id_interval
                               && r.datum.Value == dateTime
                               select r;

                    zbr = zbr + upit.Count();
                }

                double zbrZaokruzen = zbr / (7*odabranaTeretana.kapacitet) * 100;
                termin.PostotakPopunjenosti = Math.Round(zbrZaokruzen, 2) + "%";
                listaTermina.Add(termin);

            }

            popunjenostTerminaBindingSource.DataSource = null;
            popunjenostTerminaBindingSource.DataSource = listaTermina;
        }
    }
}
