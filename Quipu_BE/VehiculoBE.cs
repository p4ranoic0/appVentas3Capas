using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Quipu_BE
{
    public class VehiculoBE
    {
        private int id_vehiculo;
        private int id_repartidor;
        private String marca; 
        private String modelo;
        private String placa;
        private Boolean est_vehiculo;

        public int Id_vehiculo { get => id_vehiculo; set => id_vehiculo = value; }
        public int Id_repartidor { get => id_repartidor; set => id_repartidor = value; }
        public string Marca { get => marca; set => marca = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public string Placa { get => placa; set => placa = value; }
        public bool Est_vehiculo { get => est_vehiculo; set => est_vehiculo = value; }
    }
}
