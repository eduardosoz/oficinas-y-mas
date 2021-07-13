using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Modelo;

namespace Vistas
{
    public partial class EditarCliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Convert.ToInt32(Session["idEditarCliente"]) != 0 && !IsPostBack)
            {
                Cliente cliente = Modelo.ModeloClientes.buscarClientePorID(Convert.ToInt32(Session["idEditarCliente"]));
                txtNombre.Text = cliente.nombre;
                txtTelefono.Text = cliente.telefono;
                txtCorreo.Text = cliente.correo;
                txtDireccion.Text = cliente.direccion;
                txtRfc.Text = cliente.rfc;
                txtDireccionFiscal.Text = cliente.direccionFiscal;
                txtCondiciones.Text = cliente.condicionesDePago;
                txtObservaciones.Text = cliente.observaciones;                
            }
        }

        protected void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            Cliente clienteModificado = new Cliente();
            clienteModificado.idCliente = Convert.ToInt32(Session["idEditarCliente"]);
            clienteModificado.nombre = txtNombre.Text;
            clienteModificado.telefono = txtTelefono.Text;
            clienteModificado.correo = txtCorreo.Text;
            clienteModificado.direccion = txtDireccion.Text;
            clienteModificado.rfc = txtRfc.Text;
            clienteModificado.direccionFiscal = txtDireccionFiscal.Text;
            clienteModificado.condicionesDePago = txtCondiciones.Text;
            clienteModificado.observaciones = txtObservaciones.Text;
            clienteModificado.idVendedor = 1;
            clienteModificado.fechaCreacion = DateTime.Now;
            clienteModificado.ultimaVisita = DateTime.Now;

            Modelo.ModeloClientes.modificarCliente(clienteModificado);

            Response.Redirect("Clientes.aspx");
        }
    }
}