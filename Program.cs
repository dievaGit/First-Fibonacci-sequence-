using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaring variables
            ulong[] a = new ulong[100];
            ulong num = 0; 
            int  n = 0;

            a[0] = 0;
            a[1] = 1;

            //Requesting limit
            Console.Write(" Enter the number limit for the series Fibonacci: ");
            n = Convert.ToInt32(Console.ReadLine());

            //Calculated
            for (int i = 1; i < n; i++)
            {

                a[i + 1] = a[i] + num;
                num = a[i];

            }

            //Showing results
            Console.WriteLine(" La serie Fibonacci: ");
            for (int j = 0; j < 9; j++)
            {
                Console.Write(" {0}", a[j]);
            }

            Console.ReadKey();
        }
    }
}
