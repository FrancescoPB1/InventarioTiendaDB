using Conexion;
using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class MarcaNegocio
    {
        private ConexionDB con=new ConexionDB();

        public List<Marca> listar()
        {
            List<Marca> listaMarca = new List<Marca>();
            try
            {
                con.instruccionSQL("select Id,Descripcion from MARCAS");
                con.leerDB();
                while (con.Lector.Read())
                {
                    Marca aux = new Marca();
                    aux.Id = (int)con.Lector["Id"];
                    aux.Descripcion = (string)con.Lector["Descripcion"];
                    listaMarca.Add(aux);
                }
                

                return listaMarca;
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
        public void insertar(Marca marca)
        {
            try
            {
                con.instruccionSQL("insert into MARCAS(Descripcion) values(@descripcion)");
                con.setearComando("@descripcion",marca.Descripcion);
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
        public void editar(Marca marca)
        {
            try
            {
                con.instruccionSQL("update MARCAS set Descripcion=@descripcion where Id=@id");
                con.setearComando("@descripcion",marca.Descripcion);
                con.setearComando("@id",marca.Id);
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
        public bool existeMacaEnArticulos(Marca marca)
        {
            try
            {
                ArticuloNegocio articuloNegocio = new ArticuloNegocio();
                List<Articulo> listaArticulos= new List<Articulo>();
                listaArticulos = articuloNegocio.listar();
                bool bandera=false;
                
                foreach (Articulo aux in listaArticulos)
                {
                    if (aux.Marca.Id == marca.Id)
                    {
                        bandera = true;
                        break;
                    }
                        
                }
                return bandera;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                con.cerrarConexion();
            }
        }

        public void eliminar(Marca marca)
        {
            try
            {
                con.instruccionSQL("delete from MARCAS where Id=@id");
                con.setearComando("@id",marca.Id);
                con.ejecutarAccion();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                con.cerrarConexion();
            }
        }
    }
}
