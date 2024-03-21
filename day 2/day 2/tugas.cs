using System;

namespace day2
{
    internal class taskk
    {
        static void Main(string[] args)
        {
            //memasukkan nilai baris
            Console.Write("Masukkan jumlah baris matriks: ");
            int rows = int.Parse(Console.ReadLine());

            //memasukkan nilai kolom
            Console.Write("Masukkan jumlah kolom matriks: ");
            int cols = int.Parse(Console.ReadLine());

            int[][] matriks = new int[rows][];
            Console.WriteLine("Masukkan nilai matriks");

            for (int i = 0; i < matriks.Length; i++)
            {
                matriks[i] = new int[cols];
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

            int max = matriks[0][0];//misalkan angka awal 1
            int min = matriks[0][0];

            for (int i = 0; i < matriks.Length; i++)
            {
                for (int j = 0; j < matriks[i].Length; j++)
                {
                    if (matriks[i][j] > max) //misal matrik [0][0]=1 max[0][0]=1 
                        max = matriks[i][j]; //jika kondisi benar maka max diganti menjadi [i][j]
                    if (matriks[i][j] < min) 
                        min = matriks[i][j];
                }
            }

            Console.WriteLine("Nilai terbesar dari matriks: " + max);
            Console.WriteLine("Nilai terkecil dari matriks: " + min);

            Console.Read();
        }
    }
}
