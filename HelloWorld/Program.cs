using System;

namespace HelloWorld // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args) //void: nada
        {
            string nome = "Marjory";
            decimal altura = 1.62m; 
            float peso = 65.50f; 
            double tamanho_pe = 24.5;
            char sexo = 'F';
            bool empregado = false;
            int idade = 33;

            Console.WriteLine(nome);
            Console.WriteLine(altura);
            Console.WriteLine(peso);
            Console.WriteLine(tamanho_pe);
            Console.WriteLine(sexo);
            Console.WriteLine(empregado);
            Console.WriteLine(idade);

        }
    }
}