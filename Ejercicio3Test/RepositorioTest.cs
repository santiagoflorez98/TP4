using Ejercicio3;
using System;
using Xunit;
using System.Collections.Generic;

namespace Ejercicio3Test
{
    public class RepositorioTest
    {
        [Fact]
        public void AgregarEnDiccionario()
        { RepositorioUsuario repositorio = new RepositorioUsuario();
            Usuario unUsuario = new Usuario("1", "juan", "juan@aa.com");
            repositorio.Agregar(unUsuario);
            repositorio.Agregar(new Usuario("2", "pedro", "sadsad@gmail.com"));
            Assert.Equal(2, repositorio.Repositorio.Count);
        }

        [Fact]
        public void EliminarDelDiccionario()
        {
            RepositorioUsuario repositorio = new RepositorioUsuario();
            Usuario unUsuario = new Usuario("1", "juan", "juan@aa.com");
            repositorio.Agregar(unUsuario);
            repositorio.Agregar(new Usuario("2", "pedro", "sadsad@gmail.com"));
            repositorio.Eliminar("2");
            Assert.Equal(1, repositorio.Repositorio.Count);
        }
        
        [Fact]
        public void ObtenerPorCodigoFunciona()
        {
            RepositorioUsuario repositorio = new RepositorioUsuario();
            Usuario unUsuario = new Usuario("1", "juan", "juan@aa.com");
            repositorio.Agregar(unUsuario);
            repositorio.Agregar(new Usuario("2", "pedro", "sadsad@gmail.com"));
            Assert.Equal(unUsuario, repositorio.ObtenerPorCodigo("1"));
        }
       
        [Fact]
        public void ObtenerPorCodigoError()
        {
            RepositorioUsuario repositorio = new RepositorioUsuario();
            Usuario unUsuario = new Usuario("1", "juan", "juan@aa.com");
            repositorio.Agregar(unUsuario);
            repositorio.Agregar(new Usuario("2", "pedro", "sadsad@gmail.com"));
            Assert.Equal(unUsuario, repositorio.ObtenerPorCodigo("2"));
        }
        [Fact]
        public void ObtenerTodosFunciona1()
        {
            RepositorioUsuario repositorio = new RepositorioUsuario();
            Usuario unUsuario = new Usuario("1", "juan", "juan@aa.com");
            repositorio.Agregar(unUsuario);
            repositorio.Agregar(new Usuario("2", "pedro", "sadsad@gmail.com"));
            repositorio.Agregar(new Usuario("3", "jorge","aaaaa@gmail.com"));
            Assert.Equal(3, repositorio.ObtenerTodos().Count);
        }
        [Fact]
        public void ObtenerTodosFuncionaYOrdena()
        {
            RepositorioUsuario repositorio = new RepositorioUsuario();
            Usuario unUsuario = new Usuario("1", "juan", "juan@aa.com");
            repositorio.Agregar(unUsuario);
            repositorio.Agregar(new Usuario("2", "pedro", "sadsad@gmail.com"));
            repositorio.Agregar(new Usuario("4", "jorge", "aaaaa@gmail.com"));
            Usuario otroUsuario = new Usuario("3", "simon", "aaaaaaa@gmail.com");
            repositorio.Agregar(otroUsuario);
            Assert.Equal(otroUsuario, repositorio.ObtenerTodos()[2]);
        }

        [Fact]
        public void ObtenerOrdenadosPorNombreFunciona()
        {
            IComparer<Usuario> comparadorNombre = new CompararPorNombreDescendente();
            RepositorioUsuario repositorio = new RepositorioUsuario();
            Usuario unUsuario = new Usuario("1", "juan", "juan@aa.com");
            repositorio.Agregar(unUsuario);
            repositorio.Agregar(new Usuario("2", "pedro", "sadsad@gmail.com"));
            repositorio.Agregar(new Usuario("4", "jorge", "aaaaa@gmail.com"));
            Usuario otroUsuario = new Usuario("3", "simon", "aaaaaaa@gmail.com");
            repositorio.Agregar(otroUsuario);
            Assert.Equal(unUsuario,repositorio.ObtenerOrdenadosPor(comparadorNombre)[1]);
        }
        [Fact]
        public void ObtenerOrdenadosPorNombreFunciona2()
        {
            IComparer<Usuario> comparadorNombre = new CompararPorNombreDescendente();
            RepositorioUsuario repositorio = new RepositorioUsuario();
            Usuario unUsuario = new Usuario("1", "juan", "juan@aa.com");
            repositorio.Agregar(unUsuario);
            repositorio.Agregar(new Usuario("2", "pedro", "sadsad@gmail.com"));
            repositorio.Agregar(new Usuario("4", "jorge", "aaaaa@gmail.com"));
            Usuario otroUsuario = new Usuario("3", "simon", "aaaaaaa@gmail.com");
            repositorio.Agregar(otroUsuario);
            Assert.Equal(otroUsuario, repositorio.ObtenerOrdenadosPor(comparadorNombre)[3]);
        }

        [Fact]
        public void ObtenerOrdenadosPorCorreoFunciona3()
        {
            IComparer<Usuario> comparadorEmail = new CompararPorEmailDescendente();
            RepositorioUsuario repositorio = new RepositorioUsuario();
            Usuario unUsuario = new Usuario("1", "juan", "euan@aa.com");
            repositorio.Agregar(unUsuario);
            repositorio.Agregar(new Usuario("2", "pedro", "badsad@gmail.com"));
            repositorio.Agregar(new Usuario("4", "jorge", "caaaa@gmail.com"));
            Usuario otroUsuario = new Usuario("3", "simon", "daaaaaa@gmail.com");
            repositorio.Agregar(otroUsuario);
            Assert.Equal(unUsuario, repositorio.ObtenerOrdenadosPor(comparadorEmail)[3]);
        }

        [Fact]
        public void ActualizarFunciona()
        {
            RepositorioUsuario repositorio = new RepositorioUsuario();
            Usuario unUsuario = new Usuario("1", "juan", "euan@aa.com");
            repositorio.Agregar(unUsuario);
            Usuario usuarioActualizado = new Usuario("1", "jose", "sdasda@aa.com");
            repositorio.Actualizar(usuarioActualizado);
            Assert.Equal("jose", repositorio.ObtenerPorCodigo("1").NombreCompleto);
        }
    }
}
