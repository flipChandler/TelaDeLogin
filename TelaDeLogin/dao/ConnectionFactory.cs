using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dao
{
    public class ConnectionFactory
    {
        public static MySqlConnection getConnection()
        {
            try
            {
                string url = "server=localhost;port=3306;user=root;password='';database=projeto_1";

                MySqlConnection conn = new MySqlConnection(url);
                conn.Open();

                return conn;

            }catch
            {
                throw new Exception("Falha na conexão");
            }

        }// fim getConnection


        public void disconnect()
        {
            if(getConnection().State == System.Data.ConnectionState.Open)
            {
                getConnection().Close();
            }
        }// fim disconnect
    }
}
