using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Media
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, n3, n4, media;

            Console.Write("Insira um número: ");
            n1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Insira um número: ");
            n2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Insira um número: ");
            n3 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Insira um número: ");
            n4 = Convert.ToDouble(Console.ReadLine());

            media = (n1 + n2 + n3 + n4) / 4;

            Console.WriteLine("A média dos números é: " + media);
        }
    }
}
