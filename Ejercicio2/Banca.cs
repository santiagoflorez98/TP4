namespace Ejercicio2
{
    public class Banca
    {
        private string iNumero;
        private string iTitular;
        private Cuenta iCuentaEnPesos;
        private Cuenta iCuentaEnDolares;

        /// <summary>
        /// Crea una nueva instancia del objeto Banca.
        /// </summary>
        /// <param name="pNumero"></param>
        /// <param name="pTitular"></param>
        /// <param name="pCuentaP"></param>
        /// <param name="pCuentaD"></param>
        public Banca(string pNumero, string pTitular, Cuenta pCuentaP, Cuenta pCuentaD)
        {
            iNumero = pNumero;
            iTitular = pTitular;
            iCuentaEnPesos = pCuentaP;
            iCuentaEnDolares = pCuentaD;
        }

        /// <summary>
        /// Devuelve el atributo iCuentaEnPesos de la instancia de banca.
        /// </summary>
        public Cuenta cuentaEnPesos { get { return iCuentaEnPesos; } }
        /// <summary>
        /// Devuelve el atributo iCuentaEnDolares de la instancia de banca.
        /// </summary>
        public Cuenta cuentaEnDolares { get { return iCuentaEnDolares; } }
        /// <summary>
        /// Devueve el atributo iTitular de la instancia de banca.
        /// </summary>
        public string titular { get { return iTitular; } }
        /// <summary>
        /// Devuelve el atributo iNumero de la instancia de banca.
        /// </summary>
        public string numero { get { return iNumero; } }

        /// <summary>
        /// Verifica primero si hay fondos suficientes en la cuenta en pesos para hacer la transferencia, si la hay hace la conversión necesaria y realiza la transferencia 
        /// </summary>
        /// <param name="unaCantidadEnPesos"></param>
        /// <returns></returns>
        public void transferirDesdePesosADolares(double unaCantidadEnPesos)
        {
            this.cuentaEnPesos.DebitarSaldo(unaCantidadEnPesos);
            double unaCantidadEnDolares = unaCantidadEnPesos / 70;
            this.cuentaEnDolares.AcreditarSaldo(unaCantidadEnDolares);


        }/// <summary>
         /// Verifica primero si hay fondos suficientes en la cuenta en dólares para hacer la transferencia, si la hay hace la conversión necesaria y realiza la transferencia 
         /// </summary>
         /// <param name="unaCantidadEnDolares"></param>
         /// <returns></returns>
        public void transferirDesdeDolaresAPesos(double unaCantidadEnDolares)
        {
            this.cuentaEnDolares.DebitarSaldo(unaCantidadEnDolares);
            double unaCantidadEnPesos = unaCantidadEnDolares * 70;
            this.cuentaEnPesos.AcreditarSaldo(unaCantidadEnPesos);
        }

    }
}
