using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {  
        static void funcMatric(int[,] mt, int n, int m)
        {
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    mt[i, j] = rnd.Next(0, 10);
                }
            }
        }
        static void OutputMatric(int[,] mt, int n, int m)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(mt[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        static void UmnojenieMatric(int[,] matric1, int[,] matric2, int[,] matric3, int n1, int n2, int m1, int m2)
        {
            if (n2 == m1)
            {
                for (int i = 0; i < n1; i++)
                {
                    for (int j = 0; j < m2; j++)
                    {
                        matric3[i, j] = 0;
                        for (int k = 0; k < m1; k++)
                        {
                            matric3[i, j] += matric1[i, k] * matric2[k, j];
                        }
                        Console.Write(matric3[i, j] + " ");
                    }
                    Console.WriteLine();
                }
            }
            else
            {
            Console.WriteLine("Ошибка");
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Введите кол-во строк 1-й матрицы: ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите кол-во столбцов 1-й матрицы:");
            int m1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите кол-во строк 2-й матрицы: ");
            int n2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите кол-во столбцов 2-й матрицы: ");
            int m2 = Convert.ToInt32(Console.ReadLine());
            int[,] matric1 = new int[n1, m1];
            int[,] matric2 = new int[n2, m2];
            int[,] matric3 = new int[n1, m2];
            funcMatric(matric1, n1, m1);
            Console.WriteLine("Матрица 1");
            OutputMatric(matric1, n1, m1);
            funcMatric(matric2, n2, m2);
            Console.WriteLine("Матрица 2");
            OutputMatric(matric2, n2, m2);
            Console.WriteLine("Перемножение матриц");
            UmnojenieMatric(matric1, matric2, matric3, n1, m1, n2, m2);
        }
    }
}
