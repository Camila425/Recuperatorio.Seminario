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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void ChocolatesButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var frm = new FrmEditorial();
            frm.Show();
        }

        private void PaisesButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var frm = new FrmAutores();
            frm.Show();
        }

        private void FabricasButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var frm = new FrmLibros();
            frm.Show();
        }

        private void CerrarButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BombonesButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var frm = new FrmUsuarios();
            frm.Show();
        }
    }
}
