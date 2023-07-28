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
    public partial class frmInsertarRepartidor : Form
    {
        RepartidorBL repartidorBL = new RepartidorBL();
        RepartidorBE repartidorBE = new RepartidorBE();

        public frmInsertarRepartidor()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!mskDni.MaskFull)
                {
                    throw new Exception("Debe llenar el DNI con 8 digitos.");
                }
                repartidorBE.Dni_repartidor = mskDni.Text.Trim();
                repartidorBE.Nom_repartidor = txtNombres.Text.Trim(); 
                repartidorBE.Ape_repartidor = txtApellidos.Text.Trim();
                repartidorBE.Correo_repartidor = txtEmail.Text.Trim();
                repartidorBE.Tel_repartidor = txtTelefono.Text.Trim();
                repartidorBE.Fecha_nac = Convert.ToDateTime(mskFechaNac.Text.Trim());
                repartidorBE.Est_repartidor = true;

                if (repartidorBL.InsertarRepartidor(repartidorBE))
                {
                    this.Close();
                }
                else {
                    throw new Exception("No se guardo la informacion");
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: "+ ex.Message);
            }
        }
    }
}
