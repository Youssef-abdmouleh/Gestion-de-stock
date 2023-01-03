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
    public partial class FListe_Produit : MetroFramework.Forms.MetroForm
    {
        public FListe_Produit()
        {
            InitializeComponent();
        }
        public Produit P;
        int ind;

        private void pb_vide_Click(object sender, EventArgs e)
        {
            txt_ref.Clear();
            txt_des.Clear();
            cmd_cat.PromptText = "";
        }

        private void pb_ajou_prod_Click(object sender, EventArgs e)
        {

        }

        private void pb_recherche_prod_Click(object sender, EventArgs e)
        {
            if (txt_ref.Text == "" && txt_des.Text == "")
                MetroFramework.MetroMessageBox.Show(this, "\nVeuillez saisir la valeur à rechercher", "Attention !!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            if (txt_ref.Text != "")
                dg_produit.DataSource = ProduitADO.Liste_Prod_ParRef(Int64.Parse(txt_ref.Text));
            else
            if (txt_des.Text != "")
                dg_produit.DataSource = ProduitADO.Liste_Prod_ParDesig(txt_des.Text);
            dg_produit.Refresh();
            pb_vide_Click(sender, e);
        }

        private void pb_supprimer_prod_Click(object sender, EventArgs e)
        {
            if (txt_ref.Text == "" && txt_des.Text == "")
                MetroFramework.MetroMessageBox.Show(this, "\nVous devez sélectionner un Produit", "Attention !!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                DialogResult Rep = MetroFramework.MetroMessageBox.Show(this, "\n\nVoulez-vous Confirmer la Suppression", "Suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Rep == DialogResult.Yes)
                {
                    ProduitADO PA = new ProduitADO();
                    PA.Supprimer(Int64.Parse(txt_ref.Text));
                }
                pb_vide_Click(sender, e);
                dg_produit.DataSource = ProduitADO.Liste_Produit();
                dg_produit.Refresh();
            }
        }

        private void pb_modifier_prod_Click(object sender, EventArgs e)
        {
            if (txt_ref.Text == "" && txt_des.Text == "")
                MetroFramework.MetroMessageBox.Show(this, "\nVous devez sélectionner un Produit", "Attention !!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                FProduit Fp = new FProduit();
                Fp.Text = "Modification de Produit";
                Fp.TypeOp = 'M';
                Fp.PP = P;
                Fp.ShowDialog();
                dg_produit.DataSource = ProduitADO.Liste_Produit();
                dg_produit.Refresh();
            }
        }

        private void dg_produit_Click(object sender, EventArgs e)
        {
            ind = dg_produit.CurrentRow.Index;
            txt_ref.Text = dg_produit[0, ind].Value.ToString();
            txt_des.Text = dg_produit[1, ind].Value.ToString();
            cmd_cat.PromptText = dg_produit[2, ind].Value.ToString();
            P = new Produit
            {
                Ref_Prod = Int64.Parse(txt_ref.Text),
                Desig_Prod = txt_des.Text,
                Categ_Prod = cmd_cat.Text,
                PrixV_Prod = double.Parse(dg_produit[3, ind].Value.ToString()),
                Qte_Stock = int.Parse(dg_produit[4, ind].Value.ToString())
            };
        }

        private void cmd_cat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmd_cat.Text == "Tous")
                dg_produit.DataSource = ProduitADO.Liste_Produit();
            else
                dg_produit.DataSource = ProduitADO.Liste_Prod_ParCateg(cmd_cat.Text);
        }

        private void txt_des_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                dg_produit.DataSource = ProduitADO.Liste_Prod_ParDesig(txt_des.Text);
                dg_produit.Refresh();
            }
        }

        private void dg_produit_DoubleClick(object sender, EventArgs e)
        {
            ind = dg_produit.CurrentRow.Index;
            txt_ref.Text = dg_produit[0, ind].Value.ToString();
            txt_des.Text = dg_produit[1, ind].Value.ToString();
            cmd_cat.PromptText = dg_produit[2, ind].Value.ToString();
            P = new Produit
            {
                Ref_Prod = Int64.Parse(txt_des.Text),
                Desig_Prod = txt_des.Text,
                Categ_Prod = cmd_cat.Text,
                PrixV_Prod = double.Parse(dg_produit[3, ind].Value.ToString()),
                Qte_Stock = int.Parse(dg_produit[4, ind].Value.ToString())
            };
            this.Close();
        }
    }
}
