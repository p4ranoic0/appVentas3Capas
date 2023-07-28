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

namespace Quipu_GUI.ManRepartidor
{
    public partial class frmRepartidor : Form
    {
        RepartidorBL repartidorBL = new RepartidorBL();
        DataView dtv;
        public frmRepartidor()
        {
            InitializeComponent();
        }

        public void cargarDatos(String cad)
        {
            dtv.RowFilter = "nom_repartidor like '%" + cad + "%'";
            dtgRepartidor.DataSource = dtv;
            lblRegistros.Text = dtgRepartidor.Rows.Count.ToString();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void frmRepartidor_Load(object sender, EventArgs e)
        {
            try
            {
                dtgRepartidor.AutoGenerateColumns = false;
                dtv = new DataView(repartidorBL.ListarRepartidores());
                cargarDatos(txtCad.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void txtCad_TextChanged(object sender, EventArgs e)
        {
            cargarDatos(txtCad.Text.Trim());
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            frmInsertarRepartidor frm = new frmInsertarRepartidor();
            frm.ShowDialog();
            txtCad.Clear();
            dtv = new DataView(repartidorBL.ListarRepartidores());
            cargarDatos(txtCad.Text.Trim());

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                String codigo = dtgRepartidor.CurrentRow.Cells[0].Value.ToString();
                frmModificarRepartidor frm = new frmModificarRepartidor();
                frm.Codigo = codigo;
                frm.ShowDialog();
                txtCad.Clear();
                dtv = new DataView(repartidorBL.ListarRepartidores());
                cargarDatos(txtCad.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
