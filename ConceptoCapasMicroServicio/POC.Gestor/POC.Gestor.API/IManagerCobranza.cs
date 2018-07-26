using Gestor.BizEntities;

namespace Gestor.API
{
    public interface IManagerCobranza
    {
        void Cobrar(ref Cobranza cobranza);
    }
}