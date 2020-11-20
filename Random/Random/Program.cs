using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNum
{
    class Program
    {
        static void print(string msg)
        {
            Console.Write("[ ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("§");
            Console.ResetColor();
            Console.WriteLine(" ] "+msg);
        }
        static void printAndRead(string msg)
        {
            Console.Write("[ ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(">");
            Console.ResetColor();
            Console.Write(" ] " + msg);

        }
        static void Main(string[] args)
        {
            try
            {
                Console.WindowHeight = 15;
                Console.WindowWidth = 45;
            }
            catch (Exception)
            {

                throw;
            }
            print("Welcome to generator by DimDima09!");
            printAndRead("Please, type minimum number: ");

            string min = Console.ReadLine();
            int minimum = Int32.Parse(min);
            Console.Title = $"Minimum: {min}";

            printAndRead("Please, type maximum number: ");
            string max = Console.ReadLine();
            int maximum = Int32.Parse(max);

            printAndRead("Please, type console clear count: ");
            string deletes = Console.ReadLine();
            int deletess = Int32.Parse(deletes);
            Console.Title = $"Minimum: {min}, Maximum: {max}, Clear count: {deletess}";
            int wait = 10;
            int a = 1;
            for (int i = 0; i < deletess; i++)
            {
                Random rd = new Random();
                Console.Clear();
                Console.WriteLine($"Number: {rd.Next(minimum, maximum).ToString()}\n\nClear count: {a}");
                a++;
                System.Threading.Thread.Sleep(wait);
                wait += deletess+10;
            }
            Console.Write("Your number is ready!");
            Console.ReadKey();
            Process.Start("https://vk.com/DimDima09/");
        }
    }
}
