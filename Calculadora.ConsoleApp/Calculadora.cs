namespace Calculadora.ConsoleApp
{
    public static class Calculadora
    {
        static int sessao = default;
        static string[] operacoes = new string[100];
        public static decimal Somar(decimal primeiroNumero, decimal segundoNumero)
        {
            decimal resultado = primeiroNumero + segundoNumero;
            operacoes[sessao] = $"{primeiroNumero} + {segundoNumero} = {resultado}";
            sessao++;
            return resultado;
        }

        public static decimal Subtrair(decimal primeiroNumero, decimal segundoNumero)
        {
            decimal resultado = primeiroNumero - segundoNumero;
            operacoes[sessao] = $"{primeiroNumero} - {segundoNumero} = {resultado}";
            sessao++;
            return resultado;
        }
        public static decimal Multiplicar(decimal primeiroNumero, decimal segundoNumero)
        {
            decimal resultado = primeiroNumero * segundoNumero;
            operacoes[sessao] = $"{primeiroNumero} * {segundoNumero} = {resultado}";
            sessao++;
            return resultado;

        }
        public static decimal Dividir(decimal primeiroNumero, decimal segundoNumero)
        {
            decimal resultado = primeiroNumero / segundoNumero;
            operacoes[sessao] = $"{primeiroNumero} / {segundoNumero} = {resultado}";
            sessao++;
            return resultado;
        }

        public static string[] ObterHistoricoDeOperacoes()
        {
           return operacoes;
        }
    }
}
