using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konversi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aplikasi Konversi Waktu");
            Console.WriteLine("------------------------");

            // Konversi waktu dari detik ke jam, menit, dan detik
            Console.Write("Masukkan waktu dalam detik: ");
            int detik = Convert.ToInt32(Console.ReadLine());

            int jam = detik / 3600;//dikali 36000
            int sisaDetik = detik % 3600; // modulus 3600
            int menit = sisaDetik / 60;
            int detikSisa = sisaDetik % 60;

            Console.WriteLine($"Hasil konversi: {jam} jam, {menit} menit, {detikSisa} detik");

            Console.WriteLine();

            Console.WriteLine("Aplikasi Konversi Suhu");
            Console.WriteLine("------------------------");

            // Konversi suhu dari Celcius (C) ke Fahrenheit (F), Reamur (R), dan Kelvin (K)
            Console.Write("Masukkan suhu dalam Celcius: ");
            double suhuC = Convert.ToDouble(Console.ReadLine());

            //rumus farenheit
            double suhuF = suhuC * 9 / 5 + 32;

            //rumus reamur
            double suhuR = suhuC * 4 / 5;

            //kelvin
            double suhuK = suhuC + 273.15;

            Console.WriteLine($"Hasil konversi:");
            Console.WriteLine($"Fahrenheit: {suhuF} F");
            Console.WriteLine($"Reamur: {suhuR} R");
            Console.WriteLine($"Kelvin: {suhuK} K");

            Console.ReadLine(); // Tunggu input sebelum menutup konsol
        }
    }
}
