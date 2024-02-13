using System;
using System.Web;

namespace Coockies
{
    public partial class Result : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Cookies["Utente"]["Username"] != "")
            {
                Label1.Text = "Username: " + Request.Cookies["Utente"]["Username"];
            }
            else
            {
                Response.Redirect("Default");
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            HttpCookie cookie = new HttpCookie("Utente");
            cookie.Expires = DateTime.Now.AddDays(-1);
            Response.Cookies.Add(cookie);
            Response.Redirect("Default");
        }
    }
}