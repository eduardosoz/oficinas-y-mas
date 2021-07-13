using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Modelo;

namespace Vistas
{
    public partial class EditarContacto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Convert.ToInt32(Session["idEditarContacto"]) != 0 && !IsPostBack)
            {
                Contacto contacto = Modelo.ModeloContactos.buscarContactoPorID(Convert.ToInt32(Session["idEditarContacto"]));
                txtNombre.Text = contacto.nombre;
                txtTelefono.Text = contacto.telefono;
                txtCorreo.Text = contacto.correo;
                txtEmpresa.Text = contacto.empresa;
                txtDireccion.Text = contacto.direccion;
                txtCotizacion.Text = contacto.cotizacion;
                txtObservaciones.Text = contacto.observaciones;
                dplValoracion.SelectedValue = contacto.valoracion;
            }
                
        }

        protected void btnEditarContacto_Click(object sender, EventArgs e)
        {
            Contacto contactoEditado = new Contacto();
            contactoEditado.idContacto = Convert.ToInt32(Session["idEditarContacto"]);            
            contactoEditado.telefono = txtTelefono.Text;
            contactoEditado.correo = txtCorreo.Text;
            contactoEditado.empresa = txtEmpresa.Text;
            contactoEditado.direccion = txtDireccion.Text;
            contactoEditado.valoracion = dplValoracion.SelectedValue;
            contactoEditado.cotizacion = txtCotizacion.Text;
            contactoEditado.observaciones = txtObservaciones.Text;
            contactoEditado.idVendedor = 1;
            contactoEditado.nombre = txtNombre.Text;
            Modelo.ModeloContactos.modificarContacto(contactoEditado);
            Response.Redirect("Contactos.aspx");
        }
    }
}