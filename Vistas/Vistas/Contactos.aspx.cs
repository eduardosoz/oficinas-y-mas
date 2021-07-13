using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using Modelo;
using Controlador;

namespace Vistas
{
    public partial class Contactos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            tablaContactos.DataSource = Modelo.ModeloContactos.buscarContactosPorString("");
            tablaContactos.DataBind();            
        }

        protected void btnEditar_Command(object sender, CommandEventArgs e)
        {
            Session["idEditarContacto"] = Convert.ToInt32(e.CommandArgument);
            Response.Redirect("EditarContacto.aspx");
        }

        protected void btnEliminar_Command(object sender, CommandEventArgs e)
        {
            Session["idEliminarContacto"] = Convert.ToInt32(e.CommandArgument);
            ModeloContactos.eliminarContactoPorID(Convert.ToInt32(Session["idEliminarContacto"]));
            Response.Redirect("Contactos.aspx");
        }
    }
}