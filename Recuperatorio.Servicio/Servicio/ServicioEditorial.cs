using Recuperatorio.Datos.Recuperatorio;
using Recuperatorio.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recuperatorio.Servicio.Servicio
{
    public class ServicioEditorial
    {

        private RepositorioEditoriales repositorio;
        public ServicioEditorial()
        {
            repositorio = new RepositorioEditoriales();
        }

        public List<Editoriales> GetLista()
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

        public int Agregar(Editoriales editoriales)
        {
            try
            {
                return repositorio.Agregar(editoriales);
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }
    }
}
