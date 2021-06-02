using System;

namespace Ejercicio1
{
    public class DivisionPorCeroException : Exception
    {
        public DivisionPorCeroException(string pCadena) : base(pCadena)
        { }

    }
}
