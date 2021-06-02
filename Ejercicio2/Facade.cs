namespace Ejercicio2
{/// <summary>
/// Clase fachada del Ejercicio2
/// </summary>
    public class Facade
    {
        RepositoryBanca unRepositorio = new RepositoryBanca();
        Moneda monedaDolar = new Moneda("840", "dolar", "$");
        Moneda monedaPesos = new Moneda("3", "peso", "$");
        /// <summary>
        /// Crea las cuentas del usuario y con ellas, mas el pNumero y el pTitular crea una nueva banca y la adhiere a su repositorio
        /// </summary>
        /// <param name="pNumero"></param>
        /// <param name="pTitular"></param>
        public void crearCuentaUnificada(string pNumero, string pTitular)
        {
            Cuenta pCuentaP = new Cuenta(monedaPesos);
            Cuenta pCuentaD = new Cuenta(monedaDolar);

            Banca nuevaBanca = new Banca(pNumero, pTitular, pCuentaP, pCuentaD);
            unRepositorio.agregarBanca(nuevaBanca);
        }

        /// <summary>
        /// Busca la cuenta en el repositorio utilizando el pNumero.
        /// </summary>
        /// <param name="pNumero"></param>
        /// <param name="pTipoMoneda"></param>
        /// <returns>El saldo de la cuenta según el tipo de moneda ingresado en pTipoMoneda</returns>
        public double getSaldoCuenta(string pNumero, string pTipoMoneda)
        {
            Banca unaBanca = unRepositorio.obtenerBanca(pNumero);
            if (pTipoMoneda == "Pesos")
            { return unaBanca.cuentaEnPesos.Saldo; }
            else { return unaBanca.cuentaEnDolares.Saldo; }
        }
        /// <summary>
        /// Busca la Banca en el repositorio utilizando el pNumero y llama a la operacion DebitarSaldo de la cuenta en pesos.
        /// </summary>
        /// <param name="pNumero"></param>
        /// <param name="pCantidad"></param>
        /// <returns>true si DebitarSaldo devuelve true y devuelve false si DebitarSaldo devuelve false</returns>
        public double debitarCuentaPesos(string pNumero, double pCantidad)
        {
            Banca unaBanca = unRepositorio.obtenerBanca(pNumero);
            unaBanca.cuentaEnPesos.DebitarSaldo(pCantidad);
            return unaBanca.cuentaEnPesos.Saldo;
        }
        /// <summary>
        /// Busca la banca en el repositorio utilizando el pNumero y llama a la operacion AcreditarSaldo de la cuenta en pesos.
        /// </summary>
        /// <param name="pNumero"></param>
        /// <param name="pCantidad"></param>
        /// <returns>El nuevo saldo en pesos de la banca buscada.</returns>
        public double acreditarCuentaPesos(string pNumero, double pCantidad)
        {
            Banca unaBanca = unRepositorio.obtenerBanca(pNumero);
            unaBanca.cuentaEnPesos.AcreditarSaldo(pCantidad);
            return unaBanca.cuentaEnPesos.Saldo;
        }
        /// <summary>
        /// Busca la Banca en el repositorio utilizando el pNumero y llama a la operacion DebitarSaldo de la cuenta en dolares.
        /// </summary>
        /// <param name="pNumero"></param>
        /// <param name="pCantidad"></param>
        /// <returns> true si DebitarSaldo devuelve true y devuelve false si DebitarSaldo devuelve false</returns>
        public double debitarCuentaDolares(string pNumero, double pCantidad)
        {
            Banca unaBanca = unRepositorio.obtenerBanca(pNumero);
            unaBanca.cuentaEnDolares.DebitarSaldo(pCantidad);
            return unaBanca.cuentaEnDolares.Saldo;
        }
        /// <summary>
        /// Busca la banca en el repositorio utilizando el pNumero y llama a la operacion AcreditarSaldo de la cuenta en dolares.
        /// </summary>
        /// <param name="pNumero"></param>
        /// <param name="pCantidad"></param>
        /// <returns>El nuevo saldo en dolares de la banca buscada</returns>
        public double acreditarCuentaDolares(string pNumero, double pCantidad)
        {
            Banca unaBanca = unRepositorio.obtenerBanca(pNumero);
            unaBanca.cuentaEnDolares.AcreditarSaldo(pCantidad);
            return unaBanca.cuentaEnDolares.Saldo;
        }
        /// <summary>
        /// Busca la banca en el repositorio utilizando el pNumero, convierte la pCantidad en dolares y llama a debitarCuentaPesos con la nueva cantidad.
        /// </summary>
        /// <param name="pNumero"></param>
        /// <param name="pCantidad"></param>
        /// <returns>true si transferirDesdePesosADolares devuelve true, false en caso contrario</returns>
        public void transferirPesosADolares(string pNumero, double pCantidad)
        {
            Banca unaBanca = unRepositorio.obtenerBanca(pNumero);
            unaBanca.transferirDesdePesosADolares(pCantidad);
        }

        /// <summary>
        /// Busca la banca en el repositorio y le aplica la operacion de transferenia asignada. 
        /// </summary>
        /// <param name="pNumero"></param>
        /// <param name="pCantidad"></param>
        /// <returns>True si transferirDesdeDolaresAPesos devuelve true, false en caso contrario</returns>

        public void transferirDolaresAPesos(string pNumero, double pCantidad)
        {
            Banca unaBanca = unRepositorio.obtenerBanca(pNumero);
            unaBanca.transferirDesdeDolaresAPesos(pCantidad);
        }



    }
}
