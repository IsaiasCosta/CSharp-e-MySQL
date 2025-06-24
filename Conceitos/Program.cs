using Mysqlx.Crud;
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

            Console.WriteLine("Digite o codigo a ser deletado");
            int codigo = Convert.ToInt16(Console.ReadLine());

            //Console.WriteLine("Digite o nome a ser alterado");
            //string nome = Console.ReadLine();

            //Console.WriteLine("Digite a idade a ser alterado");
            //int idade = Convert.ToInt16(Console.ReadLine());

            //Console.WriteLine("Digite a cidade a ser alterado");
            //string cidade = Console.ReadLine();

            //pessoaSql.Cadastrar(nome, idade, cidade);
            // pessoaSql.Selecionar();


            // pessoaSql.Update(codigo, nome, idade, cidade);
            pessoaSql.Delete(codigo);
        }

    }
}
