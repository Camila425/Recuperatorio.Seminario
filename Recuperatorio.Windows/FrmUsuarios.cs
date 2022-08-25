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
    public partial class FrmUsuarios : Form
    {
        public FrmUsuarios()
        {
            InitializeComponent();
        }
        private ServicioUsuario servicio;
        private List<Usuarios> Lista;
        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            servicio = new ServicioUsuario();
            try
            {
                Lista = servicio.GetrLista();
                MostrarDatosenGrilla();
            }
            catch (Exception Exception)
            {
                Console.WriteLine(Exception);
                throw;
            }
        }

        private void MostrarDatosenGrilla()
        {
            DatosDataGridView.Rows.Clear();
            foreach (var usuarios in Lista)
            {
                DataGridViewRow r = ClaseEstatica.ClaseEstatica.ConstruirFila(DatosDataGridView);
                ClaseEstatica.ClaseEstatica.SetearFila(r, usuarios);
                ClaseEstatica.ClaseEstatica.AgregarFila(DatosDataGridView, r);
            }
        }
    }
}
