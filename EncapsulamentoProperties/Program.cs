using System;
using System.Globalization;

namespace EncapsulamentoProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto("PS5", 6000.00, 10);

            p.SetNome("XBOX X");

            Console.WriteLine(p.GetNome());
            Console.WriteLine(p.GetPreço());
            Console.WriteLine(p.GetQuantidade());

            Console.ReadKey();
        }
    }
}
