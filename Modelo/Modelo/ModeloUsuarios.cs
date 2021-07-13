using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
	public static class ModeloUsuarios
    {
		public static void crearUsuario(Usuario nuevoUsuario)
        {			
			try
			{
				using (var entidad = new CONTACTOEntities())
				{
					entidad.Usuarios.Add(nuevoUsuario);
					entidad.SaveChanges();
				}
			}
			catch
			{
				throw new ArgumentNullException();
			}
		}
		public static Usuario buscarUsarioPorID(int idUsuario)
		{
			try
			{
				using (var entidad = new CONTACTOEntities())
				{
					var resultado = entidad.Usuarios.Where(usuarioBD => (usuarioBD.idUsuario == idUsuario)).FirstOrDefault();
					return resultado;
				}
			}
			catch
			{
				throw new ArgumentNullException();
			}
		}
		public static List<Usuario> buscarUsuariosPorString(string busqueda)
		{
			try
			{
				using (var entidad = new CONTACTOEntities())
				{
					List<Usuario> resultado = entidad.Usuarios.Where(usuario => (
							usuario.nombre.Contains(busqueda)
						 || usuario.sucursal.Contains(busqueda)
						 || usuario.correo.Contains(busqueda)
						 || usuario.celular.Contains(busqueda)
						 || usuario.telefono.Contains(busqueda))).ToList();
					return resultado;
				}
			}
			catch
			{
				throw new ArgumentNullException();
			}
		}
		public static void modificarUsuario(Usuario usuarioModificado)
		{
			try
			{
				using (var entidad = new CONTACTOEntities())
				{
					Usuario usuario = entidad.Usuarios.Find(usuarioModificado.idUsuario);
					usuario.nombre = usuarioModificado.nombre;
					usuario.sucursal = usuarioModificado.sucursal;
					usuario.correo = usuarioModificado.correo;
					usuario.celular = usuarioModificado.celular;
					usuario.telefono = usuarioModificado.telefono;
					usuario.tipoUsuario = usuarioModificado.tipoUsuario;
					usuario.contraseña = usuarioModificado.contraseña;
					entidad.SaveChanges();
				}
			}
			catch
			{
				throw new ArgumentNullException();
			}
		}
		public static void eliminarUsuarioPorID(int idUsuario)
		{
			try
			{
				Usuario usuario = buscarUsarioPorID(idUsuario);
				using (var entidad = new CONTACTOEntities())
				{
					entidad.Usuarios.Attach(usuario);
					entidad.Usuarios.Remove(usuario);
					entidad.SaveChanges();
				}
			}
			catch
			{
				throw new ArgumentNullException();
			}
		}
	}
}
