namespace Ejercicio2
{
    public class Cuenta
    {
        private double iSaldo;
        private Moneda iMoneda;
        /// <summary>
        /// Crea una instancia de Cuenta y le asigna a iMoneda la Moneda que se le pasa como parámetro
        /// </summary>
        /// <param name="pMoneda"></param>
        public Cuenta(Moneda pMoneda)
        {
            this.iSaldo = 0;
            this.iMoneda = pMoneda;
        }

        /// <summary>
        /// Crea una instancia de Cuenta, le asigna a iMoenda la Moneda que se pasa como parámetro y a iSaldo la cantidad que se le pasa como parámetro
        /// </summary>
        /// <param name="pSaldo"></param>
        /// <param name="pMoneda"></param>
        public Cuenta(double pSaldo, Moneda pMoneda)
        {
            this.iSaldo = pSaldo;
            this.iMoneda = pMoneda;
        }
        /// <summary>
        /// Devuelve el atributo iSaldo de la instancia de Cuenta.
        /// </summary>
        public double Saldo { get { return iSaldo; } }
        /// <summary>
        /// Devuelve el atributo iMoneda de la instancia de Cuenta.
        /// </summary>
        public Moneda Moneda { get { return iMoneda; } }

        /// <summary>
        /// Le suma al atributo iSaldo la cantidad pSaldo que se pasa como parámetro.
        /// </summary>
        /// <param name="pSaldo"></param>
        public void AcreditarSaldo(double pSaldo)
        { this.iSaldo = this.Saldo + pSaldo; }
        /// <summary>
        /// Si pSaldo es menor que el atributo iSaldo, le descuenta a iSaldo la cantidad pSaldo, caso devuelve un SaldoInsuficienteException.
        /// </summary>
        /// <param name="pSaldo"></param>
        /// <returns></returns>

        public void DebitarSaldo(double pSaldo)
        {
            if (this.iSaldo >= pSaldo)
            {
                this.iSaldo = this.Saldo - pSaldo;
            }
            else { throw new SaldoInsuficienteException("El saldo de la cuenta es insuficiente para realizar la operacion"); };
        }

    }
}
