using System.Collections.Generic;

namespace Ejercicio3
{
    public interface IRepositorioUsuarios
    {
        public void Agregar(Usuario pUsuario);
        public void Actualizar(Usuario pUsuario);
        public void Eliminar(string pCodigo);
        public IList<Usuario> ObtenerTodos();
        public Usuario ObtenerPorCodigo(string pCodigo);
        public IList<Usuario> ObtenerOrdenadosPor(IComparer<Usuario> pComparador);

    }
}
