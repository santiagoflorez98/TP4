using System;
using Xunit;
using Ejercicio5;

namespace Ejercicio5Test
{
    public class TestEvaluadorEdad
    {
        [Fact]
        public void TestEvaluadorEdadFunciona()
        {
            Empleo unEmpleo = new Empleo(5000, new DateTime(2005, 05, 15));
            Cliente unCliente = new Cliente("Juan", "Martinez", new DateTime(1998, 07, 15), unEmpleo);
            EvaluadorEdad evaluadorEdad = new EvaluadorEdad(18, 75);
            SolicitudPrestamo unaSolicitud = new SolicitudPrestamo(6000, 18, unCliente);
            Assert.True(evaluadorEdad.EsValida(unaSolicitud));
        }
        [Fact]
        public void TestEvaluadorEdad18años()
        {
            Empleo unEmpleo = new Empleo(5000, new DateTime(2005, 05, 15));
            Cliente unCliente = new Cliente("Juan", "Martinez", new DateTime(2002, 07, 15), unEmpleo);
            EvaluadorEdad evaluadorEdad = new EvaluadorEdad(18, 75);
            SolicitudPrestamo unaSolicitud = new SolicitudPrestamo(6000, 18, unCliente);
            Assert.True(evaluadorEdad.EsValida(unaSolicitud));
        }
        [Fact]
        public void TestEvaluadorEdad75años()
        {
            Empleo unEmpleo = new Empleo(5000, new DateTime(2005, 05, 15));
            Cliente unCliente = new Cliente("Juan", "Martinez", new DateTime(1945, 07, 15), unEmpleo);
            EvaluadorEdad evaluadorEdad = new EvaluadorEdad(18, 75);
            SolicitudPrestamo unaSolicitud = new SolicitudPrestamo(6000, 18, unCliente);
            Assert.True(evaluadorEdad.EsValida(unaSolicitud));
        }
        [Fact]
        public void TestEvaluadorEdadMas75años()
        {
            Empleo unEmpleo = new Empleo(5000, new DateTime(2005, 05, 15));
            Cliente unCliente = new Cliente("Juan", "Martinez", new DateTime(1940, 07, 15), unEmpleo);
            EvaluadorEdad evaluadorEdad = new EvaluadorEdad(18, 75);
            SolicitudPrestamo unaSolicitud = new SolicitudPrestamo(6000, 18, unCliente);
            Assert.False(evaluadorEdad.EsValida(unaSolicitud));
        }
        [Fact]
        public void TestEvaluadorEdadMenos18años()
        {
            Empleo unEmpleo = new Empleo(5000, new DateTime(2005, 05, 15));
            Cliente unCliente = new Cliente("Juan", "Martinez", new DateTime(2004, 07, 15), unEmpleo);
            EvaluadorEdad evaluadorEdad = new EvaluadorEdad(18, 75);
            SolicitudPrestamo unaSolicitud = new SolicitudPrestamo(6000, 18, unCliente);
            Assert.False(evaluadorEdad.EsValida(unaSolicitud));
        }

    }
}

