using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using Conexion;
using System.Data;

namespace Negocio
{
    public class ArticuloNegocio
    {
        

        private ConexionDB con=new ConexionDB();
        public void lecturaCamposArticulo(List<Articulo> lista)
        {
            
            while (con.Lector.Read())
            {
                Articulo aux = new Articulo();
                aux.Id = (int)con.Lector["Id"];
                aux.Codigo = (string)con.Lector["Codigo"];
                aux.Nombre = (string)con.Lector["Nombre"];
                aux.Descripcion = (string)con.Lector["Descripcion"];
                aux.Marca = new Marca();
                aux.Marca.Id = (int)con.Lector["IdMarca"];
                aux.Marca.Descripcion = (string)con.Lector["Marca"];
                aux.Categoria = new Categoria();
                aux.Categoria.Id = (int)con.Lector["IdCategoria"];
                aux.Categoria.Descripcion = (string)con.Lector["Categoria"];
                aux.ImagenUrl = (string)con.Lector["ImagenUrl"];
                aux.Precio = (decimal)con.Lector["Precio"];
                lista.Add(aux);
            }
        }
        public List<Articulo> listar()
        {
            List<Articulo> listaArticulos = new List<Articulo>();

            try
            {
                listaArticulos.Clear();
                con.instruccionSQL("select a.Id,a.Codigo,a.Nombre,a.Descripcion,m.Descripcion as 'Marca',c.Descripcion as 'Categoria',a.ImagenUrl,a.Precio,a.IdCategoria,a.IdMarca from ARTICULOS a,MARCAS m,CATEGORIAS c where a.IdCategoria=c.Id and a.IdMarca=m.Id");
                con.leerDB();
                lecturaCamposArticulo(listaArticulos);

                return listaArticulos;
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
        public void agregar(Articulo articulo)
        {
            try
            {
                //$"insert into ARTICULOS(Codigo,Nombre,Descripcion,IdMarca,IdCategoria,ImagenUrl,Precio) values('{articulo.Codigo}','{articulo.Nombre}','{articulo.Descripcion}',@idMarca,@idCategoria,'{articulo.ImagenUrl}',{articulo.Precio})"
                con.instruccionSQL($"insert into ARTICULOS(Codigo,Nombre,Descripcion,IdMarca,IdCategoria,ImagenUrl,Precio) values(@codigo,@nombre,@descripcion,@idMarca,@idCategoria,@imagenUrl,@precio)");
                con.setearComando("@codigo", articulo.Codigo);
                con.setearComando("@nombre", articulo.Nombre);
                con.setearComando("@descripcion", articulo.Descripcion);
                con.setearComando("@idMarca",articulo.Marca.Id);
                con.setearComando("@idCategoria",articulo.Categoria.Id);
                con.setearComando("@imagenUrl",articulo.ImagenUrl);
                con.setearComando("@precio",articulo.Precio);
                con.ejecutarAccion();

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
        public void editar(Articulo articulo)
        {
            try
            {
                con.instruccionSQL("update ARTICULOS set Codigo=@codigo,Nombre=@nombre,Descripcion=@descripcion,IdMarca=@idMarca,IdCategoria=@idCategoria,ImagenUrl=@imagenUrl,Precio=@precio  where Id=@id");
                con.setearComando("@codigo",articulo.Codigo);
                con.setearComando("@nombre",articulo.Nombre);
                con.setearComando("@descripcion",articulo.Descripcion);
                con.setearComando("@idMarca",articulo.Marca.Id);
                con.setearComando("@idCategoria",articulo.Categoria.Id);
                con.setearComando("@imagenUrl",articulo.ImagenUrl);
                con.setearComando("@precio",articulo.Precio);
                con.setearComando("@id",articulo.Id);
                con.ejecutarAccion();
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
        public void eliminar(Articulo articulo)
        {
            try
            {
                con.instruccionSQL("delete from ARTICULOS where Id=@id");
                con.setearComando("@id",articulo.Id);
                con.ejecutarAccion();
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

        public List<Articulo> FiltrarArticulos(string campo, string criterio, string filtro)
        {
            List<Articulo> lista = new List<Articulo>();

            try
            {
                string consulta = "SELECT a.Id, a.Codigo, a.Nombre, a.Descripcion, m.Descripcion as Marca, c.Descripcion as Categoria, a.ImagenUrl, a.Precio, a.IdCategoria, a.IdMarca FROM ARTICULOS a, MARCAS m, CATEGORIAS c WHERE a.IdCategoria = c.Id AND a.IdMarca = m.Id";

                    consulta += " AND ";

                    switch (campo)
                    {
                        case "Código":
                            switch (criterio)
                            {
                                case "Comienza con":
                                    consulta += "a.Codigo LIKE '"+filtro+"%'";
                                    break;
                                case "Termina con":
                                    consulta += "a.Codigo LIKE '%" + filtro + "'";
                                    break;
                                default: 
                                    consulta += "a.Codigo LIKE '%" + filtro + "%'";
                                    break;
                            }
                            break;
                        case "Nombre":
                            switch (criterio)
                            {
                                case "Comienza con":
                                    consulta += $"a.Nombre LIKE '{filtro}%'";
                                    break;
                                case "Termina con":
                                    consulta += $"a.Nombre LIKE '%{filtro}'";
                                    break;
                                default: 
                                    consulta += $"a.Nombre LIKE '%{filtro}%'";
                                    break;
                            }
                            break;

                        case "Precio":
                            switch (criterio)
                            {
                                case "Mayor a":
                                    consulta += $"a.Precio > {filtro}";
                                    break;
                                case "Menor a":
                                    consulta += $"a.Precio < {filtro}";
                                    break;
                                default:
                                    consulta += $"a.Precio = {filtro}";
                                    break;
                            }
                            break;

                        case "Categoría":
                            switch (criterio)
                            {
                                case "Comienza con":
                                    consulta += $"c.Descripcion LIKE '{filtro}%'";
                                    break;
                                case "Termina con":
                                    consulta += $"c.Descripcion LIKE '%{filtro}'";
                                    break;
                                default: 
                                    consulta += $"c.Descripcion LIKE '%{filtro}%'";
                                    break;
                            }
                            break;
                        case "Marca":
                            switch (criterio)
                            {
                                case "Comienza con":
                                    consulta += $"m.Descripcion LIKE '{filtro}%'";
                                    break;
                                case "Termina con":
                                    consulta += $"m.Descripcion LIKE '%{filtro}'";
                                    break;
                                default: 
                                    consulta += $"m.Descripcion LIKE '%{filtro}%'";
                                    break;
                            }
                            break;


                        default:
                            throw new ArgumentException("Campo no válido.");
                    }


                con.instruccionSQL(consulta);
                con.leerDB();
                lecturaCamposArticulo(lista);

                return lista;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al filtrar: " + ex.Message);
            }
            finally
            {
                con.cerrarConexion();
            }
        }
    }
}
