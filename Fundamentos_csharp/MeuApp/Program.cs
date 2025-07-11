using System;

namespace MeuApp
{
    class Program
    {
        public const int MAO_NA_MASSA = 1;
        static void Main(string[] args)
        {
            Console.WriteLine("=========================");
            Console.WriteLine("Fundamentos C#");
            Console.WriteLine("=========================");
            var product = new Product(1, "Teste Produto", 5.70f);
            while (true)
            {
                Calculadora();
                Console.WriteLine("=========================");
                Console.WriteLine("Deseja continuar ?"
                + "\n 1- SIM"
                + "\n 2- NÃO");
                int op = int.Parse(Console.ReadLine());

                if (op == 2) break;

            }
            
        }
        static void Calculadora()
        {
            Console.WriteLine("_> Calculadora");
            Console.WriteLine();

            Console.WriteLine("Informe a Operação: "
            + "\n 1 - Soma"
            + "\n 2 - Subtração"
            + "\n 3 - Multiplicação"
            + "\n 4 - Divisão");

            int operacao = int.Parse(Console.ReadLine());

            Console.WriteLine("Agora informe o primeiro valor: ");
            int v1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Agora informe o segundo valor: ");
            int v2 = int.Parse(Console.ReadLine());

            switch (operacao)
            {
                case 1:
                    Soma(v1, v2);
                    break;
                case 2:
                    Subtracao(v1, v2);
                    break;
                case 3:
                    Multiplicacao(v1, v2);
                    break;
                case 4:
                    Divisao(v1, v2);
                    break;
                default:
                    Console.WriteLine("Não foi possível completar a operação, selecione uma válida");
                    break;
            }
        }
        static void Soma(int v1, int v2)
        {
            var final = v1 + v2;
            Console.WriteLine($"Resultado: {final}");
        }
        static void Subtracao(int v1, int v2)
        {
            var final = v1 - v2;
            Console.WriteLine($"Resultado: {final}");
        }
        static void Multiplicacao(int v1, int v2)
        {
            var final = v1 * v2;
            Console.WriteLine($"Resultado: {final}");
        }
        static void Divisao(int v1, int v2)
        {
            var final = v1 / v2;
            Console.WriteLine($"Resultado: {final}");
        }
    }
}
