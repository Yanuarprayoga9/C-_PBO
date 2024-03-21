using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using siper.config;
namespace siper.service
{
    internal class JurusanCls
    {
        private string _id;
        private string _nama;
        DataTable data;

        ConnDB server;
        string Query;

       

        public JurusanCls() {
            _id = "";
            _nama = "";
            server = new ConnDB();
            data = new DataTable();
            Query = "";
        }


        // aksesor dan mutator
        public string Id_Jurusan
        {
            set { _id = value; }
            get { return _id; }
        }

        public string Nama_Jurusan { 
            set { _nama = value; }
            get { return _nama; }
        }
        public bool apakahAda(string id)
        {
            bool cek = false;
            Query = "select * from jurusan where id_jurusan='" + id + "'";
            data = server.execQuery(Query);
            if (data.Rows.Count > 0) {
            cek= true;
            }
            return cek;

        }
        public int addData()
        {

            int result = -1;
            Query = $"insert into jurusan(id_jurusan, nama_jurusan) values('{_id}','{_nama}')";

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

        public int updateData(string id)
        {

            int result = -1;
            Query = $"update jurusan set nama_jurusan='{_nama}' where id_jurusan='{id}'";
            // Query = $"update jurusan set nama_jurusan = '{_nama}' where kode_jurusan='{id}'";

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

        public int deleteData(string id)
        {
            int result = -1;
            Query = $"delete from jurusan where id_jurusan='{id}'";

            try
            {
                result = server.exec(Query);
                if (result < 0)
                {
                    throw new Exception("Data gagal dihapus");
                }
            }
            catch (Exception e) { Console.WriteLine(e.Message); }
            return result;
        }
        public DataTable getAll()
        {
            Query = "select * from jurusan";
            return server.execQuery(Query);
            
        }

        /// <summary> 
        /// 
        /// </summary>
        /// <returns></returns>

    }
}
