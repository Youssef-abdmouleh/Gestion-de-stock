﻿using System.Data;
using System.Data.SqlClient;
namespace ex1
{
    public class Connexion
    {
        public static SqlConnection cn;

        public static string cnxstring = @"Data Source=(localdb)\ProjectModels;Initial Catalog=Magasine;Integrated Security=True";

        public static void Ouvrir()
        {
            cn = new SqlConnection();
            if (cn.State == ConnectionState.Closed)
            {
                cn.ConnectionString = cnxstring;
                cn.Open();
            }
        }
        public static void Fermer()
        {
            if (cn.State == ConnectionState.Open)
            {
                cn.Close();
            }
        }

    }
}
