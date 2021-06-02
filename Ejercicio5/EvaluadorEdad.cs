using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio5
{
    public class EvaluadorEdad : IEvaluador
    {
        private int iEdadMinima;
        private int iEdadMaxima;

        public EvaluadorEdad(int pEdadMinima, int pEdadMaxima)
        {
            this.iEdadMinima = pEdadMinima;
            this.iEdadMaxima = pEdadMaxima;
        }
        public bool EsValida(SolicitudPrestamo pSolicitud)
        {
            int edadActual = Convert.ToInt32((DateTime.Today - pSolicitud.Cliente.FechaNacimiento).TotalDays / 365);
                return edadActual <= this.iEdadMaxima && edadActual >= this.iEdadMinima; }


    }
}
