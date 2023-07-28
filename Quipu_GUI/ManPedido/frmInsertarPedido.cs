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

namespace Quipu_GUI.ManPedido
{
    public partial class frmInsertarPedido : Form
    {
        public frmInsertarPedido()
        {
            InitializeComponent();
        }

        ClienteBE clienteBE = new ClienteBE();
        

        RepartidorBE repartidorBE = new RepartidorBE();
        

        private void frmInsertarPedido_Load(object sender, EventArgs e)
        {
            int est = 1;//activo

            ClienteBL clienteBL = new ClienteBL();
            cbCliente.DataSource = clienteBL.ListarClientePorEstado(est);
            cbCliente.ValueMember = "id_cliente";
            cbCliente.DisplayMember = "nom_cliente";
            cbCliente.SelectedValue = 1;


            RepartidorBL repartidorBL = new RepartidorBL();
            cbRepartidor.DataSource = repartidorBL.ListarRepartidoresPorEstado(est);
            cbRepartidor.ValueMember = "id_repartidor";
            cbRepartidor.DisplayMember = "nom_repartidor";
            cbRepartidor.SelectedValue = 1;

        }
    }
}
