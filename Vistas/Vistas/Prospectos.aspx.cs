using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Modelo;

namespace Vistas
{
    public partial class Prospectos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            tablaContactos.DataSource = Modelo.ModeloContactos.buscarContactosPorString("Buena");
            tablaContactos.DataBind();
        }

        protected void btnMejorar_Command(object sender, CommandEventArgs e)
        {
            Session["idMejorarCliente"] = Convert.ToInt32(e.CommandArgument);
            Response.Redirect("AgregarCliente.aspx");
        }
    }
}