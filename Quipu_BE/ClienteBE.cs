using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quipu_BE
{
    public class ClienteBE
    {
        private int id_cliente;
        private String nom_cliente;
        private String ape_cliente;
        private String dni_cliente;
        private String correo_cliente;
        private String tel_cliente;
        private String dir_cliente;
        private Boolean est_cliente;

        public int Id_cliente { get => id_cliente; set => id_cliente = value; }
        public string Nom_cliente { get => nom_cliente; set => nom_cliente = value; }
        public string Ape_cliente { get => ape_cliente; set => ape_cliente = value; }
        public string Dni_cliente { get => dni_cliente; set => dni_cliente = value; }
        public string Correo_cliente { get => correo_cliente; set => correo_cliente = value; }
        public string Tel_cliente { get => tel_cliente; set => tel_cliente = value; }
        public string Dir_cliente { get => dir_cliente; set => dir_cliente = value; }
        public bool Est_cliente { get => est_cliente; set => est_cliente = value; }
    }
}
