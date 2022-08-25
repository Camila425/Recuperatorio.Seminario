using Recuperatorio.Datos.Recuperatorio;
using Recuperatorio.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recuperatorio.Servicio.Servicio
{
    public class ServicioLibros
    {

        private readonly RepositorioLibros repositorio;
        public ServicioLibros()
        {
            repositorio = new RepositorioLibros();
        }

        public List<Libros> GetLista()
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
