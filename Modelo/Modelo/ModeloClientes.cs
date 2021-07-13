using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
	public static class ModeloClientes
    {
		public static void crearCliente(Cliente nuevoCliente)
		{
			try
			{
				using (var entidad = new CONTACTOEntities())
				{
					nuevoCliente.fechaCreacion = DateTime.Now;
					nuevoCliente.ultimaVisita = DateTime.Now;
					entidad.Clientes.Add(nuevoCliente);
					entidad.SaveChanges();
				}
			}
			catch
			{
				throw new ArgumentNullException();
			}
		}
		public static Cliente buscarClientePorID(int idCliente)
		{
			try
			{
				using (var entidad = new CONTACTOEntities())
				{
					var resultado = entidad.Clientes.Where(clienteBD => (clienteBD.idCliente == idCliente)).FirstOrDefault();
					return resultado;
				}
			}
			catch
			{
				throw new ArgumentNullException();
			}
		}
		public static List<Cliente> buscarClientesPorString(string busqueda)
		{
			try
			{
				using (var entidad = new CONTACTOEntities())
				{
					List<Cliente> resultado = entidad.Clientes.Where(cliente => (
							cliente.nombre.Contains(busqueda)
						 || cliente.telefono.Contains(busqueda)
						 || cliente.correo.Contains(busqueda)
						 || cliente.direccion.Contains(busqueda)
						 || cliente.rfc.Contains(busqueda)
						 || cliente.direccionFiscal.Contains(busqueda)
						 || cliente.condicionesDePago.Contains(busqueda))).ToList();
                    if (resultado != null && !resultado.Any())
						foreach (var item in resultado)
						{
							agregarUltimaVisita(item);
						}
					return resultado;
				}
			}
			catch
			{
				throw new ArgumentNullException();
			}
		}
		public static void modificarCliente(Cliente clienteModificado)
		{
			try
			{
				using (var entidad = new CONTACTOEntities())
				{
					Cliente cliente = entidad.Clientes.Find(clienteModificado.idCliente);
					cliente.nombre = clienteModificado.nombre;
					cliente.telefono = clienteModificado.telefono;
					cliente.correo = clienteModificado.correo;
					cliente.direccion = clienteModificado.direccion;
					cliente.rfc = clienteModificado.rfc;
					cliente.direccionFiscal = clienteModificado.direccionFiscal;
					cliente.condicionesDePago = clienteModificado.condicionesDePago;
					cliente.observaciones = clienteModificado.observaciones;
					cliente.ultimaVisita = DateTime.Now;
					entidad.SaveChanges();
				}
			}
			catch
			{
				throw new ArgumentNullException();
			}
		}
		public static void eliminarClientePorID(int idCliente)
		{
			try
			{
				Cliente cliente = buscarClientePorID(idCliente);
				using (var entidad = new CONTACTOEntities())
				{
					entidad.Clientes.Attach(cliente);
					entidad.Clientes.Remove(cliente);
					entidad.SaveChanges();
				}
			}
			catch
			{
				throw new ArgumentNullException();
			}
		}
		public static List<Cliente> buscarClientesPorIDVendedor(int idVendedor)
		{
			try
			{
				using (var entidad = new CONTACTOEntities())
				{
					var resultado = entidad.Clientes.Where(clienteBD => (clienteBD.idVendedor == idVendedor)).ToList();
					if (resultado != null && !resultado.Any())
						foreach (var item in resultado)
						{
							agregarUltimaVisita(item);
						}
					return resultado;
				}
			}
			catch
			{
				throw new ArgumentNullException();
			}
		}

		public static void agregarUltimaVisita(Cliente cliente)
        {
			try
			{
				using (var entidad = new CONTACTOEntities())
				{
					Cliente clienteModificar = entidad.Clientes.Find(cliente.idCliente);
					clienteModificar.ultimaVisita = DateTime.Now;
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
