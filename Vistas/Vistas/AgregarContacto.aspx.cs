using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Modelo;

namespace Vistas
{
    public partial class AgregarContacto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnAgregarContacto_Click(object sender, EventArgs e)
        {
            Contacto nuevoContacto = new Contacto();
            nuevoContacto.nombre = txtNombre.Text;
            nuevoContacto.telefono = txtTelefono.Text;
            nuevoContacto.correo = txtCorreo.Text;
            nuevoContacto.empresa = txtEmpresa.Text;
            nuevoContacto.direccion = txtDireccion.Text;
            nuevoContacto.valoracion = dplValoracion.SelectedValue;
            nuevoContacto.cotizacion = txtCotizacion.Text;
            nuevoContacto.observaciones = txtObservaciones.Text;
            nuevoContacto.idVendedor = 1;

            Modelo.ModeloContactos.crearContacto(nuevoContacto);

            Response.Redirect("Contactos.aspx");
        }
    }
}