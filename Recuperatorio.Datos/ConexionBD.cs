using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recuperatorio.Datos
{
    public class ConexionBD
    {

        private readonly string CadenaConexion;
        private SqlConnection cn;
        public ConexionBD()
        {
            CadenaConexion = ConfigurationManager.ConnectionStrings["MiConexion"].ToString();
        }


        public SqlConnection AbrirConexion()
        {
            try
            {
                cn = new SqlConnection(CadenaConexion);
                cn.Open();
                return cn;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }



        public void CerrarConexion()
        {
            if (cn.State==ConnectionState.Open)
            {
                cn.Close();
            }
        }
    }
}
