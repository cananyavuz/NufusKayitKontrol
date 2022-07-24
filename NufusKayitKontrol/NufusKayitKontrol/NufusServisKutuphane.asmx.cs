using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;
using System.Data.SqlClient;

namespace NufusKayitKontrol
{
    /// <summary>
    /// Summary description for NufusServisKutuphane
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class NufusServisKutuphane : System.Web.Services.WebService
    {

        [WebMethod]
        public DataSet TcKontrol(string TcNo)
        {
            SqlConnection bgl = new SqlConnection("Data Source=CANAN-YAVUZ\\DEVELOPER;Initial Catalog=bkmDersDenemeleri;Integrated Security=True");

            string trafikBilgi = "select Ad, Soyad, TcNo, Cinsiyet from tblKisiBilgi where TcNo = '"+TcNo+"'";
            
            SqlDataAdapter sadp = new SqlDataAdapter(trafikBilgi,bgl);
            DataSet ds = new DataSet();

            sadp.Fill(ds);

            return ds;
        }
    }
}
