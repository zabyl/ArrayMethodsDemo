using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayMethodsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 22, 11, 5, 84, 73, 5, 13, 19 };

            Console.WriteLine("unaligned numbers of array");

            foreach (var number in numbers)
            {

                Console.Write(number + " ");

            }

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("sort method");
            Array.Sort(numbers);

            foreach (var number in numbers)
            {
                Console.Write(number + " ");
            }


            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("clear method");
            Array.Clear(numbers, 3, 2);

            foreach (var number in numbers)
            {
                Console.Write(number + " ");
            }

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("reverse method");
            Array.Reverse(numbers);

            foreach (var number in numbers)
            {
                Console.Write(number + " ");
            }

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("index of");
            Console.WriteLine(Array.IndexOf(numbers, 73));

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("resize");
            Array.Resize<int>(ref numbers, 6);

            foreach (var number in numbers)
            {
                Console.Write(number + " ");
            }


            Console.ReadLine();
        }
    }
}
