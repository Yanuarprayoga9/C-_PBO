using System;

namespace day2
{
    internal class looping
    {
        static void Main(string[] args)
        {
            int[][] matriks = new int[3][];
            Console.WriteLine("Masukkan nilai matriks");
            for (int i = 0; i < matriks.Length; i++)
            {
                matriks[i] = new int[3];
                for (int j = 0; j < matriks[i].Length; j++)
                {
                    Console.Write("matriks[{0}][{1}] = ", i, j);
                    matriks[i][j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine();
            Console.WriteLine("Menampilkan nilai matriks");

            for (int i = 0; i < matriks.Length; i++)
            {
                for (int j = 0; j < matriks[i].Length; j++)
                {
                    Console.Write("{0}\t", matriks[i][j]);
                }
                Console.WriteLine();
            }
            Console.Read();
        }
    }
}
