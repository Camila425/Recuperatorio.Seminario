using Recuperatorio.Entidades.Entidades;
using Recuperatorio.Servicio.Servicio;
using Recuperatorio.Windows.ClaseEstatica;
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
    public partial class FrmAutores : Form
    {
        public FrmAutores()
        {
            InitializeComponent();
        }
        private ServicioAutores servicio;
        private List<Autores> Lista;
        private void FrmAutores_Load(object sender, EventArgs e)
        {
            servicio = new ServicioAutores();
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
            foreach (var autores in Lista)
            {
                DataGridViewRow r = ClaseEstatica.ClaseEstatica.ConstruirFila(DatosDataGridView);
                ClaseEstatica.ClaseEstatica.SetearFila(r, autores);
                ClaseEstatica.ClaseEstatica.AgregarFila(DatosDataGridView,r);
            }
        }

        private void Salirbutton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
