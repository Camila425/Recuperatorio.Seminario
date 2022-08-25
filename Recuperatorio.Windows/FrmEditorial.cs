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
    public partial class FrmEditorial : Form
    {
        public FrmEditorial()
        {
            InitializeComponent();
        }
        private ServicioEditorial servicio;
        private List<Editoriales> Lista;
        private void FrmEditorial_Load(object sender, EventArgs e)
        {
            servicio = new ServicioEditorial();
            try
            {
                Lista = servicio.GetLista();
                MostrarDatosenGrilla();

            }
            catch (Exception Exception)
            {
                Console.WriteLine(Exception);
                throw ;
            }
        }

        private void MostrarDatosenGrilla()
        {
            DatosDataGridView.Rows.Clear();
            foreach (var editorial in Lista)
            {
                DataGridViewRow r = ClaseEstatica.ClaseEstatica.ConstruirFila(DatosDataGridView);
                ClaseEstatica.ClaseEstatica.SetearFila(r, editorial);
                ClaseEstatica.ClaseEstatica.AgregarFila(DatosDataGridView, r);
            }
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            FrmEditorialAE frm = new FrmEditorialAE() { Text = "Agregar Editorial" };
            DialogResult dr = frm.ShowDialog(this);
            if (dr==DialogResult.Cancel)
            {
                return;
            }

            try
            {
                Editoriales editoriales = frm.GeEditorial();
                int RegistrosAgregados = servicio.Agregar(editoriales);
                if (RegistrosAgregados==0)
                {
                    MessageBox.Show("No se agregaron Registro", "mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Recargargrilla();
                }
                else
                {
                    var r = ClaseEstatica.ClaseEstatica.ConstruirFila(DatosDataGridView);
                    ClaseEstatica.ClaseEstatica.SetearFila(r, editoriales);
                    ClaseEstatica.ClaseEstatica.AgregarFila(DatosDataGridView, r);
                      MessageBox.Show(" Registro agregado", "mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch (Exception Exception)
            {

                MessageBox.Show(Exception.Message,"error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void Recargargrilla()
        {
            try
            {
                Lista = servicio.GetLista();
                MostrarDatosenGrilla();
            }
            catch (Exception exception)
            {

                MessageBox.Show(exception.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Salirbutton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
