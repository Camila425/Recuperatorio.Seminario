using Recuperatorio.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recuperatorio.Datos.Recuperatorio
{
    public class RepositorioLibros
    {
        private readonly ConexionBD conexion;
        public RepositorioLibros()
        {
            conexion = new ConexionBD();
        }

        public List<Libros> GetLista()
        {
            List<Libros> Lista = new List<Libros>();
            try
            {
                using (var cn = conexion.AbrirConexion())
                {
                    var cadenaComando = "select LibroId,titulo,AutorId,Ejemplares,GeneroId,IdiomaId,EditorialId,Precio,RowVersion   from Libros";
                    var Comando = new SqlCommand(cadenaComando, cn);
                    using (var reader=Comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Libros libros = ConstruirLibro(reader);
                            Lista.Add(libros);
                        }
                    }

                }
                return Lista;
            }
            catch (Exception e)
            {

                throw new Exception("error en la tabla");
            }
        }

        private Libros ConstruirLibro(SqlDataReader reader)
        {
            return new Libros()
            {
                LibrosId = reader.GetInt32(0),
                Titulo = reader.GetString(1),
                AutorID = reader.GetInt32(2),
                Ejemplares = reader.GetInt32(3),
                GeneroId = reader.GetInt32(4),
                idiomasId = reader.GetInt32(5),
                EditorialId = reader.GetInt32(6),
                precio = reader.GetDecimal(7),
                RowVersion = (byte[])reader[8]
            };
        }
    }

}
