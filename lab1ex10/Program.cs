using System;

namespace lab1ex10
{
    /*Scrieti un program care sa va afisa suma cifrelor ununi numar intreg citit de la tastatura*/


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Acest program va calcula suam cifrelor unui numar intreg. \n");

            Console.WriteLine("Introduceti un numar intreg de 2 cifre:");
            var nr = int.Parse(Console.ReadLine());

            var sum = nr / 10 + nr%10;

            Console.WriteLine("Suma cifrelor este: " + sum);
        }
    }
}
