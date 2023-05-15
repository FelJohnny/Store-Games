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
using Npgsql;

namespace Biblioteca_de_Games.Apresentacao_telas_
{
    public partial class Loja : Form
    {
        public Loja()
        {
            InitializeComponent();
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAddBiblioteca5_Click(object sender, EventArgs e)
        {

        }

        public void btnNaruto_Click(object sender, EventArgs e)
        {
            Autenticacao abrir = new Autenticacao();
            MessageBox.Show("Para segurança de sua conta insira o usuario e senha");
            abrir.Show();

        }
    }
}
