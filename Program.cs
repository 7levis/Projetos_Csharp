using System;
using System.Runtime.InteropServices;
namespace ContaBancaria
{
    class Program
    {   
        static void Main(string[] args)
        {
            ContaBanco c1 = new ContaBanco(123, "cc", "Sergio");
            Console.WriteLine(c1.Titular);
        }
    }
}