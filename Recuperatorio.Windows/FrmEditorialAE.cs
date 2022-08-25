using Recuperatorio.Entidades.Entidades;
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
    public partial class FrmEditorialAE : Form
    {
        public FrmEditorialAE()
        {
            InitializeComponent();
        }
        private Editoriales Editoriales;
        public Editoriales GeEditorial()
        {
            return Editoriales;
        }

        private void Cancelarbutton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void okbutton_Click(object sender, EventArgs e)
        {
            if (validardatos())
            {
                if (Editoriales==null)
                {
                    Editoriales = new Editoriales();
                }
                Editoriales.NombreEditorial = EditorialTextBox.Text;
                DialogResult = DialogResult.OK;
            }
        }

        private bool validardatos()
        {
            errorProvider1.Clear();
            bool validar = true;
            if (string.IsNullOrEmpty(EditorialTextBox.Text))
            {
                validar = false;
                errorProvider1.SetError(EditorialTextBox,"error nombre editorial");
             
            }
            return validar;
        }
    }
}
