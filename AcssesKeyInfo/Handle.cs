using System;
using System.Threading;

namespace AcssesKeyTest
{
    public class Handle
    {
        public static void HandleMenuOption(int option)
        {
            //testing rules
            Console.Clear();
            Menu.DrawScreen();
            if (option == 0)
            {
                Console.SetCursorPosition(3, 2);
                Console.WriteLine("Saindo...");
                Console.SetCursorPosition(3, 3);
                Thread.Sleep(600);
                Console.Clear();
                System.Environment.Exit(0);
            }

            switch (option)
            {
                case 1: Info.Show(); break;
                default: Menu.Show(); break;
            }

        }
    }
}
