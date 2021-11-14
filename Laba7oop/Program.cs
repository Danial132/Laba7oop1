using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Laba7oop
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] mas = new int[6, 4];

            Console.WriteLine("Заполни матрицу");

            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write("mas[" + i + "," + j + "]: ");
                    mas[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine();

            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(" mas[" + i + "," + j + "]: " + mas[i, j] + "\t");

                }
                Console.WriteLine();
            }
            Console.WriteLine("Transformed:");
            for (int i = 0; i < mas.GetLength(1); i++)
            {
                var tmp = mas[3, i];
                mas[3, i] = mas[1, i];
                mas[1, i] = tmp;
            }
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(" mas[" + i + "," + j + "]: " + mas[i, j] + "\t");

                }
                Console.WriteLine();
            }
        }
    }
}
