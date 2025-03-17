namespace Calculadora.ConsoleApp
{
    public static class Calculadora
    {
        public static decimal Somar(decimal primeiroNumero, decimal segundoNumero)
        {
            return primeiroNumero + segundoNumero;
        }

        public static decimal Subtrair(decimal primeiroNumero, decimal segundoNumero)
        {
            return primeiroNumero - segundoNumero;
        }
        public static decimal Multiplicar(decimal primeiroNumero, decimal segundoNumero)
        {
            return primeiroNumero * segundoNumero;
        }
        public static decimal Dividir(decimal primeiroNumero, decimal segundoNumero)
        {
            return primeiroNumero / segundoNumero;
        }
    }
}
