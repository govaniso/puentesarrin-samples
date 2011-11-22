using System;
using System.Collections.Generic;
using System.Text;
using GetSiteThumbnail;
using System.Drawing;
using System.Drawing.Imaging;

namespace sample_webpagebitmap
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            WebPageBitmap webBitmap = new WebPageBitmap("http://google.com.pe", 800, 600, false, 10000);
            if (webBitmap.IsOk)
            {
                webBitmap.Fetch();
                Bitmap thumbnail = webBitmap.GetBitmap(800, 600);
                thumbnail.Save("captura.jpg", ImageFormat.Jpeg);
                thumbnail.Dispose();
            }
        }
    }
}
