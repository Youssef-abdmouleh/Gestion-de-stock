using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex1
{
    public partial class search : Form
    {
        public search()
        {
            InitializeComponent();
        }
        public String met;


        private void Meth_Nom_CheckedChanged(object sender, EventArgs e)
        {
            if(Meth_Nom.Checked)
            {
                met = "nom";
            }
        }

        private void Meth_Pren_CheckedChanged(object sender, EventArgs e)
        {

            if (Meth_Pren.Checked)
            {
                met = "prenom";
            }
        }

        private void Meth_Vil_CheckedChanged(object sender, EventArgs e)
        {

            if (Meth_Vil.Checked)
            {
                met = "ville";
            }
        }

        private void Meth_Tel_CheckedChanged(object sender, EventArgs e)
        {

            if (Meth_Tel.Checked)
            {
                met = "telephone";
            }
        }
    }
}
