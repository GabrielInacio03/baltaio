using System;
using System.Globalization;
using System.Text;

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
            var pt = new CultureInfo("pt-BR");
            var ptt = new CultureInfo("pt-PT");
            var enUs = new CultureInfo("en-US");
            var atual = CultureInfo.CurrentCulture;
            Console.WriteLine(DateTime.Now.ToString("D", atual));

            //unidade de medida universal para calculo de horas, diferença de horas...
            var timeSpan = new TimeSpan();
            timeSpan.CompareTo(DateTime.Now);

            /*
            var data = new DateTime(2025, 07, 16, 21, 07, 15);
            //var data = DateTime.Now;
            Console.WriteLine(data);
            Console.WriteLine(data.Year);
            Console.WriteLine(data.Month);
            Console.WriteLine(data.Day);
            Console.WriteLine(data.Hour);

            if (data.Date == DateTime.Now.Date) Console.WriteLine("data são iguais");


            Console.WriteLine($"{data.DayOfWeek} => {(int)data.DayOfWeek}");
            var formatada = String.Format("{0:s}", data);
            Console.WriteLine($"Data Formatada: {formatada}");
            */
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
