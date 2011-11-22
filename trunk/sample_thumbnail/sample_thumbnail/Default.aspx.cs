using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Text;
using System.Threading;

namespace sample_webpagebitmap
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                DirectoryInfo Carpeta = new DirectoryInfo(Server.MapPath("~/images/"));
                StringBuilder html = new StringBuilder();
                foreach (FileInfo Imagen in Carpeta.GetFiles("*.jpg"))
                {
                    html.AppendFormat(@"<li><img src=""images/{0}"" /></li>", Imagen.Name);
                }
                ulImagenes.InnerHtml = html.ToString();
                CargarImagenes();
            }
        }

        protected void btnCapturar_Click(object sender, EventArgs e)
        {
            Bitmap bmp = WebsiteThumbnail.GetThumbnail(txtUrl.Text, 900, 600, 300, 200);
            bmp.Save(Server.MapPath("~/images/" + txtUrl.Text + ".jpg"), System.Drawing.Imaging.ImageFormat.Jpeg);
            CargarImagenes();
        }

        private void CargarImagenes()
        {
            DirectoryInfo Carpeta = new DirectoryInfo(Server.MapPath("~/images/"));
            StringBuilder html = new StringBuilder();
            foreach (FileInfo Imagen in Carpeta.GetFiles("*.jpg"))
            {
                html.AppendFormat(@"<li><img src=""images/{0}"" /></li>", Imagen.Name);
            }
            ulImagenes.InnerHtml = html.ToString();
        }
    }
}
