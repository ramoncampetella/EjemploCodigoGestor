using Gestor.BizEntities;
using Gestor.Common;
using Gestor.CuotaCobradaServiceAdapter;
using Gestor.ResumenTarjetaCobradoAdapter;
using System;
using System.Reflection;

namespace Gestor.API
{
    /// <summary>
    /// Contiene la logica del servicio, solo sabe utilizar las BizEntities propias de este servicio,
    /// DESCONOCE SU EXTERIOR.
    /// </summary>
    public class ManagerCobranza
    {
        private ICuotaCobradaService _cuotaCobradaService;
        private IResumenTarjetaCobradoService _resumenTarjetaService;

        public ManagerCobranza(ICuotaCobradaService cuotaCobradaService, IResumenTarjetaCobradoService resumenTarjetaService)
        {
            _cuotaCobradaService = cuotaCobradaService;
            _resumenTarjetaService = resumenTarjetaService;
        }

        public int Cobrar(Cobranza cobranza)
        {
            int idCobranza = 0;

            foreach (var pago in cobranza.Pagos)
            {
                MethodInfo executer = typeof(ManagerCobranza).GetMethod("ProcesarCobro", new Type[] { pago.GetType() });
                executer.Invoke(this, new object[] { pago });
            }

            return idCobranza;
        }


        public void ProcesarCobro(ResumenTarjeta resumen)
        {
            //Realizar Validacion
            this.ValidarCobroResumenTarjeta(resumen);
            //Registra pago en ResumenTarjetaCobrado
            _resumenTarjetaService.RegistrarCobro(resumen);
        }

        public void ProcesarCobro(Cuota cuota)
        {
            //Realizar Validacion
            this.ValidarCobroCuota(cuota);
            //Registra pago en CuotaCobrada
            _cuotaCobradaService.RegistrarCobro(cuota);
        }

        internal void ValidarCobroResumenTarjeta(ResumenTarjeta resumen)
        {
            if (resumen.MontoPagado <= 0) throw new FunctionalException("El monto pagado debe ser superior a cero");
        }

        internal void ValidarCobroCuota(Cuota cuota)
        {
            if (cuota.MontoPagado < cuota.ValorCuota) throw new FunctionalException("El valor pagado no puede ser menor al valor de la cuota.");
        }
    }
}
