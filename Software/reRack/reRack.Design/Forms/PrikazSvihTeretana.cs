﻿using System;
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
            uiPopisTeretana.DataSource = query.ToList();
        }

        private void uiFilterCijena_ValueChanged(object sender, EventArgs e)
        {
            var query = from t in entities.Teretana
                        where t.cijena_clanstva < uiFilterCijena.Value && t.kvadratura < uiFilterKvadratura.Value
                        select t;
            uiPopisTeretana.DataSource = query.ToList();
        }

        private void uiFilterKvadratura_ValueChanged(object sender, EventArgs e)
        {
            var query = from t in entities.Teretana
                        where t.cijena_clanstva < uiFilterCijena.Value && t.kvadratura < uiFilterKvadratura.Value
                        select t;
            uiPopisTeretana.DataSource = query.ToList();
        }

        private void uiActionPosaljiZahtjev_Click(object sender, EventArgs e)
        {
            SlanjeZahtjev form = new SlanjeZahtjev(prijavljeniKorisnik);
            form.ShowDialog();
        }
    }
}
