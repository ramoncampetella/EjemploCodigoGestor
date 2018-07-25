using System;
using System.Collections.Generic;
using System.Text;

namespace Gestor.Interfaces.Externas
{
    public interface ICuotaCobradaServiceAdapter
    {
        void RegistrarPago(Cuota cuota);
    }
}
