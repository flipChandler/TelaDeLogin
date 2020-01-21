using dao;
using model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controller
{
    public class LoginController
    {
        public string fazerLoginController(string usuario, string senha)
        {
            Login login = new Login(usuario, senha);

            LoginDAO loginDAO = new LoginDAO();
            string retornoDAO = loginDAO.fazerLoginDAO(login);

            return retornoDAO;

        }
    }
}
