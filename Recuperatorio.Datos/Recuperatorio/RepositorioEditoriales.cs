using Recuperatorio.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recuperatorio.Datos.Recuperatorio
{
    public class RepositorioEditoriales
    {
        private readonly ConexionBD conexion;
        public RepositorioEditoriales()
        {
            conexion = new ConexionBD();
        }

        public List<Editoriales> GetLista()
        {
            List<Editoriales> lista = new List<Editoriales>();
            try
            {
                using (var cn=conexion.AbrirConexion())
                {
                    var cadenacomando = "select EditorialId,NombreEditorial,RowVersion from Editoriales";
                    var comando = new SqlCommand(cadenacomando, cn);
                    using (var reader=comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Editoriales editoriales = ConstruirEditorial(reader);
                            lista.Add(editoriales);
                        }
                    }
                }
                return lista;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public int Agregar(Editoriales editoriales)
        {
            int Registrosafectados = 0;
            try
            {
                using (var cn=conexion.AbrirConexion())
                {
                    var cadenacomando = "INSERT INTO Editoriales(NombreEditorial) Values (@Nom)";
                    var comando = new SqlCommand(cadenacomando, cn);
                    comando.Parameters.AddWithValue("@Nom", editoriales.NombreEditorial);
                    Registrosafectados = comando.ExecuteNonQuery();
                }
                return Registrosafectados;
            }
            catch (Exception Exception)
            {
                throw new Exception(Exception.Message);
            }
        }

        private Editoriales ConstruirEditorial(SqlDataReader reader)
        {
            return new Editoriales()
            {
                EditorialId = reader.GetInt32(0),
                NombreEditorial = reader.GetString(1),
                Rowversion = (byte[])reader[2]
            };
        }
    }
}
