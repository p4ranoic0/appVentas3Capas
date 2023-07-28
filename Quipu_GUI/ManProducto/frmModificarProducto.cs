using Quipu_ADO;
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
    public partial class frmModificarProducto : Form
    {
        ProductoBL productoBL = new ProductoBL();
        ProductoBE productoBE = new ProductoBE();
        

        public frmModificarProducto()
        {
            InitializeComponent();
        }

        public string Codigo { get; internal set; }

        private void frmModificarProducto_Load(object sender, EventArgs e)
        {
            try
            {
                productoBE = productoBL.ProductoPorId(Convert.ToInt16(this.Codigo));
                txtIdProducto.Text = productoBE.Id_producto.ToString();
                txtNombreProducto.Text = productoBE.Nom_producto;
                txtDescripcion.Text = productoBE.Descripcion;
                txtPrecio.Text = productoBE.Precio.ToString();
                txtPeso.Text = productoBE.Peso.ToString();

                cboEstado.Items.Add("ACTIVO");
                cboEstado.Items.Add("INACTIVO");
                // Asignar el valor según el booleano
                if (productoBE.Est_producto)
                {
                    cboEstado.SelectedItem = "ACTIVO";
                }
                else
                {
                    cboEstado.SelectedItem = "INACTIVO";
                }
               

                cargarProveedor(productoBE.Id_proveedor);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error : " + ex.Message);
            }
        }

        private void cargarProveedor(int id_proveedor)
        {
            ProveedorBL proveedorBL = new ProveedorBL();
            cboProveedor.DataSource = proveedorBL.ListarProveedores();
            cboProveedor.ValueMember = "id_proveedor";
            cboProveedor.DisplayMember = "rs_proveedor";
            cboProveedor.SelectedValue= id_proveedor;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                productoBE.Id_producto= Convert.ToInt16(txtIdProducto.Text.Trim());
                productoBE.Nom_producto = txtNombreProducto.Text.Trim();
                productoBE.Descripcion = txtDescripcion.Text.Trim();
                productoBE.Precio = Convert.ToDouble(txtPrecio.Text.Trim());
                productoBE.Peso = Convert.ToDouble(txtPeso.Text.Trim());
                productoBE.Id_proveedor = Convert.ToInt16(cboProveedor.SelectedValue.ToString());
                productoBE.Est_producto = (cboEstado.Text =="ACTIVO")?true:false;

                if (productoBL.ModificarProducto(productoBE))
                {
                    this.Close();
                }
                else
                {
                    throw new Exception("No se modifico registro. Contacte con IT");
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show("Error : " + ex.Message);
            }
        }
    }
}
