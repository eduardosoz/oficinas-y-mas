using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Modelo;

namespace Vistas
{
    public partial class Clientes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["idMejorarCliente"] = 0;
            tablaClientes.DataSource = Modelo.ModeloClientes.buscarClientesPorString("");
            tablaClientes.DataBind();
        }

        protected void btnEliminar_Command(object sender, CommandEventArgs e)
        {
            Session["idEliminarCliente"] = Convert.ToInt32(e.CommandArgument);
            Modelo.ModeloClientes.eliminarClientePorID(Convert.ToInt32(Session["idEliminarCliente"]));
            Response.Redirect("Clientes.aspx");
        }

        protected void btnEditar_Command(object sender, CommandEventArgs e)
        {
            Session["idEditarCliente"] = Convert.ToInt32(e.CommandArgument);
            Response.Redirect("EditarCliente.aspx");
        }
    }
}