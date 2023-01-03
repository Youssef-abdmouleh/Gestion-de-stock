using System;
using System.Data;
using System.Data.SqlClient;

namespace ex1
{
    public class ProduitADO
    {
        public void Inserer(Produit P)
        {
            SqlCommand cmdaj = new SqlCommand("insert into Produit(Ref_Prod, Desig_Prod, Categ_Prod, PrixV_Prod, Qte_Stock) values (@Ref, @Desig, @Categ, @Prix, @Qte)", Connexion.cn);
            cmdaj.Parameters.AddWithValue("@Ref", P.Ref_Prod);
            cmdaj.Parameters.AddWithValue("@Desig", P.Desig_Prod);
            cmdaj.Parameters.AddWithValue("@Categ", P.Categ_Prod);
            cmdaj.Parameters.AddWithValue("@Prix", P.PrixV_Prod);
            cmdaj.Parameters.AddWithValue("@Qte", P.Qte_Stock);
            cmdaj.ExecuteNonQuery();
        }
        public static bool Existe_Produit(Int64 Ref)
        {
            SqlCommand cverif = new SqlCommand("select * from Produit where Ref_Prod = @Ref");

            cverif.Parameters.AddWithValue("@Ref", Ref);
            SqlDataReader drverif = cverif.ExecuteReader();
            if (drverif.HasRows == true)
            {
                drverif.Close();
                return true;
            }
            else
            {
                drverif.Close();
                return false;
            }
        }
        public void Supprimer(Int64 Ref)
        {
            SqlCommand cmdsupp = new SqlCommand("delete from Produit where Ref_Prod =@Ref", Connexion.cn);

            cmdsupp.Parameters.AddWithValue("@Ref", Ref);
            cmdsupp.ExecuteNonQuery();
        }
        public void Modifier(Produit P)
        {
            SqlCommand cmdmod = new SqlCommand("update Produit set Desig_Prod = @Desig, Categ_Prod = @Categ, PrixV_Prod = @Prix, Qte_Stock = @Qte where Ref_Prod = @Ref", Connexion.cn);
            cmdmod.Parameters.AddWithValue("@Desig", P.Desig_Prod);
            cmdmod.Parameters.AddWithValue("@Categ", P.Categ_Prod);
            cmdmod.Parameters.AddWithValue("@Prix", P.PrixV_Prod);
            cmdmod.Parameters.AddWithValue("@Qte", P.Qte_Stock);
            cmdmod.Parameters.AddWithValue("@Ref", P.Ref_Prod);
            cmdmod.ExecuteNonQuery();
        }
        public static DataTable Liste_Produit()
        {
            DataTable dtcl = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Produit", Connexion.cn);
            da.Fill(dtcl);
            return dtcl;
        }
        public static DataTable Liste_Prod_ParCateg(string Categ)
        {
            DataTable dtcl = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Produit where Categ_Prod = @Categ", Connexion.cn);
            da.SelectCommand.Parameters.AddWithValue("@Categ", Categ);
            da.Fill(dtcl);
            return dtcl;
        }
        public static DataTable Liste_Prod_ParRef(Int64 Ref)
        {
            DataTable dtcl = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Produit where Ref_Prod = @Ref", Connexion.cn);
            da.SelectCommand.Parameters.AddWithValue("@Ref", Ref);
            da.Fill(dtcl);
            return dtcl;
        }
        public static DataTable Liste_Prod_ParDesig(string Desig)
        {
            DataTable dtcl = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Produit where Desig_Prod like @Desig", Connexion.cn);
            da.SelectCommand.Parameters.AddWithValue("@Desig", Desig + '%');
            da.Fill(dtcl);
            return dtcl;
        }
    }
}
