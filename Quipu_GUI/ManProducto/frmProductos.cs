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

namespace Quipu_GUI.ManProducto
{
    public partial class frmProductos : Form
    {
        ProductoBL productoBL = new ProductoBL();
        DataView dtv;
        public frmProductos()
        {
            InitializeComponent();
        }

        public void cargarDatos(String cad)
        {
            dtv.RowFilter = "nom_producto like '%" + cad + "%'";
            dtgProducto.DataSource = dtv;
            lblRegistros.Text = dtgProducto.Rows.Count.ToString();
        }


        private void frmProductos_Load(object sender, EventArgs e)
        {
            try
            {
                dtgProducto.AutoGenerateColumns = false;
                dtv = new DataView(productoBL.ListarProducto());
                cargarDatos(txtCad.Text.Trim());
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCad_TextChanged(object sender, EventArgs e)
        {
            cargarDatos(txtCad.Text.Trim().ToLower());
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            frmInsertarProducto frm = new frmInsertarProducto();
            frm.ShowDialog();
            txtCad.Clear();
            dtv = new DataView(productoBL.ListarProducto());
            cargarDatos(txtCad.Text.TrimEnd());
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                String strCodigo = dtgProducto.CurrentRow.Cells[0].Value.ToString();
                frmModificarProducto frm = new frmModificarProducto();
                frm.Codigo = strCodigo;
                frm.ShowDialog();
                txtCad.Clear();

                dtv = new DataView(productoBL.ListarProducto());
                cargarDatos(txtCad.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
           

        }
    }
}
