using model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dao
{
    public class LoginDAO
    {
        public string fazerLoginDAO(Login login)
        {
            try
            {
                string sql = "SELECT * FROM login WHERE usuario = @usuario AND senha = @senha";

                MySqlCommand mySqlCmd = new MySqlCommand(sql, ConnectionFactory.getConnection());

                mySqlCmd.Parameters.AddWithValue("@usuario", login.getUsuario());
                mySqlCmd.Parameters.AddWithValue("@senha", login.getSenha());
                
                MySqlDataReader mySqlDtReader = mySqlCmd.ExecuteReader();

                while (mySqlDtReader.Read())
                {
                    if (mySqlDtReader.HasRows)
                    {
                        return "sucesso";
                    }
                }

                return "Dados não encontrados";


            }catch
            {
                throw new Exception("Problemas na conexão!");
            }
        }
    }
}
