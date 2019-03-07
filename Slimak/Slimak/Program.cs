using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slimak
{
    class Program
    {
        static void Main()
        {
            int a;
            int b;
            int count = 0;

            Console.Write("Podaj rozmiar tablicy:");
            a = Convert.ToInt32(Console.ReadLine());
            b = a;
            int[,] tablica = new int[a, a];

            for (int i = 0; i <= b / 2; i++)
            {
                //poziomo w prawo
                for (int j = i; j < a; j++)
                {
                    tablica[i, j] = count;
                    count++;
                }

                //pionowo w dol
                for (int k = i + 1; k < a; k++)
                {
                    tablica[k, a - 1] = count;
                    count++;
                }

                //poziomo w lewo
                for (int q = a - 2; q >= i; q--)
                {
                    tablica[a - 1, q] = count;
                    count++;
                }

                //pionowo w gore
                for (int w = a - 2; w > i; w--)
                {
                    tablica[w, i] = count;
                    count++;
                }
                a--;
            }

            //wysiwetlanie tablicy
            for (int z = 0; z < b; z++)
            {
                for (int x = 0; x < b; x++)
                {
                    Console.Write("{0},", tablica[z, x]);
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
