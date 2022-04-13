using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;

namespace BLL
{
    public class BolumlerBL
    {
        Helper a = Helper.ornek;
        public List<Bolumler> BolumListesiniGetir()//List tipinde return eden metod.
        {
            List<Bolumler> lst = new List<Bolumler>();//lstadında yeni nesne
            SqlDataReader dr = a.ExecuteReader("Select BolumID,BolumAd from Bolumler", null);
            while (dr.Read())
            {
                lst.Add(new Bolumler { BolumAd = dr["BolumAd"].ToString(), BolumID = Convert.ToInt32(dr["BolumID"]) });
            }
            dr.Close();
            return lst;
        }
    }
}
