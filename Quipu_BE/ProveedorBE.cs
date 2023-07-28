using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quipu_ADO
{
    public class ProveedorBE
    {
        private int id_proveedor;
        private String nom_proveedor;
        private String ruc_proveedor;
        private String correo_proveedor;
        private String dir_proveedor;
        private String tel_proveedor;
        private Boolean est_proveedor;

        public int Id_proveedor { get => id_proveedor; set => id_proveedor = value; }
        public string Nom_proveedor { get => nom_proveedor; set => nom_proveedor = value; }
        public string Ruc_proveedor { get => ruc_proveedor; set => ruc_proveedor = value; }
        public string Correo_proveedor { get => correo_proveedor; set => correo_proveedor = value; }
        public string Dir_proveedor { get => dir_proveedor; set => dir_proveedor = value; }
        public string Tel_proveedor { get => tel_proveedor; set => tel_proveedor = value; }
        public bool Est_proveedor { get => est_proveedor; set => est_proveedor = value; }
    }
}
