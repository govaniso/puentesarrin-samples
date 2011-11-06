using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using sample_datatables.BusinessEntities;
using sample_datatables.BusinessLogic;

using System.Data;

namespace sample_datatables_.net
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Employees.InnerHtml = GetHtml(new BLEmployee().SelectAllEmployees());
        }
        private string GetHtml(List<BEEmployee> Employees)
        {
            StringBuilder Table = new StringBuilder();
            Table.Append("<table id=\"tableemployees\">");
            Table.Append("<thead><tr><th>ID</th><th>Apellidos</th><th>Nombres</th><th>&nbsp;</th></tr></thead>");
            Table.Append("<tbody>");
            foreach (BEEmployee Employee in Employees)
            {
                Table.Append("<tr>");
                Table.AppendFormat("<td>{0}</td>", Employee.EmployeeID);
                Table.AppendFormat("<td>{0}</td>", Employee.LastName);
                Table.AppendFormat("<td>{0}</td>", Employee.FirstName);
                Table.AppendFormat("<td><a href=\"editemployee.aspx?id={0}\">Editar</a></td>", Employee.EmployeeID);
                Table.Append("</tr>");
            }
            Table.Append("</tbody>");
            Table.Append("</table>");
            return Table.ToString();
        }
    }
}
