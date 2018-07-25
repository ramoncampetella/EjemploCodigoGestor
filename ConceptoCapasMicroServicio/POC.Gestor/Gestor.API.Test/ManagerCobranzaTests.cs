using Gestor.BizEntities;
using Gestor.CuotaCobradaServiceAdapter;
using Gestor.ResumenTarjetaCobradoAdapter;
using System;
using Xunit;
using Xunit.Ioc.Autofac;

namespace Gestor.API.Test
{
    [UseAutofacTestFramework]
    public class ManagerCobranzaTests
    {
        //sacar y poner DI.
        private ICuotaCobradaService _cuotaCobradaService;
        private IResumenTarjetaCobradoService _resumenTarjetaCobradoService;

        private ManagerCobranza _manager;

        public ManagerCobranzaTests()
        {}

        public ManagerCobranzaTests(ICuotaCobradaService cuotaCobradaService, IResumenTarjetaCobradoService resumenTarjetaCobradoService)
        {
            _cuotaCobradaService = cuotaCobradaService;
            _resumenTarjetaCobradoService = resumenTarjetaCobradoService;
            _manager = new ManagerCobranza(_cuotaCobradaService, _resumenTarjetaCobradoService);
        }


        [Fact]
        public void CobrarCuotaAndTarjetaOKTest()
        {
            try
            {
                Cobranza cobranza = new Cobranza();
                cobranza.Descripcion = "Cobranza de prueba";
                cobranza.Fecha = DateTime.Now;
                cobranza.MediosPago = new System.Collections.Generic.List<MedioPago>() { new MedioPago() { Descripcion = "Efectivo", MontoPagado = 1000 } };
                Cuota cuota = new Cuota() { CuentaCredito = 123, FechaVencimiento = new DateTime(2018, 7, 20), NroCuota = 2, IdentificacionCredito = 1234567, ValorCuota = 500, FechaPago = DateTime.Now, MontoPagado = 500 };
                ResumenTarjeta tarjeta = new ResumenTarjeta() { NumeroCuenta = 3456, TipoTarjeta = "V", FechaVencimiento = new DateTime(2018, 7, 21), Consumo = 500, FechaPago = DateTime.Now, MontoPagado = 500 };

                cobranza.Pagos = new System.Collections.Generic.List<AbstractPago>() { cuota, tarjeta };


                int idCobranza = _manager.Cobrar(cobranza);

                Assert.True(idCobranza > 0, "Ocurrio un error");
            }
            catch (Exception ex)
            {
                ex = ex;
            }
        }

        [Fact]
        public void CobrarTarjetaOKTest()
        {

        }

        [Fact]
        public void CobrarCuotaOKTest()
        {

        }
    }
}
