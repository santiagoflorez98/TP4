﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio3
{
    public class CompararPorNombreDescendente : IComparer<Usuario>
    {public int Compare(Usuario x, Usuario y)
        {if (x.NombreCompleto.CompareTo(y.NombreCompleto) != 0)
            { return x.NombreCompleto.CompareTo(y.NombreCompleto); }
            else return 0;
        }
    }
}
