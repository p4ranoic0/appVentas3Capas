using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Quipu_ADO;
using Quipu_BE;
namespace Quipu_BL
{
    public class ClienteBL
    {
        ClienteADO objClienteADO = new ClienteADO();
        public Boolean InsertarCliente(ClienteBE cliente)
        {
            return objClienteADO.InsertarCliente(cliente);
        }
        public Boolean ModificarCliente(ClienteBE cliente)
        {
            return objClienteADO.ModificarCliente(cliente);
        }
        public Boolean BajaCliente(int codCliente)
        {
            return objClienteADO.BajaCliente(codCliente);
        }

        public ClienteBE ConsultarCliente(int codCliente)
        {
            return objClienteADO.ConsultarCliente(codCliente);
        }

        public DataTable ListarCliente()
        {
            return objClienteADO.ListarCliente();
        }

        public DataTable ListarClientePorEstado(int est)
        {
            return objClienteADO.ListarClientePorEstado(est);
        }

        
    }
}
