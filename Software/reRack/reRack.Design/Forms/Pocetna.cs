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
    public partial class Pocetna : Form
    {
        public Pocetna(int uloga)
        {
            InitializeComponent();
            if(uloga == 0)
            {
                uiActionUrediPodatkeTeretane.Hide();
                uiActionDodajVlasnika.Hide();
                uiActionDodajTeretanu.Hide();
            }
            if (uloga == 1)
            {
                uiActionDodajVlasnika.Hide();
                uiActionDodajTeretanu.Hide();
            }
        }
    }
}
