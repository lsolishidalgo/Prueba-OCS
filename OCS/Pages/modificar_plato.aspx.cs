using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OCS.Pages
{
    public partial class modificar_plato : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void bntRegresar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Pages/menu_admin_carta.aspx", false);
        }
    }
}