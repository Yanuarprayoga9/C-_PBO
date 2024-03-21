using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day1
{
    internal class operators
    {
        static void Main (string[] args)
        {
            String nim, nama;
            double n_absen, n_tugas, n_uts, n_uas, n_akhir;

            Console.WriteLine("Hitung Nilai Akhir");
            Console.WriteLine("-------------------");

            Console.Write("Nim : \t");
            nim = Console.ReadLine();
            Console.Write("Nama : \t");
            nama = Console.ReadLine();
            Console.WriteLine("-------------- Nilai --------------");
            Console.Write("absen :\t");
            n_absen = Convert.ToDouble(Console.ReadLine());
            Console.Write("Tugas :\t");
            n_tugas = Convert.ToDouble(Console.ReadLine());
            Console.Write("Uts :\t");
            n_uts = Convert.ToDouble(Console.ReadLine());
            Console.Write("Uas :\t");
            n_uas = Convert.ToDouble(Console.ReadLine());


            n_akhir = (n_absen * 0.1) + (n_tugas * 0.2) + (n_uts * 0.3) + (n_uas * 0.4);

            Console.WriteLine("-------------------------------");
            Console.Write("Nilai Akhir  = ");
            Console.WriteLine(n_akhir);
            Console.ReadKey();

        }
    }
}
