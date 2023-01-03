using System;

namespace ex1
{
    public class Produit
    {
        public Int64 Ref_Prod { get; set; }
        public string Desig_Prod { get; set; }
        public string Categ_Prod { get; set; }
        public double PrixV_Prod { get; set; }
        public int Qte_Stock { get; set; }
        public Produit() { }
    }
}
