using Recuperatorio.Datos.Recuperatorio;
using Recuperatorio.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recuperatorio.Servicio.Servicio
{
    public class ServicioAutores
    {
        private readonly AutoresRepositorio repositorio;
        public ServicioAutores()
        {
            repositorio = new AutoresRepositorio();
        }

        public List<Autores> GetLista()
        {
            //try
            //{
                return repositorio.GetLista();
            //}
            //catch (Exception e)
            //{

            //    throw new Exception(e.Message);
            //}
        }


    }
}
