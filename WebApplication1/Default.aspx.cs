using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class _Default : Page
    {
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            // ottieni username inserito dall'utente
            string username = txtUsername.Text;

            //Crea un coockie e memorizza l'username
            Response.Cookies["User"]["Username"] = username;
            Response.Cookies["User"].Expires = DateTime.Now.AddMinutes(30);

            //Reinderizza alla seconda pagina
            Response.Redirect("SecondPage.aspx");
        }
    }
}