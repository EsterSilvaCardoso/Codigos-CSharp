using System;
using System.Globalization;
using System.Xml.Serialization;

namespace ex01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual seu nome?");
            string nome = Console.ReadLine();
            Console.WriteLine("Qual é o seu peso? Ex: 67,8");
            double peso = double.Parse(Console.ReadLine());
            Console.WriteLine("E quantos anos você tem?");
            int idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual é a sua altura? Ex: 1,78");
            double altura = double.Parse(Console.ReadLine());
            
            double imc = peso / (altura * altura);

            if (imc < 16) 
            {
                Console.WriteLine("O usuário " + nome + " se encaixa no status de magreza grave, por favor consulte seu nutricionista!");
            }

            else if (imc >= 16 && imc < 17) 
            {
                Console.WriteLine("O usuário " + nome + " se encaixa no status de magreza moderada, por favor consulte seu nutricionista!");
            }

            else if (imc >= 17 && imc < 18.5)
            {
                Console.WriteLine("O usuário " + nome + " se encaixa no status de magreza leve, por favor consulte seu nutricionista!");
            }

            else if (imc >= 18.5 && imc < 25)
            {
                Console.WriteLine("O usuário " + nome + " se encaixa no status de saudável, parabéns!");
            }

            else if (imc >= 25 &&  imc < 30)
            {
                Console.WriteLine("O usuário " + nome + " se encaixa no status de sobrepeso, por favor consulte seu nutricionista!");
            }

            else if (imc >= 30 && imc < 35)
            {
                Console.WriteLine("O usuário " + nome + " se encaixa no status de obesidade grau I, por favor consulte seu nutricionista!");
            }

            else if (imc >= 35 && imc < 40)
            {
                Console.WriteLine("O usuário " + nome + " se encaixa no status de obesidade grau II, por favor consulte seu nutricionista!");
            }

            else if (imc >= 40)
            {
                Console.WriteLine("O usuário " + nome + " se encaixa no status de obesidade grau III, por favor consulte seu nutricionista!");
            }
        }
    }
}