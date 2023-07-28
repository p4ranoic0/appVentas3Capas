using Quipu_BE;
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
    public partial class frmModificarRepartidor : Form
    {
        public frmModificarRepartidor()
        {
            InitializeComponent();
        }
        RepartidorBE repartidorBE = new RepartidorBE();
        RepartidorBL repartidorBL = new RepartidorBL(); 
        public string Codigo { get; internal set; }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                repartidorBE.Id_repartidor = Convert.ToInt16(txtIdRepartidor.Text);
                repartidorBE.Nom_repartidor = txtNombres.Text.Trim();
                repartidorBE.Ape_repartidor = txtApellidos.Text.Trim();
                repartidorBE.Dni_repartidor = mskDni.Text.Trim();
                repartidorBE.Correo_repartidor = txtEmail.Text.Trim();
                repartidorBE.Tel_repartidor = txtTelefono.Text.Trim();
                repartidorBE.Est_repartidor = (cbEstado.Text.ToString() == "ACTIVO") ? true : false;
                if (repartidorBL.ModificarRepartidor(repartidorBE))
                {
                    this.Close();
                }
                else { throw new Exception("No se pudo efectuar la modificacion"); }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error : " + ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmModificarRepartidor_Load(object sender, EventArgs e)
        {
            try
            {
                repartidorBE = repartidorBL.RepartidorPorId(Convert.ToInt16(this.Codigo));
                txtIdRepartidor.Text = repartidorBE.Id_repartidor.ToString();
                txtNombres.Text = repartidorBE.Nom_repartidor;
                txtApellidos.Text = repartidorBE.Ape_repartidor;
                mskDni.Text = repartidorBE.Dni_repartidor;
                txtEmail.Text = repartidorBE.Correo_repartidor;
                txtTelefono.Text = repartidorBE.Tel_repartidor;
                mskFecNac.Text = repartidorBE.Fecha_nac.ToString();

                // Agregar los valores al ComboBox
                cbEstado.Items.Add("ACTIVO");
                cbEstado.Items.Add("INACTIVO");

                // Asignar el valor según el booleano
                cbEstado.SelectedItem = (repartidorBE.Est_repartidor)? "ACTIVO": "INACTIVO";
                           
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error : " + ex.Message);
            }
        }
    }
}
