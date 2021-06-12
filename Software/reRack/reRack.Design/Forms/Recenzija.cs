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
    public partial class Recenzija : Form
    {
        public Teretana selektiranaTeretana;

        public Recenzija(Teretana selektiranaTeretana)
        {
            InitializeComponent();
            this.selektiranaTeretana = selektiranaTeretana;
        }

        private void Recenzija_Load(object sender, EventArgs e)
        {
            uiTeretana.Text = selektiranaTeretana.naziv;
        }
    }
}
