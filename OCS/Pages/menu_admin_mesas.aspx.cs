using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OCS.Pages
{
    public partial class menu_admin_mesas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnIngMesa_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Pages/ingresar_mesa.aspx", false);
        }

        protected void btnRegresar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Pages/menu_principal.aspx", false);
        }

        protected void bntHabDesMesa_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Pages/habilitar_deshabilitar_mesa.aspx", false);
        }
    }
}