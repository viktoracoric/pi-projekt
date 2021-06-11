﻿using System;
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
            var query = from c in entities.Clanstvo.Include(cla => cla.Korisnik).Include(cla => cla.Teretana)
                        where c.korisnik_id == prijavljeniKorisnik.id_korisnik select c;
            dgvMojeTeretane.DataSource = query.ToList();
        }

        private void btnRecenzija_Click(object sender, EventArgs e)
        {

        }
    }
}