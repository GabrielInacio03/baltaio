using System;
using System.Threading;

namespace Stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
        static void Menu()
        {
            Console.WriteLine("==============================");
            Console.WriteLine("_> Mão Na Massa: Cronômetro"
            + "\n S = Segundos => 10s = 10 segundos"
            + "\n M = Minutos => 1m = 1 minuto"
            + "\n 0 = SAIR"
            + "\n Quanto tempo deseja contar ?");
            Console.WriteLine("==============================");
            string data = Console.ReadLine().ToLower();

            char tipoTempo = char.Parse(data.Substring(data.Length - 1, 1));
            int time = int.Parse(data.Substring(0, data.Length - 1));
            int multiplier = 1;

            Console.WriteLine($"tipoTempo: {tipoTempo}");
            Console.WriteLine($"time: {time}");

            if (time == 0) System.Environment.Exit(0);

            if (tipoTempo == 'm') multiplier = 60;

            PreStart(time * multiplier);

        }
        static void PreStart(int time)
        {
            Console.Clear();
            Console.WriteLine("Ready...");
            Thread.Sleep(1000);
            Console.WriteLine("Set...");
            Thread.Sleep(1000);
            Console.WriteLine("GO...");
            Thread.Sleep(2500);

            Start(time);

        }
        static void Start(int time)
        {
            int currentTime = 0;
            while (currentTime != time)
            {
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime);
                Thread.Sleep(1000); //dormindo por 1 segundo
            }
            Console.Clear();
            Console.WriteLine("Stopwatch finalizado");
            Thread.Sleep(2000); //dormindo por 1 segundo
        }
    }
}
