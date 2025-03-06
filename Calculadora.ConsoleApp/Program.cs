namespace Calculadora.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora Tabajara 2025");

            Console.Write("Digite o primeiro número: ");
            string primerioNumeroString = Console.ReadLine();
            int primeiroNumero = Convert.ToInt32(primerioNumeroString);

            Console.Write("Digite o segundo número: ");
            string segundoNumeroString = Console.ReadLine();
            int segundoNumero = Convert.ToInt32(segundoNumeroString);

            int resultado = primeiroNumero + segundoNumero;

            Console.WriteLine(resultado);

            Console.ReadKey();
        }
    }
}
