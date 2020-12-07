using System;
using Hetanca.classes;

namespace Hetanca
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instanciamos nossa subclasse
            PessoaFisica  pf = new PessoaFisica();

            // Atribuimos um valor para a propiedade desponivel na super classe
            pf.nome = "Paulo";

            Console.WriteLine("Digite Seu CPF");
            pf.cpf = Console.ReadLine();
            

            // Mostramos no console um metodo de saudacao
            Console.WriteLine( pf.DarboasVindas(pf.nome) );

            // mostamos no console o metodo de validacao da subclasse
            Console.WriteLine ( pf.ValidarCPF( pf.cpf ) );
        }
    }
}
