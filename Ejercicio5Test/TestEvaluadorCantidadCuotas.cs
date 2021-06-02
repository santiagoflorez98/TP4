using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Ejercicio5;

namespace Ejercicio5Test
{
    public class TestEvaluadorCantidadCuotas
    {[Fact]
        public void TestEvaluadorCantidadCuotasFuncionaEsTrue()
        {
            Empleo unEmpleo = new Empleo(5000, new DateTime(2020, 08, 15));
            Cliente unCliente = new Cliente("Juan", "Martinez", new DateTime(1998, 07, 15), unEmpleo);
            EvaluadorCantidadCuotas evaluadorCuotas = new EvaluadorCantidadCuotas(12);
            SolicitudPrestamo unaSolicitud = new SolicitudPrestamo(6000, 12, unCliente);
            Assert.True(evaluadorCuotas.EsValida(unaSolicitud));
        }
        [Fact]
        public void TestEvaluadorCantidadCuotasFuncionaEsFalse()
        {
            Empleo unEmpleo = new Empleo(5000, new DateTime(2020, 08, 15));
            Cliente unCliente = new Cliente("Juan", "Martinez", new DateTime(1998, 07, 15), unEmpleo);
            EvaluadorCantidadCuotas evaluadorCuotas = new EvaluadorCantidadCuotas(12);
            SolicitudPrestamo unaSolicitud = new SolicitudPrestamo(6000, 15, unCliente);
            Assert.False(evaluadorCuotas.EsValida(unaSolicitud));
        }

    }
}
