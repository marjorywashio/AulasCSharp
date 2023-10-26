using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Criar um script que solicite 2 números ao usuário e ao final mostre a soma dos valores.
            */

            double n1, n2, soma, subtracao, divisao, mult;

            Console.Write("Insira um número: ");
            double.TryParse(Console.ReadLine(), out n1);

            Console.Write("Insira um número: ");
            n2 = Convert.ToDouble(Console.ReadLine());

            soma = n1 + n2;
            subtracao = n1 - n2;
            divisao = n1 / n2;
            mult = n1 * n2;

            Console.WriteLine("A soma dos números é: " + soma);
            Console.WriteLine("A subtração dos números é: " + subtracao);
            Console.WriteLine("A divisão dos números é: " + divisao);
            Console.WriteLine("A multiplicação dos números é: " + mult);
        }
    }
}
