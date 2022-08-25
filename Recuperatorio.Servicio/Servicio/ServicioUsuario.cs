using Recuperatorio.Datos.Recuperatorio;
using Recuperatorio.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recuperatorio.Servicio.Servicio
{
    public class ServicioUsuario
    {
        private readonly RepositorioUsuarios repositorio;
        public ServicioUsuario()
        {
            repositorio = new RepositorioUsuarios();
        }
        public List<Usuarios> GetrLista()
        {
            try
            {
                return repositorio.GetLista();
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

    }
}
