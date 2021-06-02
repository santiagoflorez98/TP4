using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio3
{
    public class CompararPorEmailDescendente : IComparer<Usuario>
    {
        public int Compare(Usuario x, Usuario y)
        {
            if (x.CorreoElectronico.CompareTo(y.CorreoElectronico) != 0)
            { return x.CorreoElectronico.CompareTo(y.CorreoElectronico); }
            else return 0;
        }
    }
}
