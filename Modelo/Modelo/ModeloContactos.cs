using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public static class ModeloContactos
    {
		public static void crearContacto(Contacto nuevoContacto)
		{
			try
			{
				using (var entidad = new CONTACTOEntities())
				{
					entidad.Contactos.Add(nuevoContacto);
					entidad.SaveChanges();
				}
			}
			catch
			{
				throw new ArgumentNullException();
			}
		}
		public static Contacto buscarContactoPorID(int idContacto)
		{
			try
			{
				using (var entidad = new CONTACTOEntities())
				{
					var resultado = entidad.Contactos.Where(contactoBD => (contactoBD.idContacto == idContacto)).FirstOrDefault();
					return resultado;
				}
			}
			catch
			{
				throw new ArgumentNullException();
			}
		}
		public static List<Contacto> buscarContactosPorString(string busqueda)
		{
			try
			{
				using (var entidad = new CONTACTOEntities())
				{
					List<Contacto> resultado = entidad.Contactos.Where(contacto => (
							contacto.nombre.Contains(busqueda)
						 || contacto.telefono.Contains(busqueda)
						 || contacto.correo.Contains(busqueda)
						 || contacto.empresa.Contains(busqueda)
						 || contacto.direccion.Contains(busqueda)
						 || contacto.valoracion.Contains(busqueda))).ToList();
					return resultado;
				}
			}
			catch
			{
				throw new ArgumentNullException();
			}
		}
		public static void modificarContacto(Contacto contactoModificado)
		{
			try
			{
				using (var entidad = new CONTACTOEntities())
				{
					Contacto contacto = entidad.Contactos.Find(contactoModificado.idContacto);
					contacto.nombre = contactoModificado.nombre;
					contacto.telefono = contactoModificado.telefono;
					contacto.correo = contactoModificado.correo;
					contacto.direccion = contactoModificado.direccion;
					contacto.valoracion = contactoModificado.valoracion;
					contacto.empresa = contactoModificado.empresa;
					contacto.observaciones = contactoModificado.observaciones;
					contacto.cotizacion = contactoModificado.cotizacion;
					entidad.SaveChanges();
				}
			}
			catch
			{
				throw new ArgumentNullException();
			}
		}
		public static void eliminarContactoPorID(int idContacto)
		{
			try
			{
				Contacto contacto = buscarContactoPorID(idContacto);
				using (var entidad = new CONTACTOEntities())
				{
					entidad.Contactos.Attach(contacto);
					entidad.Contactos.Remove(contacto);
					entidad.SaveChanges();
				}
			}
			catch
			{
				throw new ArgumentNullException();
			}
		}
		public static Contacto buscarContactoPorIDVendedor(int idVendedor)
		{
			try
			{
				using (var entidad = new CONTACTOEntities())
				{
					var resultado = entidad.Contactos.Where(contactoBD => (contactoBD.idVendedor == idVendedor)).FirstOrDefault();
					return resultado;
				}
			}
			catch
			{
				throw new ArgumentNullException();
			}
		}
	}
}
