using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinhaDeProducao.view
{
    public partial class PaginaLogin : Form
    {
        public PaginaLogin()
        {
            InitializeComponent();
        }

        private void PaginaLogin_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {


                string email = textBoxEmail.Text;
                string senha = textBoxSenha.Text;

                Funcionarios funcionario = new Funcionarios();

                funcionario.email = email;
                funcionario.SetSenha(senha);

                funcionario.GetFuncionariosPorEmailESenha();

                if (funcionario.logado)
                {
                    this.Hide();

                    PaginaPrincipal paginaPrincipal = new PaginaPrincipal();

                    paginaPrincipal.Show();
                }
                else
                {
                    throw new Exception("Erro ao realizar login, credenciais incorretas ou não encontradas");
                }

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

        }
    }
}
