using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Quipu_BE
{
    public class ProductoBE
    {
        private int id_producto;
        private String nom_producto ;
        private String descripcion;
        private double precio;
        private double peso;
        private Boolean est_producto;
        private int id_proveedor;

        public int Id_producto { get => id_producto; set => id_producto = value; }
        public string Nom_producto { get => nom_producto; set => nom_producto = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public double Precio { get => precio; set => precio = value; }
        public double Peso { get => peso; set => peso = value; }
        public bool Est_producto { get => est_producto; set => est_producto = value; }
        public int Id_proveedor { get => id_proveedor; set => id_proveedor = value; }
    }
}
