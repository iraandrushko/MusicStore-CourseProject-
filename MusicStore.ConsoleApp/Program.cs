using System;

namespace MusicStore.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            new Menu().ShowMenu();
            Console.ReadKey();
        }
    }
}