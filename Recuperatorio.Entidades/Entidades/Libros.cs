using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recuperatorio.Entidades.Entidades
{
    public class Libros
    {
        public int LibrosId { get; set; }
        public string Titulo { get; set; }
        public int AutorID { get; set; }
        public int Ejemplares { get; set; }
        public int GeneroId { get; set; }
        public int idiomasId { get; set; }
        public int EditorialId { get; set; }
        public decimal precio { get; set; }
        public byte[] RowVersion { get; set; }
    }
}
