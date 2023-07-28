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
    public class RepartidorBL
    {

        RepartidorADO repartidorADO = new RepartidorADO();
        public Boolean InsertarRepartidor(RepartidorBE repartidorBE)
        {
            return repartidorADO.InsertarRepartidor(repartidorBE);
        }
        public Boolean ModificarRepartidor(RepartidorBE repartidorBE) {
            return repartidorADO.ModificarRepartidor(repartidorBE);
        }
        public Boolean BajaRepartidor(int cod)
        {
            return repartidorADO.BajaRepartidor(cod);
        }
        public DataTable ListarRepartidores()
        {
            return repartidorADO.ListarRepartidor();
        }
        public DataTable ListarRepartidoresPorEstado(int est)
        {
            return repartidorADO.ListarRepartidoresPorEstado(est);
        }

        public RepartidorBE RepartidorPorId(int cod)
        {
            return repartidorADO.RepartidorPorId(cod);
        }
    }
}
