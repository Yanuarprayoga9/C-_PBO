using learn.config;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace learn.service
{
    internal class Prodi
    {
        private string _id_prodi;
        private string _id_jurusan;
        private string _nama_prodi;
        DataTable data;

        ConnDB server;
        string Query;
        public int Id { get; set; }
        public string Nama { get; set; }
        public Prodi()
        {
          
        server = new ConnDB();
            data = new DataTable();
            Query = "";
        }
        public string IdProdi
        {
            get { return _id_prodi; }
            set { _id_prodi = value; }
        }

        public string IdJurusan
        {
            get { return _id_jurusan; }
            set { _id_jurusan = value; }
        }

        public string NamaProdi
        {
            get { return _nama_prodi; }
            set { _nama_prodi = value; }
        }


        public bool isExist (string id)
        {
            bool cek = false;
            Query = "select * from jurusan where id_prodi='" + id + "'";
            data = server.execQuery(Query);
            if (data.Rows.Count > 0)
            {
                cek = true;
            }
            return cek;
        }

        public int addData()
        {
            int result = -1;
            Query = $"insert into prodi (id_prodi,nama_prodi,id_jurusan) values('{_id_prodi}','{_nama_prodi}','{_id_jurusan}')";

            try
            {
                result = server.exec(Query);
                if (result < 0)
                {
                    throw new Exception("Data gagal disimpan.");
                }
            }
            catch (Exception e) { Console.WriteLine(e.Message); }
            return result;
        }
        public DataTable getAll()
        {
            Query = "select * from prodi";
            return server.execQuery(Query);

        }
        public DataTable getAllWithJurusan()
        {
            Query = "select p.* ,j.nama_jurusan as nama_jurusan from prodi p JOIN jurusan j ON p.id_jurusan = j.id_jurusan";
            return server.execQuery(Query);
        }

        public DataTable getComboJurusan()
        {
            Query = "select id_jurusan as id_jurusan,nama_jurusan as nama_jurusan from jurusan";
            return server.execQuery(Query);

        }


    }
}
