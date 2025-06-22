using System;

namespace Conceitos
{
    class Program
    {
        //Objeto de conexão
        static void Main(string[] args)
        {
            DbConection conection = new();
            //  conection.TestConnection();

            //Objeto PessoaSQL

            PessoaSql pessoaSql = new(conection.RetornarConexão());

            Console.WriteLine("Digite o nome a ser cadastrado");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite a idade a ser cadastrado");
            int idade = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Digite a cidade a ser cadastrado");
            string cidade = Console.ReadLine();

            //pessoaSql.Cadastrar(nome, idade, cidade);
            pessoaSql.Selecionar();
        }

    }
}
