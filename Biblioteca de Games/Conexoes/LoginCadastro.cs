using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Security.Cryptography;
using Biblioteca_de_Games.Apresentacao_telas_;


namespace Biblioteca_de_Games.Conexoes
{

    class LoginCadastro
    {

        public string login;
        public string senha;
        public string nome_completo;

        // Declara os GET e SET (DESATIVADOO!!!!!!!!!!!)
        /* public String Login
         {
             get
             {
                 return this.login;
             }
             set
             {
                 this.login = value;
             }
         }
         public String Senha
         {
             get
             {
                 return this.senha;
             }
             set
             {
                 this.senha = value;
             }
         }
         public String Nome_Completo
         {
             get
             {
                 return this.nome_completo;
             }
             set
             {
                 this.login = value;
             }
         } */




        //Local onde se inicia a verificação do login e senha inserido está certo ou errado
        public bool logar(string login, string senha)
        {
            //abre a conexão com o banco instanciando o ConexaoDB para o objconexao e executando o  comando pgsqlConnection
            NpgsqlConnection pgsqlConnection = null;

            ConexaoDB objconexao = new ConexaoDB();
            pgsqlConnection = objconexao.getConexao();

            pgsqlConnection.Open();


            //monta o comando sql
            string sql = "select * from tbl_usuario where login='" + login + "' and senha='" + senha + "';";
            //atribui ao cmd a string 'sql' e a conexão a ser utilizada
            NpgsqlCommand cmd = new NpgsqlCommand(sql, pgsqlConnection);

            //exacuta-se o sql e declara um DataReader para receber a matriz de valores
            NpgsqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {


                if (login == dr["login"].ToString() && senha == dr["senha"].ToString())
                {

                    return true;
                }
                else
                {
                    return false;

                }



            }
            else
            {

                return false;
            }

        }




        public bool cadastrar(string login, string senha, string nome_completo)
        {
            //abre a conexão com o banco instanciando o ConexaoDB para o objconexao e executando o  comando pgsqlConnection
            NpgsqlConnection pgsqlConnection = null;

            ConexaoDB objconexao = new ConexaoDB();
            pgsqlConnection = objconexao.getConexao();

            pgsqlConnection.Open();

            if (autenticar(login) == true)
            {
                //monta o comando sql
                string sql = "INSERT INTO tbl_usuario (login , senha , nome_completo) VALUES "
                    + "('" + login + "' , '" + senha + "' , '" + nome_completo + "');";

                NpgsqlCommand cmd = new NpgsqlCommand(sql, pgsqlConnection);

                NpgsqlDataReader dr1 = cmd.ExecuteReader();
                dr1.Close();

                return true;
            }
            else
            {
                return false;
            }
        }



        //Codigo necessario para verificar se o usuario foi digitado mais de uma vez e retorna para o metodo cadastar acima
        public bool autenticar(string login)
        {
            //abre a conexão com o banco instanciando o ConexaoDB para o objconexao e executando o  comando pgsqlConnection
            NpgsqlConnection pgsqlConnection = null;

            ConexaoDB objconexao = new ConexaoDB();
            pgsqlConnection = objconexao.getConexao();

            pgsqlConnection.Open();

            string sqlVerifica = "SELECT * FROM tbl_usuario where login ='" + login + "';";
            NpgsqlCommand cmdVerifica = new NpgsqlCommand(sqlVerifica, pgsqlConnection);

            NpgsqlDataReader dr = cmdVerifica.ExecuteReader();

            if (dr.Read())
            {
                return false;
            }
            else
            {
                return true;
            }
        }




    }
                



            
}



