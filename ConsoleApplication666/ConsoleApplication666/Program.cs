using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplication666
{
    class Program
    {
        static void qs(int[] a, int l, int h)
        {
            int i = l; int j = h;
            int x = a[l + (h - l) / 2];
            do
            {
                while (a[i] < x)
                    ++i;
                while (x < a[j])
                    --j;
                if (i <= j)
                {
                    if (i < j)
                    {
                        int t = a[i];
                        a[i] = a[j];
                        a[j] = t;
                    }
                    ++i; --j;
                }
            } while (i <= j);
            if (l < j)
                qs(a, l, j);
            if (i < h)
                qs(a, i, h);
        }


        static void Main(string[] args)
        {
            int n;
            System.Console.WriteLine("enter the size of massive: ");
            n = int.Parse(Console.ReadLine());
            int[] a = new int[n];

            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }

            qs(a, 0, n - 1);

            for (int i = 0; i < n; i++)
            {
                System.Console.WriteLine("# " + i + " - " + a[i]);

            }

            System.Console.ReadKey();
        }
    }
}
