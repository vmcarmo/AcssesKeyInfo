using System;
using System.Threading;

namespace AcssesKeyTest
{
    public static class Menu
    {
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;

            DrawScreen();
            WriteOptions();

        }

        public static void WriteOptions()
        {
            Console.SetCursorPosition(3, 2);
            Console.WriteLine("MENU");
            Console.SetCursorPosition(3, 3);
            Console.WriteLine("===============================");
            Console.SetCursorPosition(3, 4);
            Console.WriteLine("Selecione a opção desejada.");
            Console.SetCursorPosition(3, 6);
            Console.WriteLine("1 - Informações da Nota Fiscal.");
            Console.SetCursorPosition(3, 8);
            Console.WriteLine("0 - Sair.");
            Console.SetCursorPosition(3, 10);
            Console.Write("Opção: ");
            var option = int.Parse(Console.ReadLine());

            Handle.HandleMenuOption(option);
        }

        public static void DrawScreen()
        {
            Console.Write("+");
            for (int i = 0; i <= 100; i++)//quantidade linhas superior
                Console.Write("-");
            Console.Write("+");

            Console.Write("\n");

            for (int lines = 0; lines <= 10; lines++)
            {
                Console.Write("|");
                for (int i = 0; i <= 100; i++)//quantidade de espaços.
                    Console.Write(" ");

                Console.Write("|");
                Console.Write("\n");
            }

            Console.Write("+");
            for (int i = 0; i <= 100; i++)//quantidade linhas inferior
                Console.Write("-");
            Console.Write("+");
        }
    }
}
