
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Aula21
{
    class Program
    {
        static void Main(string[] args)
        {
            //Treinamento - Aula21, Estrutura condicional simples, tipo int
            //Jonas Valereo - Técnico em Informática 


            //Declarando a variavel tipo int

            int a = 5;

            //Declarando o codigo entrada de dado no console, método ReadLine

            Console.WriteLine("Digite um número!: ");
            a = int.Parse(Console.ReadLine());
            
            //Declarando estrutura condicinoal simples if

            if (a > 5)
            {
                
                Console.WriteLine("Parabéns, é verdadeira");
                Console.WriteLine();
                Console.WriteLine("Teste de novo!!!");

            }

            // saida da aplicação, console, método Readkey, Retorna o valor da tecla pressionada

            Console.ReadKey();

            //Fim do programa
        }
    }
}
