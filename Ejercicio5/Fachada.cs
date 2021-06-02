using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio5
{
    public class Fachada
    {
        private GestorPrestamos unGestor = new GestorPrestamos();

        public bool EsValida(SolicitudPrestamo pSolicitud)
        { return unGestor.EsValida(pSolicitud); }

        public void CambiarTipoCliente(TipoCliente pTipo,Cliente pCliente)
        { pCliente.TipoCliente = pTipo; }
    }
}
