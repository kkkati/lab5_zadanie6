using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie6
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] array = new int[n, n];
            int i = 0;
            int j = 0;
            int sum_strok = 0;
            int[] m_sum_strok = new int[n];
            int sum_stolb = 0;
            int[] m_sum_stolb = new int[n];
            int diag1 = 0;
            int diag2 = 0;


            Console.WriteLine();

            //вводим массив
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    array[i, j] = Convert.ToInt32(Console.ReadLine());
                    
                }
                Console.WriteLine();
            }

            //выводим массив [n,n]
            for (i = 0; i < n; i++)
            {
                 for (j = 0; j < n; j++)
                 {
                    Console.Write("{0} ", array[i, j]);
                 }
                 Console.WriteLine();
            }

            Console.WriteLine();

            //считаем сумму строк
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    sum_strok += array[i, j];
                }
                m_sum_strok[i] = sum_strok;
                sum_strok = 0;
            }

            //считаем сумму столбцов
            for (j = 0; j < n; j++)
            {
                for (i = 0; i < n; i++)
                {
                    sum_stolb += array[i, j];
                }
                m_sum_stolb[j] = sum_stolb;
                sum_stolb = 0;
            }

            //выводим сумму строк
            Console.Write("Сумма строк ");
            for (i = 0; i < n; i++)
            {   
                Console.Write("{0} ", m_sum_strok[i]);
            }
            Console.WriteLine();

            //выводим сумму столбцов
            Console.Write("Сумма столбцов ");
            for (i = 0; i < n; i++)
            {
                Console.Write("{0} ", m_sum_stolb[i]);
            }
            Console.WriteLine();

            //сумма диагонали 1
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    if (i == j)
                    {
                        diag1 += array[i, j];
                    }
                }
            }
            Console.Write("Сумма 2-й диагонали {0}",diag1);
            Console.WriteLine();

            //сумма диагонали 2
            for (i = 0; i < n ; i++)
            {
                for (j =0; j <n; j++)
                {
                    if (i + j == n-1)
                    {
                        diag2 += array[i, j];
                    }
                }
            }
            Console.Write("Сумма 2-й диагонали {0}", diag2);
            Console.WriteLine();

            //Проверяем, равны ли суммы столбцов и строк
            int sum_mag1 = m_sum_strok[0];
            int sum_mag2 = m_sum_stolb[0];


            if (diag1 == diag2)
            {
                for (i = 0; i<n;i++)
                {
                    if (diag1==m_sum_strok[i] && diag1==m_sum_stolb[i])
                    {
                        
                    }
                }
                Console.Write("Матрица является магическим квадратом");

            }
            else
            {
                Console.Write("Матрица не является магическим квадратом");

            }




            Console.ReadKey();
            

        }
    }
}
