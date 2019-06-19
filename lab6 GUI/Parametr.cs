using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6_GUI
{
    class Parametr
    {
        private int m;
        private int max;
        public string result = "";
        public Parametr(int a, int b)
        {
            this.m = a;
            this.max = b;
        }
        public void Work()
        {
            Form1 f = new Form1();
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
                    result += a[i] + " ";
            }
            Console.WriteLine("");
        }
    }
}
