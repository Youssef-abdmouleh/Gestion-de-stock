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
    public partial class FListe_Cl : MetroFramework.Forms.MetroForm
    {
        public FListe_Cl()
        {
            InitializeComponent();
        }

        private void FListe_Cl_Load(object sender, EventArgs e)
        {
            Dg_Clt.DataSource = ClientADO.Liste_Client();
        }

        Client c = new Client();
        
        ClientADO CAdo =new ClientADO();
        private void ajouter_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(Txt_CIN.Text))
                if (!ClientADO.Existe_Client(Convert.ToInt64(Txt_CIN.Text))) { 
                    c.Cin_Cl =Convert.ToInt64(Txt_CIN.Text);
                    c.Ville_Cl = Txt_VIL.Text;
                    c.Nom_Cl= Txt_NOM.Text;
                    c.Tel_Cl = Convert.ToInt64(Txt_TEL.Text);
                    c.Pren_Cl=Txt_PREN.Text;
                }else
                    MessageBox.Show("Client non existe");
            else
                MessageBox.Show("donner un Client pour rechercher");
                
            CAdo.Inserer(c);
            
            FListe_Cl_Load(sender, e);

        }

        private void Rechercher_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(Txt_CIN.Text))
                if (ClientADO.Existe_Client(Convert.ToInt64(Txt_CIN.Text)))
                {
                    DataTable client = new DataTable();
                    client = ClientADO.Liste_Client(Convert.ToInt64(Txt_CIN.Text));
                    Txt_NOM.Text = client.Rows[0][1].ToString();
                    Txt_PREN.Text = client.Rows[0][2].ToString();
                    Txt_VIL.Text = client.Rows[0][3].ToString();
                    Txt_TEL.Text = client.Rows[0][4].ToString();
                } else
                    MessageBox.Show("Client non existe");
            else if (!String.IsNullOrEmpty(Txt_NOM.Text))
            {
                search f3 = new search();
                f3.Show();
                switch (f3.met) {
                    case "nom": 
                        Dg_Clt.DataSource = ClientADO.Liste_Client(Txt_NOM.Text);
                        break;
                    case "prenom":
                        Dg_Clt.DataSource = ClientADO.Liste_Client(Txt_PREN.Text);
                        break;
                    case "ville":
                        Dg_Clt.DataSource = ClientADO.Liste_Client(Txt_VIL.Text);
                        break;
                    case "telephone":
                        Dg_Clt.DataSource = ClientADO.Liste_Client(Txt_TEL.Text);
                        break;



                }
            }
            else
            {
                MessageBox.Show("donner un Client pour rechercher");
                FListe_Cl_Load(sender, e);

            }

        }

        private void Supprimer_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(Txt_CIN.Text))
                if (ClientADO.Existe_Client(Convert.ToInt64(Txt_CIN.Text)))
                    CAdo.Supprimer(Convert.ToInt64(Txt_CIN.Text));
                else
                    MessageBox.Show("Client non existe");
            else
                MessageBox.Show("donner un Client pour Supprimer");
            FListe_Cl_Load(sender, e);
        }

        private void Modifer_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(Txt_CIN.Text))
                if (ClientADO.Existe_Client(Convert.ToInt64(Txt_CIN.Text)))
                {
                    c.Cin_Cl = Convert.ToInt32(Txt_CIN.Text);
                    c.Nom_Cl = Txt_NOM.Text;
                    c.Pren_Cl = Txt_PREN.Text;
                    c.Ville_Cl = Txt_VIL.Text;
                    c.Tel_Cl = Convert.ToInt32(Txt_TEL.Text);
                    CAdo.Modifier(c);
                }
                else
                    MessageBox.Show("Client non existe");
            else 
                MessageBox.Show("Nom du client non existe");


            FListe_Cl_Load(sender, e);
        }

        private void Dg_Clt_DoubleClick(object sender, EventArgs e)
        {
            int i = Dg_Clt.CurrentRow.Index;
            Txt_CIN.Text = Dg_Clt.Rows[i].Cells[0].Value.ToString();
            Txt_NOM.Text = Dg_Clt.Rows[i].Cells[1].Value.ToString();
            Txt_PREN.Text = Dg_Clt.Rows[i].Cells[2].Value.ToString();
            Txt_TEL.Text = Dg_Clt.Rows[i].Cells[3].Value.ToString();
            Txt_VIL.Text = Dg_Clt.Rows[i].Cells[4].Value.ToString();
        }

       
    }
}
