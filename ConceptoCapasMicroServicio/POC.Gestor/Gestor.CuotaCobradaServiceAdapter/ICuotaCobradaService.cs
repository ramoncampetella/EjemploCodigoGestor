using Gestor.BizEntities;

namespace Gestor.CuotaCobradaServiceAdapter
{
    public interface ICuotaCobradaService
    {
        void RegistrarCobro(ref Cuota cuota);
    }
}