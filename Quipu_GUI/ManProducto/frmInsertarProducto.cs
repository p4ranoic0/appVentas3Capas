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

namespace Quipu_GUI.ManProducto
{
    public partial class frmInsertarProducto : Form
    {
        ProductoBE productoBE = new ProductoBE();
        ProductoBL productoBL = new ProductoBL();

        public frmInsertarProducto()
        {
            InitializeComponent();
        }

        private void frmInsertarProducto_Load(object sender, EventArgs e)
        {
            try
            {
                ProveedorBL proveedorBL = new ProveedorBL();
                cboProveedor.DataSource = proveedorBL.ListarProveedores();
                cboProveedor.ValueMember = "id_proveedor";
                cboProveedor.DisplayMember = "nombre_proveedor";
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                productoBE.Nom_producto = txtNombre.Text.Trim();
                productoBE.Descripcion = txtDescripcion.Text.Trim();
                productoBE.Precio = Convert.ToDouble(txtPrecio.Text.Trim());
                productoBE.Peso = Convert.ToDouble(txtPeso.Text.Trim());
                productoBE.Id_proveedor = Convert.ToInt16(cboProveedor.SelectedValue.ToString());
                productoBE.Est_producto = true;

                if (productoBL.InsertarProducto(productoBE) == true)
                {
                    this.Close();
                }
                else
                {
                    throw new Exception("No se inserto registro. Contacte con IT");
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show("Error : " + ex.Message);
            }
        }
    }
}
