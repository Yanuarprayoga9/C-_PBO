using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace siper.config
{
    // change from Conn to ConnDB
    // KoneksiDB_cls();
    internal class ConnDB : Configuration_Cls
    {
        MySqlConnection conn;
        MySqlCommand cmd;
        MySqlDataAdapter adapter;


        string link = "server=localhost;port=3306;database=siper;uid=root;pwd=";


        // change from Conn to ConnDB
        // KoneksiDB_cls(); common mhs

        public ConnDB()
        {
            conn = new MySqlConnection(link);
            cmd = new MySqlCommand();
            adapter = new MySqlDataAdapter();    
        }



        void openCon()
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
            }catch (Exception ex)
            {

            }

        }
        void closeCon()
        {
            
                    conn.Close();

        }



        public override int exec(string query)
        {
            int result = -1;
            try
            {
                openCon();
                cmd.Connection = conn;
                cmd.CommandText = query;
                result = cmd.ExecuteNonQuery();
            }catch (Exception ex)
            {

            }
            finally
            {
                closeCon();
            }
            return result;
        }

        public override DataTable execQuery(string query)
        {
            DataTable result = new DataTable();
            try
            {
                openCon();
                cmd.Connection = conn;
                cmd.CommandText = query;
                adapter.SelectCommand = cmd;
                adapter.Fill(result);
            }
            catch (Exception ex)
            {

            }
            finally
            {
                closeCon();
            }
            return result;
        }
    }
}
