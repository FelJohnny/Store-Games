using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca_de_Games.Conexoes;


namespace Biblioteca_de_Games.Apresentacao_telas_
{
    public partial class CadastreSe : Form
    {
        public CadastreSe()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            LoginCadastro objUsuario = new LoginCadastro();
            objUsuario.login = txtLogin.Text;
            objUsuario.senha = txtConfirmarsenha.Text;
            objUsuario.nome_completo = txtNomeCompleto.Text;

            if (txtSenha.Text == txtConfirmarsenha.Text)
            {
                if (objUsuario.cadastrar(objUsuario.login, objUsuario.senha, objUsuario.nome_completo) == true)
                {
                    MessageBox.Show("Usuário Cadastrado!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Usuário já existe!");

                }
            }
            else
            {
                MessageBox.Show("As senhas não combinam! Favor verificar");
            }

        }
        

    }
}
