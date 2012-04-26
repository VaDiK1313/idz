using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;


namespace IDZ
{
        class RadixSorting
    {
        public static void sorting(int[] arr, int range, int length)
        {
            ArrayList[] lists = new ArrayList[range];
            for (int i = 0; i < range; ++i)
                lists[i] = new ArrayList();

            for (int step = 0; step < length; ++step)
            {
                //распределение по спискам
                for (int i = 0; i < arr.Length; ++i)
                {
                    int temp = (arr[i] % (int)Math.Pow(range, step + 1)) /
                                                  (int)Math.Pow(range, step);
                    lists[temp].Add(arr[i]);
                }
                //сборка
                int k = 0;
                for (int i = 0; i < range; ++i)
                {
                    for (int j = 0; j < lists[i].Count; ++j)
                    {
                        arr[k++] = (int)lists[i][j];
                    }
                }
                for (int i = 0; i < range; ++i)
                    lists[i].Clear();
            }
        }
    }

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
            int u;
	do 
	{	
        Console.WriteLine("||                     MENU                   ||");
		Console.WriteLine("||============================================||");
		Console.WriteLine ("||       Radix Sorting             - 1        ||"); 
		Console.WriteLine("||       Quick Soring              - 2        ||"); 
		Console.WriteLine("||       Sorting by simple choice  - 3        ||"); 
		Console.WriteLine(  "||       Exit                      - 0        ||");
		Console.WriteLine("||============================================||");
		Console.WriteLine("                    CHOICE");
        u = Convert.ToInt32(Console.ReadLine()); ;
		Console.WriteLine("------------------------------------------------");
		if ((u!=0) && (u!=1) && (u!=2) && (u!=3))
		{	
			Console.WriteLine("Invalid choice! Try again");
			Console.ReadKey();
            Console.Clear(); 
			
		}
		else
		{
		if (u==1)
		{
            int n; // Размерность массива
            int j; // Счетчики циклов
            System.Console.WriteLine("                  Radix Sorting");

            System.Console.WriteLine();

            System.Console.WriteLine("Enter count of elements:");
            n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n]; // Формирование массива размера n

            System.Console.WriteLine("Enter the elements:");
            for (j = 0; j < n; j++)
                arr[j] = Convert.ToInt32(Console.ReadLine());// Ввод массива


            System.Console.WriteLine("The array before sorting:");
            foreach (double x in arr)
            {
                System.Console.Write(x + " ");
            }
            RadixSorting.sorting(arr, 10, 2);
            System.Console.WriteLine("\n\nThe array after sorting:");
            foreach (double x in arr)
            {
                System.Console.Write(x + " ");
            }
            System.Console.WriteLine("\n\nPress the <Enter> key");
            System.Console.ReadLine();
            Console.Clear(); 
        }
   

		

        // Devil9725
		else if (u==2)
        {

            System.Console.WriteLine("\n\nPress the <Enter> key");
            System.Console.ReadLine();
            Console.Clear();
		}  
     


        //Vlad77
		else if (u==3)
		{
            
            System.Console.WriteLine("\n\nPress the <Enter> key");
            System.Console.ReadLine();
            Console.Clear();	
		}       
		
		else if (u==0)	
		{	
		Console.WriteLine("Exit!");
		Console.ReadLine();
        Console.Clear();

			
		}       
		}
		   
	}while(u!=0);

        }
    }
}
