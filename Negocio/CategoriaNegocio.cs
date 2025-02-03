using Conexion;
using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class CategoriaNegocio
    {
		private ConexionDB con=new ConexionDB();
        public List<Categoria> listar()
        {
			List<Categoria> listaCategorias = new List<Categoria>();
			try
			{
				con.instruccionSQL("select Id,Descripcion from CATEGORIAS");
				con.leerDB();
				while (con.Lector.Read())
				{
					Categoria aux= new Categoria();
					aux.Id = (int)con.Lector["Id"];
					aux.Descripcion=(string)con.Lector["Descripcion"];
					listaCategorias.Add(aux);
				}
				return listaCategorias;
			}
			catch (Exception ex)
			{

				throw ex;
			}
			finally
			{
				con.cerrarConexion();
			}
        }
		public void insertar(Categoria categoria)
		{
			try
			{
                con.instruccionSQL("insert into CATEGORIAS(Descripcion) values(@descripcion)");
				con.setearComando("@descripcion",categoria.Descripcion);
				con.ejecutarAccion();
            }
			catch (Exception ex)
			{

				throw;
			}
			finally
			{
				con.cerrarConexion();
			}
			
		}
		public void editar(Categoria categoria)
		{
			try
			{
				con.instruccionSQL("update CATEGORIAS set Descripcion=@descripcion where Id=@id");
				con.setearComando("@descripcion",categoria.Descripcion);
				con.setearComando("@id",categoria.Id);
				con.ejecutarAccion();
			}
			catch (Exception ex)
			{

				throw;
			}
			finally
			{
				con.cerrarConexion();
			}
		}
		public void eliminar(Categoria categoria)
		{
			try
			{
				con.instruccionSQL("delete from CATEGORIAS where Id=@id");
				con.setearComando("@id",categoria.Id);
				con.ejecutarAccion();
			}
			catch (Exception ex)
			{

				throw;
			}
			finally
			{
				con.cerrarConexion();
			}
		}
		public bool existeCategoriaEnArticulo(Categoria categoria)
		{
			bool bandera = true;
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();
            List<Articulo> listaArticuloAux = articuloNegocio.listar();
			int cont = 0;
			try
			{
				foreach (Articulo aux in listaArticuloAux)
				{
					if (aux.Categoria.Id == categoria.Id)
						cont++;
				}
				
				if(cont==0)
					bandera = false;
				return bandera;
			}
			catch (Exception ex)
			{

				throw;
			}
			finally
			{
				con.cerrarConexion() ;
			}
		}
    }
}
