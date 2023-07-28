using Quipu_ADO;
using Quipu_BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quipu_BL
{
    public class ProductoBL
    {
        ProductoADO productoADO = new ProductoADO();
        public Boolean InsertarProducto(ProductoBE productoBE){
            return productoADO.InsertarProducto(productoBE);
        }
        public Boolean ModificarProducto(ProductoBE productoBE)
        {
            return productoADO.ModificarProducto(productoBE);
        }
        public Boolean BajaProducto(int codProducto)
        {
            return productoADO.BajaProducto(codProducto);
        }
        public DataTable ListarProducto()
        {
            return productoADO.ListarProducto();
        }
        public DataTable ListarProductoPorEstado()
        {
            return productoADO.ListarProductoPorEstado();
        }
        public ProductoBE ProductoPorId(int codProducto)
        {
            return productoADO.ProductoPorId(codProducto);
        }


    }
}
