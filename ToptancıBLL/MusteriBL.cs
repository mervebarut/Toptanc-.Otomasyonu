using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToptancıDAL;
using ToptancıMODELS;

namespace ToptancıBLL
{
    public class MusteriBL
    { Helper hlp = new Helper();
        public bool Kaydet(Musteri m)
        {
            try
            {
                Helper hlp = new Helper();
                SqlParameter[] p =  { new SqlParameter("@Ad", m.Ad), new SqlParameter("@Soyad", m.Soyad), new SqlParameter("@Telefon", m.Telefon), new SqlParameter("@MusteriId", m.Musteriid) };
                return hlp.ExecuteNonQuery("Insert into Musteriler values(@Ad,@Soyad,@Telefon)", p) > 0;
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

       
    }
}
