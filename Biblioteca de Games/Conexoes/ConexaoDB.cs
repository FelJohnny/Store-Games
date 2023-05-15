using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;


namespace Biblioteca_de_Games.Conexoes
{
    public class ConexaoDB
    {
        
            //configuração da conexão do banco de dados
            private static string serverName = "127.0.0.1"; //local host
            private static string port = "5432"; // porta do servidor
            private static string userName = "postgres"; //usuario do servidor
            private static string password = "postgres"; //senha do servidor
            private static string databaseName = "ProjGames"; //banco de dados

        public NpgsqlConnection getConexao()
        {
            NpgsqlConnection pgsqlConnection;
            string connString = String.Format("Server={0};Port={1};User Id={2};Password={3};Database={4};", serverName, port, userName, password, databaseName);
            pgsqlConnection = new NpgsqlConnection(connString);

            return pgsqlConnection;
        }
    }
}
