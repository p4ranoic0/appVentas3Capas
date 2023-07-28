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
    public partial class frmModificarCliente : Form
    {
        public frmModificarCliente()
        {
            InitializeComponent();
        }

        private String _Codigo;
        ClienteBE clienteBE = new ClienteBE();
        ClienteBL clienteBL = new ClienteBL();

        public String Codigo
        {
            get { return _Codigo; }
            set { _Codigo = value; }

        }
        private void frmModificarCliente_Load(object sender, EventArgs e)
        {
            try
            {
                clienteBE = clienteBL.ConsultarCliente(Convert.ToInt16(this.Codigo));
                txtIdCliente.Text = clienteBE.Id_cliente.ToString();
                txtNombres.Text = clienteBE.Nom_cliente;
                txtApellidos.Text = clienteBE.Ape_cliente;
                txtDni.Text = clienteBE.Dni_cliente;
                txtDireccion.Text = clienteBE.Dir_cliente;
                txtEmail.Text = clienteBE.Correo_cliente;
                txtTelefono.Text = clienteBE.Tel_cliente;
                // Agregar los valores al ComboBox
                cbEstado.Items.Add("ACTIVO");
                cbEstado.Items.Add("INACTIVO");

                // Asignar el valor según el booleano
                if (clienteBE.Est_cliente)
                {
                    cbEstado.SelectedItem = "ACTIVO";
                }
                else
                {
                    cbEstado.SelectedItem = "INACTIVO";
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error : " + ex.Message);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                clienteBE.Id_cliente = Convert.ToInt16(txtIdCliente.Text.Trim());
                clienteBE.Nom_cliente = txtNombres.Text.Trim();
                clienteBE.Ape_cliente = txtApellidos.Text.Trim();
                clienteBE.Dni_cliente = txtDni.Text.Trim();
                clienteBE.Dir_cliente = txtDireccion.Text.Trim();
                clienteBE.Correo_cliente = txtEmail.Text.Trim();
                clienteBE.Tel_cliente = txtTelefono.Text.Trim();
                clienteBE.Est_cliente = (cbEstado.Text.ToString() == "ACTIVO") ? true : false;
                if (clienteBL.ModificarCliente(clienteBE))
                {
                    this.Close();
                }
                else { throw new Exception("No se pudo efectuar la modificacion"); }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se ha producido el error: " + ex.Message);
            }


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
