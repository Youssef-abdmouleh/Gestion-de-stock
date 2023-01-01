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
    public partial class Fmenu : MetroFramework.Forms.MetroForm
    {
        public Fmenu()
        {
            InitializeComponent();
        }
         private void Fmenu_Load(object sender, EventArgs e)
         {
            Connexion.Ouvrir();
            MessageBox.Show(Connexion.cn.State.ToString());
         }

        private void ts_btn_cl_Click(object sender, EventArgs e)
        {
            FListe_Cl FCL= new FListe_Cl();
            FCL.MdiParent= this;
            FCL.Show();
        }
       
    }
}
