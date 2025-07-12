using System;
using System.IO;
using System.Threading;

namespace EditorDeTexto
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("=============================");
            Console.WriteLine("Editor de Texto");
            Console.WriteLine("=============================");
            Console.WriteLine("O que você deseja fazer ? "
            + "\n0 - Sair"
            + "\n1 - Abrir Arquivo"
            + "\n2 - Criar Novo Arquivo");

            int option = int.Parse(Console.ReadLine());
            switch (option)
            {
                case 0:
                    Console.WriteLine("Saindo do programa...");
                    System.Environment.Exit(0);
                    break;
                case 1:
                    Abrir();
                    break;
                case 2:
                    Editar();
                    break;
                default:
                    Console.WriteLine("Opção Invalida");
                    System.Environment.Exit(0);
                    break;
            }
        }
        static void Abrir()
        {
            Console.Clear();
            string path = "C:\\workspace_pessoal\\baltaio\\Fundamentos_csharp\\EditorDeTexto\\arquivoTexto.txt";

            if (!File.Exists(path))
            {
                Console.WriteLine($"O Arquivo no caminho {path} não exite");
                Thread.Sleep(2500);
                Menu();
            }
            else
            {
                using (var file = new StreamReader(path)) // StreamReader -> ler
                {
                    string text = file.ReadToEnd();
                    Console.WriteLine(text);
                }
            }

            Console.WriteLine("");
            Console.ReadLine();
            Menu();
        }

        static void Editar()
        {
            Console.Clear();
            Console.WriteLine("Digite seu texto abaixo: (ESC para sair)");
            Console.WriteLine("----------");
            string texto = null;

            do
            {
                texto += Console.ReadLine();
                texto += Environment.NewLine;
            } while (Console.ReadKey().Key != ConsoleKey.Escape);

            Console.Write(texto);
            Console.WriteLine("Deseja salvar ?"
            + "\n1- SIM"
            + "\n2 - NÃO");

            Salvar(texto);
            
        }
        static void Salvar(string texto)
        {
            Console.Clear();
            string path = "C:\\workspace_pessoal\\baltaio\\Fundamentos_csharp\\EditorDeTexto\\arquivoTexto.txt";

            using (var file = new StreamWriter(path)) //StreamWriter -> fluxo de escrita
            {
                file.Write(texto);
            } //ja abre e fecha o arquivo e/ou banco etc

            Console.WriteLine($"Arquivo Salvo com sucesso em {path}");
            Thread.Sleep(2500);
            Menu();
        }
    }
}
