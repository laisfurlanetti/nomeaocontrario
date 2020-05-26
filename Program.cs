using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nomeaocontrario
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;


            Console.Write("Digite seu nome: ");
            nome = Console.ReadLine().ToUpper();

            Console.WriteLine("Seu nome: " + ReverterNome(nome));

            Console.Read();
        }
        public static string ReverterNome(string nome)
        {
            char[] digNome = nome.ToCharArray();
            Array.Reverse(digNome);
            return new string (digNome);
        }
    }
}
