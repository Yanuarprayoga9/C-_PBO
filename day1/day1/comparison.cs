using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day1
{
    internal class comparison
    {
        static void test(string[] args)
        {
            Console.WriteLine("test");
            Console.ReadKey();

        }
        static void Main (string[] args)
        {
            String a, b;
            bool lb;
            //bool  lk, lks, smd, tsm;
            int var_a, var_b;

            Console.Write("Masukkan nilai a : ");
            a = Console.ReadLine();
            Console.Write("Masukkan nilai b : ");
            b = Console.ReadLine();

            var_a = Convert.ToInt32(a);
            var_b = Convert.ToInt32(b);
            lb = (var_a == var_b);


            test(args);
            Console.WriteLine(lb ? "sama dengan" : "tidak sama dengan");
            Console.ReadKey();
            

        }
       
    }
}
