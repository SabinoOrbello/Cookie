using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class SecondPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Cookies["User"] != null && !string.IsNullOrEmpty(Request.Cookies["User"]["Username"]))
            {
                // Mostra l'username dalla cookie nella label
                lblUsername.Text = "Username: " + Request.Cookies["User"]["Username"];
            }
            else
            {
                // Reindirizza alla pagina di login se il cookie non è presente
                Response.Redirect("Default.aspx");
            }
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            // Cancella il cookie e reindirizza alla pagina di login
            Response.Cookies["User"].Expires = DateTime.Now.AddDays(-1);
            Response.Redirect("Default.aspx");
        }
    }
}