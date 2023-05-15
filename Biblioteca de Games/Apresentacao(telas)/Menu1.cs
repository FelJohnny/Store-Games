using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Biblioteca_de_Games.Apresentacao_telas_
{
    public partial class Menu1 : Form
    {
        public Menu1()
        {
            InitializeComponent();

        }
        // Botão fechar do Menu1
        private void btnFechar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Encerrar a Aplicação?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                
                System.Environment.Exit(0);
                

            }
            else
            {
                
            }
            

        }
     

        private void Menu1_Load(object sender, EventArgs e)
        {
            
        }
        //declarando o que vai acontecer com o form à ser aberto quando ocorrer o click
        private void AbrirNoFormulario<Forms>() where Forms : Form, new()
        {
            Form formulario;
            formulario = panelConteudo.Controls.OfType<Forms>().FirstOrDefault();
            
            if (formulario == null)
            {
                formulario = new Forms();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                panelConteudo.Controls.Add(formulario);
                panelConteudo.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }
            else
            {
                if (formulario.WindowState == FormWindowState.Minimized)
                    formulario.WindowState = FormWindowState.Normal;
                formulario.BringToFront();
            }


        }
        //abre o Formulario Loja
        private void btnLoja_Click(object sender, EventArgs e)
        {
           
            AbrirNoFormulario<Loja>();
        }
        //abre a biblioteca de jogos
        private void button1_Click(object sender, EventArgs e)
        {
            AbrirNoFormulario<MeusJogos>();
        }
        //minimiza o prog
        private void brnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirNoFormulario<Opcoes>();
        }
        //realiza o logoff e abre o form principal
        //btnlogin na verdade é btnlogoff
        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Close();
            Principal log = new Principal();

            log.Show();
        }
    }
}
