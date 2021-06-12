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
    public partial class DetaljanPrikazOTeretani : Form
    {
        private Teretana teretana;
        Entities entities = new Entities();
        public DetaljanPrikazOTeretani(Teretana teretana)
        {
            InitializeComponent();
            this.teretana = teretana;
            uiNaziv.Text = teretana.naziv;
            uiAdresa.Text = teretana.adresa;
            uiVlasnik.Text = teretana.Korisnik.ToString();
            uiGrad.Text = teretana.Grad.ToString();
            uiKapacitet.Text = teretana.kapacitet.ToString();
            uiKvadratura.Text = teretana.kvadratura.ToString();
            uiCijena.Text = teretana.cijena_clanstva.ToString();
            var q = from r in entities.Recenzija
                    where r.teretana_id == teretana.id_teretana
                    select r;
            recenzijaBindingSource.DataSource = q.ToList();
        }

        private void DetaljanPrikazOTeretani_Load(object sender, EventArgs e)
        {
           
        }
    }
}
