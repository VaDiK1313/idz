using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication77
{
    class Program
    {
        static void Main(string[] args)
        {
            int n; // Размерность массива
            int j, i; // Счетчики циклов
            int min;
            double tmp;


            System.Console.WriteLine();

            System.Console.WriteLine("Введите количество элементов массива:");
            n = Convert.ToInt32(Console.ReadLine());
            double[] a = new double[n]; // Формирование массива размера n

            System.Console.WriteLine("Вводите элементы:");
            for (j = 0; j < n; j++)
                a[j] = Convert.ToDouble(Console.ReadLine());// Ввод массива


            for (i = 0; i < n; i++)
            {
                min = i;
                // поиск минимума
                for (j = i; j < n; j++)
                    if (a[min] > a[j]) { min = j; }
                if (min != i) { tmp = a[min]; a[min] = a[i]; a[i] = tmp; }
            }
            System.Console.WriteLine();
            System.Console.WriteLine("Результат сортировки:");
            for (j = 0; j < n; j++)
                System.Console.WriteLine(a[j]);

            System.Console.ReadKey();
        }
    }
}
