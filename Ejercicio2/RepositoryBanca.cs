using System.Collections.Generic;

namespace Ejercicio2
{
    public class RepositoryBanca
    {
        private List<Banca> iRepositorio;
        /// <summary>
        /// Inicializa el repositorio creando la lista.
        /// </summary>
        public RepositoryBanca()
        { this.iRepositorio = new List<Banca>(); }

        /// <summary>
        /// Agrega aBanca al repositorio
        /// </summary>
        /// <param name="aBanca"></param>
        public void agregarBanca(Banca aBanca)
        { this.iRepositorio.Add(aBanca); }

        /// <summary>
        /// Busca una banca por su iNumero utilizando el pNumero
        /// </summary>
        /// <param name="pNumero"></param>
        /// <returns>La banca tal que aBanca.numero==pNumero. CuentaNoEncontradaException si la banca no existe</returns>
        public Banca obtenerBanca(string pNumero)
        {
            if (!this.iRepositorio.Exists(aBanca => aBanca.numero == pNumero))
            { throw new CuentaNoEncontradaException("No se encontro la cuenta indicada"); }
            return (this.iRepositorio.Find(aBanca => aBanca.numero == pNumero));
        }

    }


}
