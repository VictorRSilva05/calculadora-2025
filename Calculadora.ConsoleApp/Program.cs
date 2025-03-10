namespace Calculadora.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();

                Console.WriteLine("--------------------------------------");
                Console.WriteLine("Calculadora Tabajara 2025");
                Console.WriteLine("--------------------------------------");

                Console.WriteLine("1 - Somar");
                Console.WriteLine("2 - Subtrair");
                Console.WriteLine("S - Sair");

                Console.Write("Escolha uma opção: ");
                string opcao = Console.ReadLine();

                if (opcao.ToUpper() == "S")
                {
                    break;
                }

                Console.Write("Digite o primeiro número: ");
                string primerioNumeroString = Console.ReadLine();
                int primeiroNumero = Convert.ToInt32(primerioNumeroString);

                Console.Write("Digite o segundo número: ");
                string segundoNumeroString = Console.ReadLine();
                int segundoNumero = Convert.ToInt32(segundoNumeroString);

                int resultado = default;

                if (opcao == "1")
                {
                    resultado = primeiroNumero + segundoNumero;
                }

                else
                {
                    resultado = primeiroNumero - segundoNumero;
                }

                Console.WriteLine("--------------------------------------");
                Console.WriteLine("Resultado: " + resultado);
                Console.WriteLine("--------------------------------------");

                Console.WriteLine("Deseja continuar (S/N)");
                string opcaoContinuar = Console.ReadLine().ToUpper();

                if(opcaoContinuar != "S")
                {
                    break;
                }
            }
        }
    }
}
