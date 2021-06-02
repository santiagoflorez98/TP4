using System;
using System.Collections.Generic;
using System.Text;
using Ejercicio5;
using Xunit;

namespace Ejercicio5Test
{
    public class TestEvaluadorAntiguedadLaboral
    {
        [Fact]
        public void EvaluadorAntiguedadLaboralFuncionaEnTrue()
        {
            Empleo unEmpleo = new Empleo(5000, new DateTime(2005, 05, 15));
            Cliente unCliente = new Cliente("Juan", "Martinez", new DateTime(1998, 07, 15), unEmpleo);
            EvaluadorAntiguedadLaboral evaluadorAntiguedadLaboral = new EvaluadorAntiguedadLaboral(6);
            SolicitudPrestamo unaSolicitud = new SolicitudPrestamo(6000, 18, unCliente);
            Assert.True(evaluadorAntiguedadLaboral.EsValida(unaSolicitud));
        }

        [Fact]
        public void EvaluadorAntiguedadLaboralFuncionaEnFalse()
        {
            Empleo unEmpleo = new Empleo(5000, new DateTime(2020, 08, 15));
            Cliente unCliente = new Cliente("Juan", "Martinez", new DateTime(1998, 07, 15), unEmpleo);
            EvaluadorAntiguedadLaboral evaluadorAntiguedadLaboral = new EvaluadorAntiguedadLaboral(6);
            SolicitudPrestamo unaSolicitud = new SolicitudPrestamo(6000, 18, unCliente);
            Assert.False(evaluadorAntiguedadLaboral.EsValida(unaSolicitud));
        }
    }
}
