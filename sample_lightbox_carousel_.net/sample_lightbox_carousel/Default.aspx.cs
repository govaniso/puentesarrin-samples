using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        List<Flower> Flowers = new List<Flower>();
        Flower oFlower1 = new Flower();
        oFlower1.Image = "image1.jpg";
        Flowers.Add(oFlower1);
        Flower oFlower2 = new Flower();
        oFlower2.Image = "image2.jpg";
        Flowers.Add(oFlower2);
        Flower oFlower3 = new Flower();
        oFlower3.Image = "image3.jpg";
        Flowers.Add(oFlower3);
        Flower oFlower4 = new Flower();
        oFlower4.Image = "image4.jpg";
        Flowers.Add(oFlower4);
        Flower oFlower5 = new Flower();
        oFlower5.Image = "image5.jpg";
        Flowers.Add(oFlower5);
        StringBuilder Cadena = new StringBuilder();
        Cadena.Append("<ul>");
        foreach (Flower item in Flowers)
        {
            Cadena.AppendFormat("<li><a href=\"photos/{0}\"><img src=\"photos/thumb_{0}\" width=\"75\" height=\"75\" /></a></li>", item.Image);
        }
        Cadena.Append("</ul>");
        carousel.InnerHtml = Cadena.ToString();
    }
}
