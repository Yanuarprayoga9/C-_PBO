using learn.config;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learn.service
{
    internal class Jurusan
    {
        DataTable data;

        ConnDB server;
        string Query;
        public Jurusan()
        {

            server = new ConnDB();
            data = new DataTable();
            Query = "";
        }

        public DataTable getAll()
        {
            Query = "select * from jurusan";
            return server.execQuery(Query);

        }
    }
}
