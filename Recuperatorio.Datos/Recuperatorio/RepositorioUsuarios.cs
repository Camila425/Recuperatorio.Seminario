using Recuperatorio.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recuperatorio.Datos.Recuperatorio
{
    public class RepositorioUsuarios
    {
        private readonly ConexionBD conexion;
        public RepositorioUsuarios()
        {
            conexion = new ConexionBD();
        }

        public List<Usuarios> GetLista()
        {
            List<Usuarios> Lista = new List<Usuarios>();
            try
            {
                using (var cn = conexion.AbrirConexion())
                {
                    var cadenacomando = "select  SocioId,DNI,Apellido,Nombre,Direccion,Localidad,CodPostal,Telefono,FechaNac,Sancionado,RowVersion  from Usuarios";
                    var comando = new SqlCommand(cadenacomando, cn);
                    using (var Reader = comando.ExecuteReader())
                    {
                        while (Reader.Read())
                        {
                            Usuarios usuarios = ConstruirUsuario(Reader);
                            Lista.Add(usuarios);
                        }
                    }
                }
                return Lista;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        private Usuarios ConstruirUsuario(SqlDataReader reader)
        {
            return new Usuarios()
            {
                SociosId = reader.GetInt32(1),
                DNI = reader.GetInt32(1),
                Apellido = reader.GetString(2),
                Nombre = reader.GetString(3),
                Direccion = reader[4] != DBNull.Value ? reader.GetString(4) : string.Empty,
                Localidad = reader[5] != DBNull.Value ? reader.GetString(5) : string.Empty,
                CodPostal = reader[6] != DBNull.Value ? reader.GetInt32(6) : 0,
                Telefono = reader[7] != DBNull.Value ? reader.GetString(7) : string.Empty,
                FechaNac = reader[8] != DBNull.Value ? reader.GetDateTime(8) : DateTime.MinValue,
                Sancionado = reader.GetBoolean(9),
                RowVersion = (byte[])reader[10]
            };
        }
    }
}
