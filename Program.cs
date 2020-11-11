using System;

namespace Logica_de_programação
{
    class Program
    {
        static void Main(string[] args)
        {

            // int valorUm;
            // int valorDois;
            


            // Aqui vai o Código
            //Console.WriteLine("Digite seu nome:");
            //string nomeCompleto = Console.ReadLine();

            //Console.WriteLine("bem vindo "+nomeCompleto);



            // Entrada de dados
            
            Console.WriteLine("Soma de dois números ");
            Console.WriteLine("--------------------");
            Console.Write("Digite o primeiro valor: ");
            int valorUm = int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo valor: ");
            int valorDois = int.Parse(Console.ReadLine());

            //Porcessamento

            int soma = valorUm + valorDois;

            //Exibir

            Console.WriteLine("A soma de "+valorUm+" + "+valorDois+" = "+soma);
            
        }
    }
}
