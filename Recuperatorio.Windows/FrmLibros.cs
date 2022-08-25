using Recuperatorio.Entidades.Entidades;
using Recuperatorio.Servicio.Servicio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Recuperatorio.Windows
{
    public partial class FrmLibros : Form
    {
        public FrmLibros()
        {
            InitializeComponent();
        }
        private ServicioLibros servicio;
        private List<Libros> Lista;

        private void Salirbutton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void FrmLibros_Load(object sender, EventArgs e)
        {
            servicio = new ServicioLibros();
            try
            {
                Lista = servicio.GetLista();
                MostrarDatosEnGrilla();
            }
            catch (Exception Exception)
            {
                Console.WriteLine(Exception);
                throw;
            }
        }

        private void MostrarDatosEnGrilla()
        {
            DatosDataGridView.Rows.Clear();
            foreach (var libros in Lista)
            {
                DataGridViewRow r = ClaseEstatica.ClaseEstatica.ConstruirFila(DatosDataGridView);
                ClaseEstatica.ClaseEstatica.SetearFila(r, libros);
                ClaseEstatica.ClaseEstatica.AgregarFila(DatosDataGridView, r);
            }
        }
    }
}
