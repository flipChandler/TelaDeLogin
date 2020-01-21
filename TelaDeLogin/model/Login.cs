using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model
{
    public class Login
    {
        private int id;
        private string usuario;
        private string senha;

        public Login(string usuario, string senha)
        {
            this.usuario = usuario;
            this.senha = senha;
        }

        public Login()
        {

        }

        public int getId()
        {
            return this.id;
        }

        public void setId(int id)
        {
            this.id = id;
        }

        public string getUsuario()
        {
            return this.usuario;
        }

        public void setUsuario(string usuario)
        {
            this.usuario = usuario;
        }

        public string getSenha()
        {
           return this.senha;
        }

        public void setSenha(string senha)
        {
            this.senha = senha;
        }
    }
}
