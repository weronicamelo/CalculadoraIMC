using System;

namespace CalculadoraIMC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual é o seu nome: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Qual é a sua altura em metros? Ex: 1,65");
            float altura = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Qual é o seu peso em Kg? Ex: 57,4");
            float peso = Convert.ToSingle(Console.ReadLine());

            double imc = peso / (altura* altura);

            Console.WriteLine("{0} sua altura é {1} e seu peso é {2}", nome, altura, peso);
            Console.WriteLine("Seu IMC é {0}", imc);
            Console.WriteLine("Classificação do IMC:");

            if(imc < 18.5)
            {
                Console.WriteLine("Abaixo do peso!");
            }
            else if(imc >= 18.5 && imc <= 24.9)
            {
                Console.WriteLine("Peso normal!");
            }
            else if(imc >= 25 && imc <= 29.9)
            {
                Console.WriteLine("Sobrepeso!");
            }
            else if(imc >= 30 && imc <= 34.9)
            {
                Console.WriteLine("Obesidade Grau 1!");
            }
            else if(imc >= 35 && imc <= 39.9)
            {
                Console.WriteLine("Obesidade Grau 2!");
            }
            else if(imc >= 40)
            {
                Console.WriteLine("Obesidade Grau 3 ou Mórbida!");
            }

            double pesoNovo;
            if(imc < 18.5)
            {
                pesoNovo = (18.5 * altura * altura);
                Console.WriteLine("Para chegar ao peso normal é preciso o ganho de {0} kg:", ((pesoNovo - peso) - 3));
            }
            else if(imc >= 25.0)
            {
                pesoNovo = (24.9 * altura * altura);
                Console.WriteLine("Para chegar ao peso normal é preciso perder {0} kg:", ((peso - pesoNovo) - 3));
            }
        }
    }
}
