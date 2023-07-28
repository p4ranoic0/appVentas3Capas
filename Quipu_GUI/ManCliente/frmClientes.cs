using Quipu_BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quipu_GUI.ManCliente
{
    public partial class frmClientes : Form
    {
        ClienteBL clienteBL = new ClienteBL();
        DataView dtv;

        public frmClientes()
        {
            InitializeComponent();
        }

        public void cargarDatos(String cad)
        {
            dtv.RowFilter= "nom_cliente like '%" + cad + "%'"+ "OR ape_cliente like '%" + cad + "%'";
            dtgCliente.DataSource = dtv;
            lblRegistros.Text = dtgCliente.Rows.Count.ToString(); 
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            try
            {
                dtgCliente.AutoGenerateColumns = false;
                dtv= new DataView(clienteBL.ListarCliente());
                cargarDatos(txtCad.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCad_TextChanged(object sender, EventArgs e)
        {
            cargarDatos(txtCad.Text.Trim());
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            frmInsertarCliente frm = new frmInsertarCliente();
            frm.ShowDialog();
            txtCad.Clear();
            dtv = new DataView(clienteBL.ListarCliente());
            cargarDatos(txtCad.Text.TrimEnd());
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                String codigo = dtgCliente.CurrentRow.Cells[0].Value.ToString();
                frmModificarCliente frm = new frmModificarCliente();
                frm.Codigo = codigo;
                frm.ShowDialog();
                txtCad.Clear();
                dtv = new DataView(clienteBL.ListarCliente());
                cargarDatos(txtCad.Text.Trim());
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error : " + ex.Message);
            }
        }
    }
}
