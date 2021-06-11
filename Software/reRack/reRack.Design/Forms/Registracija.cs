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
    public partial class Registracija : Form
    {
        Entities entities = new Entities();
        public Registracija()
        {
            InitializeComponent();
        }

        private void uxActionRegistrirajSe_Click(object sender, EventArgs e)
        {

        private void Registracija_Load(object sender, EventArgs e)
        {
            List<Grad> grads = entities.Grad.ToList();
            uiGrad.DataSource = grads;
        }
    }
}
