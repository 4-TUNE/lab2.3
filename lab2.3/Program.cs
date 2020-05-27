using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication19
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.Write("N=");

            int n = int.Parse(Console.ReadLine());

            int[] a = new int[n];
            ////////////////////////
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Виводим масив =");
            for (int i = 0; i < a.Length; i++)
            {

                Console.Write(a[i] + " ");
            }



            int min = a.Min(t => Math.Abs(t));
            Console.WriteLine("Мiнiмальний елемент по модулю = {0}", min, Array.IndexOf(a, Math.Abs(min)));


            int last = 0;
            int first = 0;
            for (int i = 0; i < n; i++)
            {
                if (a[i] == 0)
                {
                    first = i;
                    break;
                }
            }
            for (int i = n - 1; i >= 0; i--)
            {
                if (a[i] == 0)
                {
                    last = i;
                    break;
                }
            }
            int sum = 1;
            for (int i = first + 1; i < last; i++)

            {
                sum = sum * a[i];

            }
            Console.WriteLine(sum);
        }
    }
}