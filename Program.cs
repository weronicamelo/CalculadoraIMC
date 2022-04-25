using System;

namespace CalculadoraIMC
{
    class Program
    {
        static void Main(string[] args)
        {
            Individuo i1 = new Individuo();

            Console.WriteLine("Qual é o seu nome: ");
            i1.Nome = Console.ReadLine();

            Console.WriteLine("Qual é a sua altura em metros? Ex: 1,65");
            i1.Altura = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Qual é o seu peso em Kg? Ex: 57,4");
            i1.Peso = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("{0} sua altura é {1} e seu peso é {2}", i1.Nome, i1.Altura, i1.Peso);
            Console.WriteLine("Seu IMC é {0}", i1.IMC);
            
            Console.WriteLine("Classificação do IMC:", Math.Round(i1.IMC, 2));
            
            Console.WriteLine(i1.ClassificacaoImc);
            Console.WriteLine(i1.PesoIdeal);

            
        }
    }
}
