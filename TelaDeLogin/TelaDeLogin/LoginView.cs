using controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelaDeLogin
{
    public partial class LoginView : Form
    {
        public LoginView()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           try
            {
                string usuario = txtUsuario.Text;
                string senha = txtSenha.Text;

                LoginController loginController = new LoginController();
                string retornoController = loginController.fazerLoginController(usuario, senha);

                if(retornoController == "sucesso")
                {
                    this.Hide();
                    MenuView menuView = new MenuView();
                    menuView.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show(retornoController,"Erro: ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                }
            }
            catch
            {
                MessageBox.Show(null, "Erro: ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
