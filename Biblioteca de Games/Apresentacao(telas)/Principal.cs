using Biblioteca_de_Games.Apresentacao_telas_;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca_de_Games
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            CadastreSe cad = new CadastreSe();
            cad.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Conexoes.LoginCadastro objusuario = new Conexoes.LoginCadastro();

            objusuario.login = txtLogin.Text;
            objusuario.senha = txtSenha.Text;
            


            if (objusuario.logar(objusuario.login , objusuario.senha)==true)
            {
                
                MessageBox.Show("Bem vindo!");

                Menu1 abrir = new Menu1();
                abrir.Show();
                this.WindowState = FormWindowState.Minimized;
                

            }
            else
            {

                MessageBox.Show("Usuario incorreto! /n Tente novamente");

            }
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Encerrar a Aplicação?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                System.Environment.Exit(0);
                
            }
            else
            {
                
            }
        }
    }
}
