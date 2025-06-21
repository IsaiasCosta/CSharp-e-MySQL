using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conceitos
{
    class Program
    {
        //Objeto de conexão
        static void Main(string[] args)
        {
            DbConection conection = new();
            conection.TestConnection();
        }

    }
}
