using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quipu_BE
{
    public class RepartidorBE
    {
        private int id_repartidor;
        private String nom_repartidor;
        private String ape_repartidor;
        private String dni_repartidor;
        private String correo_repartidor;
        private String tel_repartidor;
        private DateTime fecha_nac;
        private Boolean est_repartidor;

        public int Id_repartidor { get => id_repartidor; set => id_repartidor = value; }
        public string Nom_repartidor { get => nom_repartidor; set => nom_repartidor = value; }
        public string Ape_repartidor { get => ape_repartidor; set => ape_repartidor = value; }
        public string Dni_repartidor { get => dni_repartidor; set => dni_repartidor = value; }
        public string Correo_repartidor { get => correo_repartidor; set => correo_repartidor = value; }
        public string Tel_repartidor { get => tel_repartidor; set => tel_repartidor = value; }
        public DateTime Fecha_nac { get => fecha_nac; set => fecha_nac = value; }
        public bool Est_repartidor { get => est_repartidor; set => est_repartidor = value; }
    }
}
