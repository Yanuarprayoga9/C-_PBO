using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learn.config
{
    abstract class Konfigurasi
    {
        public abstract int exec(string query);

        //untuk menangani intruksi SELECT 
        public abstract DataTable execQuery(string query);
    }
}
