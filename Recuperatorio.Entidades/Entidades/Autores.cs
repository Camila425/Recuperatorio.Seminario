using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recuperatorio.Entidades.Entidades
{
    public class Autores
    {
        public int AutorId { get; set; }
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public string nacionalidad { get; set; }
        public byte[] RowVersion { get; set; }
    }
}
