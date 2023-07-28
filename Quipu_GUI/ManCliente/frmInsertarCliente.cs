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

namespace Quipu_GUI.ManCliente
{
    public partial class frmInsertarCliente : Form
    {
        public frmInsertarCliente()
        {
            InitializeComponent();
        }

        ClienteBL clienteBL = new ClienteBL();
        ClienteBE clienteBE = new ClienteBE();

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (mskDni.MaskFull == false)
                {
                    throw new Exception("Debe llenar el DNI con 8 digitos.");
                }
                clienteBE.Dni_cliente = mskDni.Text.Trim();
                clienteBE.Nom_cliente = txtNombres.Text.Trim();
                clienteBE.Ape_cliente = txtApellidos.Text.Trim();
                clienteBE.Dir_cliente = txtDireccion.Text.Trim();
                clienteBE.Correo_cliente = txtEmail.Text.Trim();
                clienteBE.Tel_cliente = txtTelefono.Text.Trim();
                clienteBE.Est_cliente = true;
                if (clienteBL.InsertarCliente(clienteBE))
                {
                    this.Close();
                }
                else {
                    throw new Exception("No se guardo la informacion");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Se ha producido el error: " + ex.Message);
            }
        }
    }
}
