using System;

namespace Contagem_Regressiva
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Clear();
            Console.WriteLine();

            Console.ReadKey();
            Console.ForegroundColor= ConsoleColor.Blue;
            
            Console.WriteLine("---------------");
            Console.WriteLine("/ Preparar... /");
            Console.WriteLine("---------------");
           
            Console.ReadKey();
            Console.ForegroundColor= ConsoleColor.Green;
            
            Console.WriteLine("--------------");
            Console.WriteLine("/ Apontar... / ");
            Console.WriteLine("-------------");
           
            Console.ReadKey();
            Console.ForegroundColor= ConsoleColor.Red;
           
            Console.WriteLine("---------");
            Console.WriteLine("/ Fogo! /");
            Console.WriteLine("--------");
           
            Console.ReadKey();
            Console.ForegroundColor= ConsoleColor.White;
        }
    }
}
