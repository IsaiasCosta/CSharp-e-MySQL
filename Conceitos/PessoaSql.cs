using MySql.Data.MySqlClient;
using System;

namespace Conceitos
{
    class PessoaSql
    {
        /// <summary>
        /// Classe para executar comandos SQL
        /// </summary>
        //Atributo om a string de conexão

        private readonly string _DbConection;

        //Construtor

        public PessoaSql(string conection)
        {
            _DbConection = conection;
        }

        //Efetuar Cadastro
        public void Cadastrar(string nome, int idade, string cidade)
        {
            // comando sql 
            string sql = "INSERT INTO Pessoas (nome,idade,cidade) VALUES (@nome, @idade,@cidade)";

            //Conectando  com o Banco e executando a query

            using (var conection = new MySqlConnection(_DbConection))
            using (var command = new MySqlCommand(sql, conection))
            {
                //Parametros Sql
                command.Parameters.AddWithValue("@nome", nome);
                command.Parameters.AddWithValue("@idade".ToString(), idade);
                command.Parameters.AddWithValue("cidade", cidade);

                //Executar comandos

                try
                {
                    conection.Open();
                    command.ExecuteNonQuery();
                    Console.WriteLine("Cadastrado com sucesso...");
                }
                catch (Exception erro)
                {
                    Console.WriteLine($"{erro} - Falha ao cadastrar atualizar" + erro.Message);
                }
            }
        }
        public void Selecionar()
        {
            //Comando SQL

            var sql = "SELECT * FROM Pessoas";

            //Conectando  com o Banco e executando a query
            using (var conection = new MySqlConnection(_DbConection))
            using (var command = new MySqlCommand(sql, conection))
            {
                //Executar comandos

                try
                {
                    conection.Open();
                    //Listar a tabela Pessoas
                    using (var pessoas = command.ExecuteReader())
                    {
                        while (pessoas.Read())
                        {
                            Console.WriteLine(
                                "Código: " + pessoas["codigo"] + "\n" +
                                "Nome: " + pessoas["nome"] + "\n" +
                                "Idade: " + pessoas["idade"] + "\n" +
                                "Cidade " + pessoas["cidade"]);
                            Console.WriteLine("============================");
                        }
                    }

                    Console.WriteLine("Consulta com sucesso...");
                }
                catch (Exception erro)
                {
                    Console.WriteLine($"{erro} - Falha  na consulta SQL" + erro.Message);
                }
            }

        }
    }
}
