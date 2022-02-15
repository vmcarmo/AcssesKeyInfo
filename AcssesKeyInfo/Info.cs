using System;
using System.Threading;

namespace AcssesKeyTest
{
    public class Info
    {
        static public void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;

            Menu.DrawScreen();
            Options();
        }
        public static void Options()
        {
            Console.SetCursorPosition(3, 2);
            Console.WriteLine("INFORMAÇÕES");
            Console.SetCursorPosition(3, 3);
            Console.WriteLine("=======================================");
            Console.SetCursorPosition(3, 4);
            Console.WriteLine("Digite a chave de acesso da Nota Fiscal");
            Console.SetCursorPosition(3, 8);
            Console.Write("Chave de acesso: ");
            var key = Console.ReadLine();

            var maxLength = key.Length;
            if (maxLength != 44)
            {
                var i = 4;
                while (i > 1)
                {
                    Console.Clear();
                    Menu.DrawScreen();
                    i--;
                    Console.SetCursorPosition(3, 2);
                    Console.WriteLine("Chave de acesso incompleta ou errada!");
                    Console.SetCursorPosition(3, 3);
                    Console.WriteLine($"Aguarde e digite novamente. {i}");
                    Console.SetCursorPosition(3, 4);
                    Thread.Sleep(1000);
                    Console.Clear();
                }
                Info.Show();
            }
            Info.WriteOptions(key);
        }

        public static void WriteOptions(string key)
        {
            Console.Clear();
            Menu.DrawScreen();
            var number = key.Substring(25, 9);
            var serie = key.Substring(22, 3);
            var cnpj = key.Substring(6, 14);
            var issue = key.Substring(2, 2);
            var monthIssue = key.Substring(4, 2);
            var state = key.Substring(0, 2);
            var model = key.Substring(20, 2);
            var selection = "Modelo não encontrado.";

            if (model == "55")
                selection = "Modelo 55 | NFe - Nota fiscal de material.";

            if (model == "57")
                selection = "Modelo 57 | CTe - Conhecimento de transporte.";

            // Console.WriteLine("---------------------------------------------");
            Console.SetCursorPosition(3, 2);
            Console.WriteLine("INFORMAÇÕES NOTA FISCAL");
            Console.SetCursorPosition(3, 4);
            Console.WriteLine($"Número: {number}-{serie}");
            Console.SetCursorPosition(3, 5);
            Console.WriteLine($"Modelo: {selection}");
            Console.SetCursorPosition(3, 6);
            Console.WriteLine($"CNPJ do Emissor: {cnpj}");
            Console.SetCursorPosition(3, 7);
            Console.WriteLine($"Emissão: {monthIssue}/{issue}");
            Console.SetCursorPosition(3, 8);
            Console.WriteLine($"Codigo do Estado do Emissor: {state}");
            Console.SetCursorPosition(3, 10);
            // Console.WriteLine("---------------------------------------------");

            Console.WriteLine("Aperte qualquer tecla para voltar ao menu.");
            Console.SetCursorPosition(3, 11);
            Console.ReadKey();
            Menu.Show();
        }
    }
}
