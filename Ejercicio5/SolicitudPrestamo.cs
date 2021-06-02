using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio5
{
    public class SolicitudPrestamo
    {
        private int iMonto;
        private int iCantidadCuotas;
        private Cliente iCliente;

        public SolicitudPrestamo(int pMonto, int pCantidadCuotas, Cliente pCliente)
        {
            this.iMonto = pMonto;
            this.iCantidadCuotas = pCantidadCuotas;
            this.iCliente = pCliente;       
        }
        public int Monto {get { return this.iMonto; } }
        public int CantidadCuotas {get { return this.iCantidadCuotas; } }
        public Cliente Cliente {get { return this.iCliente; } }
    }
}
