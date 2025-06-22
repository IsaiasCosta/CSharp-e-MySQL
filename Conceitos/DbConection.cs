using MySql.Data.MySqlClient;
using System;

namespace Conceitos
{
    class DbConection
    {
        // String de conexão

        private readonly string _dbConection;

        //Atributos de crendencias e parametros pasra conexão

        private const string _server = "localhost";
        private const string _base = "dbbase";
        private const string _user = "root";
        private const string _password = "Admin";

        //Construtor da conexão

        public DbConection()
        {
            _dbConection = $"Server={_server};Database={_base};User ID={_user};PassWord={_password};";
        }

        //Metodo retorno da conexão - obtem a conexão
        public string RetornarConexão()
        {
            return _dbConection;
        }

        //Testar Conexão

        public void TestConnection()
        {
            try
            {
                using var connection = new MySqlConnection(_dbConection);
                connection.Open();
                Console.WriteLine("Sucesso na Conexão");
            }
            catch (Exception erro)
            {
                Console.WriteLine("Falha na conexão, tente novamente" + erro.Message);
            }
        }

    }
}
