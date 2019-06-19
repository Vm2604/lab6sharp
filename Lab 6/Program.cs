using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lab_6
{
    class Program
    {       
        static void Main(string[] args)
        {
            int size_interval = 0;

            Console.WriteLine("Please enter diapason");            
            int digit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your diapason: " + digit);
            size_interval = digit / 2;
            
            Parametr p_1 = new Parametr(2, size_interval);
            Parametr p_2 = new Parametr(2, digit);
            Thread t = new Thread(new ThreadStart(p_1.Work));
            t.Start();

            p_2.Work();      

            Console.ReadKey();
        }        
    }

    class Parametr
    {
        private int m;
        private int max;

        public Parametr(int a, int b)
        {
            this.m = a;
            this.max = b;
        }

        public void Work()
        {
            int[] a = new int[max];
            for (int i = 0; i < max; i++)
            {
                a[i] = i;
            }
            a[1] = 0;            
            int j = 0;
            while (m < max)
            {
                if (a[m] != 0)
                    j = m * 2;
                while (j < max)
                {
                    a[j] = 0;
                    j = j + m;
                }
                m += 1;
            }
            for (int i = 0; i < max; i++)
            {
                if (a[i] != 0)
                    Console.Write(a[i] + " ");
            }
            Console.WriteLine("");
        }
    }

}


