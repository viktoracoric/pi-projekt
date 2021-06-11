using reRack.Design.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace reRack.Design
{
    public partial class uiPrijavaForm : Form
    {
        public uiPrijavaForm()
        {
            InitializeComponent();
        }

        private void uxRegistracijaButton_Click(object sender, EventArgs e)
        {
            Registracija registracija = new Registracija();
            registracija.ShowDialog();
        }

        private void uxPrijavaButton_Click(object sender, EventArgs e)
        {
            string korime = uiKorIme.Text;
            string lozinka = uiLozinka.Text;
        }
    }
}
