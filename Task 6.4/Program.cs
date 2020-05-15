using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6._4
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите размерность массива:");
                int n = Convert.ToInt32(Console.ReadLine());
                int[][] mass = new int[n][];
                for (int i = 0; i < n; i++)
                {
                    mass[i] = new int[n];

                }
                Random r = new Random();

                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        mass[i][j] = r.Next(1, 10);
                        Console.Write(mass[i][j] + " ");
                    }
                    Console.WriteLine();
                }

                int[] m = new int[n];
                for (int i = 0; i < n; i++)
                {
                    m[i] = -1;
                }

                for (int i = 0; i < n; i++)
                {
                    for (int k = 0; k < n - 1; k++)
                    {
                        for (int j = k + 1; j < n; j++)
                        {
                            if (mass[j][i] == mass[k][i])
                            {
                                m[i] = k;
                                k = n;
                                break;
                            }

                        }
                    }
                }
                Console.WriteLine();
                Console.WriteLine("Номера первой пары одинаковых элементов:");
                for (int i = 0; i < n; i++)
                {
                    Console.Write(m[i] + " ");
                }
            }
            catch (Exception E)
            {
                Console.WriteLine(E.Message);
            }
           Console.ReadKey();
        }
    }
}
