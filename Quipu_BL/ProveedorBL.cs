using Quipu_ADO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quipu_BL
{
    
    public class ProveedorBL
    {
        ProveedorADO proveedorADO = new ProveedorADO();
        public DataTable ListarProveedores()
        {
            return proveedorADO.ListarProveedores();
        }
    }
}
