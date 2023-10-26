using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome;
            int idade;
            string sexo;
            double peso, altura, imc;

            Console.Write("Digite seu nome: ");
            nome = Console.ReadLine();

            Console.Write("Digite sua idade: ");
            idade = Convert.ToInt16(Console.ReadLine());

            Console.Write("Digite seu sexo: ");
            sexo = Console.ReadLine();

            Console.Write("Digite seu peso: ");
            peso = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite seu altura: ");
            altura = Convert.ToDouble(Console.ReadLine());

            imc = peso / (altura * altura);

            Console.WriteLine(nome + ", seu IMC é de: " + imc);
            Console.ReadKey();
        }
    }
}
