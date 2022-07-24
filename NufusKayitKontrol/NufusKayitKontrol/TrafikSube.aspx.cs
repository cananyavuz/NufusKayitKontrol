using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NufusKayitKontrol
{
    public partial class TrafikSube : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            NufusGelenServis.NufusServisKutuphane  veri = new NufusGelenServis.NufusServisKutuphane();

            GridView1.DataSource = veri.TcKontrol(TextBox1.Text);
            GridView1.DataBind();
        }
    }
}