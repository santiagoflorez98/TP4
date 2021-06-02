using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio5
{
    public class Empleo
    {
        private double iSueldo;
        private DateTime iFechaIngreso;
        public Empleo(double pSueldo, DateTime pFechaIngreso)
        {
            this.iSueldo = pSueldo;
            this.iFechaIngreso = pFechaIngreso;
        }
        public double Sueldo {get { return this.iSueldo; } }
        public DateTime FechaIngreso {get { return this.iFechaIngreso; } }
    }
}
