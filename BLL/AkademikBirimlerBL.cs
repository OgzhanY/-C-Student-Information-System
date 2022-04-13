using DAL;
using Model;
using System;
using System.Data;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class AkademikBirimlerBL
    {
        Helper a = Helper.ornek;
        public List<AkademikBirimler> AkademikListeGetir()//List tipinde return eden metod.
        {
            List<AkademikBirimler> lst = new List<AkademikBirimler>();//lstadında yeni nesne
            SqlDataReader dr = a.ExecuteReader("Select AkademikBirimID,Ad from AkademikBirimler", null);
            while (dr.Read())
            {
                lst.Add(new AkademikBirimler { Ad = dr["Ad"].ToString(), AkademikBirimID = Convert.ToInt32(dr["AkademikBirimID"]) });
            }
            dr.Close();
            return lst;
        }
        public bool AkademikBirimEkle(AkademikBirimler ab)
        {
            try
            {
                SqlParameter[] p = {

                new SqlParameter("@Ad", ab.Ad),
                

                };
                return a.ExecuteNonQuery("Insert into AkademikBirimler values (@Ad)", p) > 0;

            }
            catch (SqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool AkademikBirimSil(AkademikBirimler bm)
        {
            try
            {
                SqlParameter[] p = {

                new SqlParameter("@AkademikBirimID", bm.AkademikBirimID)

                };
                return a.ExecuteNonQuery("Delete from AkademikBirimler where AkademikBirimID=@AkademikBirimID", p) > 0;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool AkademikBirimGuncelleme(AkademikBirimler bm)
        {
            try
            {
                SqlParameter[] p = {
                    new SqlParameter("@Ad", bm.Ad),
                    new SqlParameter("@AkademikBirimID",bm.AkademikBirimID)
                };

                return a.ExecuteNonQuery("Update AkademikBirimler set Ad = @Ad where AkademikBirimID = @AkademikBirimID", p) > 0;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable AbTablosuGetir()
        {
            return a.MyDataTable("Select AkademikBirimID,Ad from AkademikBirimler", null);
        }
    }
}
