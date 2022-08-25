using Recuperatorio.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Recuperatorio.Windows.ClaseEstatica
{
    public class ClaseEstatica
    {
        public static void SetearFila(DataGridViewRow r,object obj)
        {
            switch (obj)
            {
                case Autores autores:
                    r.Cells[0].Value = autores.AutorId;
                    r.Cells[1].Value = autores.Apellido;
                    r.Cells[2].Value = autores.Nombre;
                    r.Cells[3].Value = autores.nacionalidad;
                    break;
                case Libros libros:

                    r.Cells[0].Value = libros.precio;
                    r.Cells[1].Value = libros.idiomasId;
                    r.Cells[2].Value = libros.GeneroId;
                    r.Cells[3].Value = libros.Titulo;
                    break;
                case Usuarios usuarios:
                    r.Cells[0].Value = usuarios.DNI;
                    r.Cells[1].Value = usuarios.Apellido;
                    r.Cells[2].Value = usuarios.Nombre;
                    r.Cells[3].Value = usuarios.Direccion;
                    r.Cells[4].Value = usuarios.Direccion;
                    break;
                case Editoriales editoriales:
                    r.Cells[0].Value = editoriales.NombreEditorial;
                    break;
            }
            r.Tag = obj;
        }

        public static DataGridViewRow ConstruirFila(DataGridView dataGridview)
        {
            var r = new DataGridViewRow();
            r.CreateCells(dataGridview);
            return r;
        }
        public static void AgregarFila(DataGridView datagridview, DataGridViewRow r)
        {
            datagridview.Rows.Add(r);
        }

    }
}
