using Gestor.BizEntities;

namespace Gestor.ResumenTarjetaCobradoAdapter
{
    public interface IResumenTarjetaCobradoService
    {
        void RegistrarCobro(ref ResumenTarjeta resumen);
    }
}