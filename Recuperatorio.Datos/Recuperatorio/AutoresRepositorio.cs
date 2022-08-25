using Recuperatorio.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recuperatorio.Datos.Recuperatorio
{
    public class AutoresRepositorio
    {
        private readonly ConexionBD conexion;
        public AutoresRepositorio()
        {
            conexion = new ConexionBD();
        }

        public List<Autores> GetLista()
        {
            List<Autores> Lista = new List<Autores>();
            //try
            //{
                using (var cn=conexion.AbrirConexion())
                {
                    var CadenaComando = "select  AutorId,Apellido,Nombre,Nacionalidad,RowVersion from autores";
                    var comando = new SqlCommand(CadenaComando, cn);
                    using (var Reader=comando.ExecuteReader())
                    {
                        while (Reader.Read())
                        {
                            Autores autores = ConstruirAutores(Reader);
                            Lista.Add(autores);
                        }
                    }
                }
                return Lista;
            //}
            //catch (Exception)
            //{

            //    throw new Exception("Error en la tabla Autor");
            //}
        }

        private Autores ConstruirAutores(SqlDataReader reader)
        {
            return new Autores()
            {
                AutorId=reader.GetInt32(0),
                Apellido=reader.GetString(1),
                Nombre=reader[2] != DBNull.Value ? reader.GetString(2) : string.Empty,
                nacionalidad=reader[3] != DBNull.Value ? reader.GetString(3) : string.Empty,
                RowVersion=(byte[])reader[4]
            };
        }
    }
}
