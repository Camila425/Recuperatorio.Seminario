using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recuperatorio.Entidades.Entidades
{
    public class Prestamos
    {
       public int PrestamoId { get; set; }
        public int LibroId { get; set; }
        public int SocioId { get; set; }
        public DateTime fechaprestamo { get; set; }
        public DateTime FechaDevolucion { get; set; }
        public byte[] RowVersion { get; set; }

    }
}
