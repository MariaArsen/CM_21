using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CM_21
{
    class Program
    {
        const int n = 4;
        const int m = 4;
       static int[,] paths = new int[n, m] { { 1, 3, 3, 5 }, { 2, 4, 6, 2 }, { 2, 2, 3, 2 }, {1, 4, 2, 1 } };
        static void Main(string[] args)
        {
            ThreadStart threadStart = new ThreadStart(Gardner1);
            Thread thread = new Thread(threadStart);
            thread.Start();

            Gardner2();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"{paths[i, j]} ");
                }
            }
            Console.ReadKey();
        }
        static void Gardner1()
        {
            for (int i = 0; i < n; i++)
            {
                {
                    for (int j = 0; j < m; j++)
                    {
                        if (paths[i, j] >= 0)
                        {
                            int delay = paths[i, j];
                            paths[i, j] = -1;
                            Thread.Sleep(delay);
                        }
                    }
                }
            }
        }
          static void Gardner2()
          {
            for (int i = n - 1; i > 0; i--)
            {
                {
                    for (int j = m - 1; j >0; j--)
                    {
                        if (paths[i, j] >= 0)
                        {
                            int delay = paths[i, j];
                            paths[i, j] = -2;
                            Thread.Sleep(delay);
                        }
                    }
                }

            }
                   
          }
    }
}
