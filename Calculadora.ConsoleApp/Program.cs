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
                Console.WriteLine("3 - Multiplicação");
                Console.WriteLine("4 - Divisão");
                Console.WriteLine("S - Sair");

                Console.Write("Escolha uma opção: ");
                string opcao = Console.ReadLine();

                if (opcao.ToUpper() == "S")
                {
                    break;
                }

                Console.Write("Digite o primeiro número: ");
                string primerioNumeroString = Console.ReadLine();
                decimal primeiroNumero = Convert.ToDecimal(primerioNumeroString);

                Console.Write("Digite o segundo número: ");
                string segundoNumeroString = Console.ReadLine();
                decimal segundoNumero = Convert.ToDecimal(segundoNumeroString);

                decimal resultado = default;

                if (opcao == "1")
                {
                    resultado = primeiroNumero + segundoNumero;
                }
                else if (opcao == "2")
                {
                    resultado = primeiroNumero - segundoNumero;
                }
                else if (opcao == "3")
                {
                    resultado = primeiroNumero * segundoNumero;
                }
                else if (opcao == "4")
                {
                    //if (segundoNumero != 0)
                    //{
                    //    resultado = primeiroNumero / segundoNumero;
                    //}
                    //else
                    //{
                    //    Console.WriteLine("Não é possível dividir um número por zero.");
                    //    Console.ReadKey();
                    //    continue;
                    //}
                    if(segundoNumero == 0)
                    {
                        Console.WriteLine("Não é possível dividir um número por zero.");
                        Console.ReadKey();
                        continue;
                    }
                    resultado = primeiroNumero / segundoNumero;
                }
                    Console.WriteLine("--------------------------------------");
                Console.WriteLine("Resultado: " + resultado.ToString("F2"));
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
