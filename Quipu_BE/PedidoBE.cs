using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quipu_BE
{
    public class PedidoBE
    {
        private int id_pedido;
        private int id_cliente;
        private int id_repartidor;
        private float distanciaKM;
        private String recojo;
        private DateTime fecha_pedido;
        private String destino;
        private DateTime fecha_entrega;
        private Boolean est_pedido;

        public int Id_pedido { get => id_pedido; set => id_pedido = value; }
        public int Id_cliente { get => id_cliente; set => id_cliente = value; }
        public int Id_repartidor { get => id_repartidor; set => id_repartidor = value; }
        public float DistanciaKM { get => distanciaKM; set => distanciaKM = value; }
        public string Recojo { get => recojo; set => recojo = value; }
        public DateTime Fecha_pedido { get => fecha_pedido; set => fecha_pedido = value; }
        public string Destino { get => destino; set => destino = value; }
        public DateTime Fecha_entrega { get => fecha_entrega; set => fecha_entrega = value; }
        public bool Est_pedido { get => est_pedido; set => est_pedido = value; }
    }
}
