using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public partial class _Default : System.Web.UI.Page, ICallbackEventHandler 
{
    private string _callbackArgument;
    protected override void OnPreInit(EventArgs e)
    {
        ClientScript.GetCallbackEventReference(this, "", "", "", false);
        base.OnPreInit(e);
    }
    protected void Page_Load(object sender, EventArgs e)
    {
    }
    public string GetCallbackResult()
    {
        return _callbackArgument;
    }
    public void RaiseCallbackEvent(string eventArgument)
    {
        _callbackArgument = (Convert.ToInt32(eventArgument) * 2).ToString();
    }
}