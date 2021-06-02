using Ejercicio3;
using System;
using Xunit;

namespace Ejercicio3Test
{
    public class UsuarioTest
    {
        [Fact]
        public void CompareToCompara()
        {
            Usuario unUser = new Usuario("1", "Lolo Gomez","aaa@aaa.com");
            unUser.Codigo = "1";
            unUser.CorreoElectronico = "";
            unUser.NombreCompleto = "";
            Usuario otroUser = new Usuario("3","Lolo Gutierrez","aaaa@aaaa.com");
            Assert.True(unUser.CompareTo(otroUser) < 0);

        }
    }
}
