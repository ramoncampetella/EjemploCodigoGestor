using System;

namespace Gestor.Common
{
    public class FunctionalException : Exception
    {
        public FunctionalException(string descripcion) : base(descripcion)
        { }
    }
}
