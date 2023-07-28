using Quipu_GUI.ManCliente;
using Quipu_GUI.ManProducto;
using Quipu_GUI.ManRepartidor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quipu_GUI
{
    public partial class MDIPrincipal : Form
    {
        public MDIPrincipal()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

     

        private void MDIPrincipal_Load(object sender, EventArgs e)
        {
            this.lblUsuario.Text = ClsUsuario.Usuario;
        }

        private void MDIPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult res;
            res = MessageBox.Show("Seguro que deseas salir ?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

       


        
        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClientes frm = new frmClientes();
            frm.MdiParent = this;
            frm.Show();
        }

        private void productoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProductos frm = new frmProductos();
            frm.MdiParent = this;
            frm.Show();
        }

        private void courierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRepartidor frm = new frmRepartidor();
            frm.MdiParent = this; 
            frm.Show();
        }
    }
}
