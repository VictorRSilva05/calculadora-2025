using System.Runtime.CompilerServices;
using System.Threading.Channels;

namespace Calculadora.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string opcao = ExibirMenu();

                if (OpcaoSairEscolhida(opcao) is true)
                    break;

                else if (OpcaoTabuadaEscolhida(opcao))
                    ExibirTabuada();

                else if (OpcaoHistoricoEscolhida(opcao))
                    ExibirHistorico();

                else
                {
                    ExibirResultado(RealizarCalculo(opcao));
                    Console.ReadKey();
                }
            }
        }

        static string ExibirMenu()
        {
            Console.Clear();

            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Calculadora Tabajara 2025");
            Console.WriteLine("--------------------------------------");

            Console.WriteLine("1 - Somar");
            Console.WriteLine("2 - Subtrair");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            Console.WriteLine("5 - Tabuada");
            Console.WriteLine("6 - Histórico das operações");
            Console.WriteLine("S - Sair");

            Console.Write("Escolha uma opção: ");
            string opcao = Console.ReadLine().ToUpper();

            return opcao;
        }

        static bool OpcaoSairEscolhida(string opcao)
        {
            bool opcaoSairEscolhida = opcao == "S";
            return opcaoSairEscolhida;
        }

        static bool OpcaoTabuadaEscolhida(string opcao)
        {
            bool opcaoTabuadaEscolhida = opcao == "5";
            return opcaoTabuadaEscolhida;
        }

        static void ExibirTabuada()
        {
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Tabuada");
            Console.WriteLine("--------------------------------------");

            Console.Write("Digite o número: ");
            int numeroTabuada = Convert.ToInt32(Console.ReadLine());

            for (int contador = 1; contador <= 10; contador++)
            {
                int resultadoTabuada = numeroTabuada * contador;

                Console.WriteLine($"{numeroTabuada} x {contador}  = {resultadoTabuada}");
            }

            Console.ReadKey();
        }

        static bool OpcaoHistoricoEscolhida(string opcao)
        {
            bool opcaoHistoricoEscolhida = opcao == "6";
            return opcaoHistoricoEscolhida;
        }

        static void ExibirHistorico()
        {
            string[] operacoes = Calculadora.ObterHistoricoDeOperacoes();

            foreach (var item in operacoes)
            {
                if (item is not null)
                    Console.WriteLine(item);
            }
            Console.ReadKey();
        }

        static decimal RealizarCalculo(string operacao)
        {
            Console.Write("Digite o primeiro número: ");
            decimal primeiroNumero = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            decimal segundoNumero = Convert.ToDecimal(Console.ReadLine());

            decimal resultado = default;

            if (operacao == "1")
            {
                resultado = Calculadora.Somar(primeiroNumero, segundoNumero);
            }
            else if (operacao == "2")
            {
                resultado = Calculadora.Subtrair(primeiroNumero, segundoNumero);
            }
            else if (operacao == "3")
            {
                resultado = Calculadora.Multiplicar(primeiroNumero, segundoNumero);
            }
            else if (operacao == "4")
            {
                if (segundoNumero == 0)
                {
                    Console.WriteLine("Não é possível dividir um número por zero.");
                    Console.ReadKey();
                }
                resultado = Calculadora.Dividir(primeiroNumero,segundoNumero);
            }
          return resultado;
        }

        static void ExibirResultado(decimal resultado)
        {
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Resultado: " + resultado.ToString("F2"));
            Console.WriteLine("--------------------------------------");
        }
    }
}
