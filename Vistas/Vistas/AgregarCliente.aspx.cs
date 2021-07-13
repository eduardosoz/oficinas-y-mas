using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Modelo;

namespace Vistas
{
    public partial class AgregarCliente : System.Web.UI.Page
    {
        public int prospectoActual;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack && Convert.ToInt32(Session["idMejorarCliente"]) != 0)
            {
                prospectoActual = Convert.ToInt32(Session["idMejorarCliente"]);
                Contacto contacto = Modelo.ModeloContactos.buscarContactoPorID(Convert.ToInt32(Session["idMejorarCliente"]));
                txtNombre.Text = contacto.nombre;
                txtTelefono.Text = contacto.telefono;
                txtCorreo.Text = contacto.correo;
                txtDireccion.Text = contacto.direccion;
                txtObservaciones.Text = contacto.observaciones;
            }

        }

        protected void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            Cliente nuevoCliente = new Cliente();
            nuevoCliente.nombre = txtNombre.Text;
            nuevoCliente.telefono = txtTelefono.Text;
            nuevoCliente.correo = txtCorreo.Text;
            nuevoCliente.direccion = txtDireccion.Text;
            nuevoCliente.rfc = txtRfc.Text;
            nuevoCliente.direccionFiscal = txtDireccionFiscal.Text;
            nuevoCliente.condicionesDePago = txtCondiciones.Text;
            nuevoCliente.observaciones = txtObservaciones.Text;
            nuevoCliente.idVendedor = 1;
            nuevoCliente.fechaCreacion = DateTime.Now;
            nuevoCliente.ultimaVisita = DateTime.Now;

            Modelo.ModeloClientes.crearCliente(nuevoCliente);

            if (Convert.ToInt32(Session["idMejorarCliente"]) != 0)
            {
                Modelo.ModeloContactos.eliminarContactoPorID(Convert.ToInt32(Session["idMejorarCliente"]));
            }

            Response.Redirect("Clientes.aspx");
        }
    }
}