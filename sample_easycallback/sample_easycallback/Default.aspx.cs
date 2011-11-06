using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EasyCallback;

namespace sample_easycallback
{
    public partial class Default : System.Web.UI.Page
    {
        protected override void OnPreInit(EventArgs e)
        {
            CallbackManager.Register(DoubleCallback);
            base.OnPreInit(e);
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        private string DoubleCallback(string argument)
        {
            return (Convert.ToInt32(argument) * 2).ToString();
        }
    }
}