using System;

// Criar um programa para escrever um cartão de visita. O programa deve mostrar o nome, profissão, email, descrição
// e telefone
string? nome;
string? telefone;
string? profissao;
string? email;

Console.Write("Qual é o seu nome? ");
nome = Console.ReadLine();

Console.Write("Qual é o seu telefone? ");
telefone = Console.ReadLine();

Console.Write("Qual é a sua profissão? ");
profissao = Console.ReadLine();

Console.Write("Qual é o seu e-mail? ");
email = Console.ReadLine();

Console.WriteLine("******************************************");
Console.WriteLine("*" + nome.PadRight(40) + "*");
Console.WriteLine("*                                        *");
Console.WriteLine("*" + profissao.PadRight(40) + "*");
Console.WriteLine("*                                        *");
Console.WriteLine("*" + telefone.PadRight(40) + "*");
Console.WriteLine("*" + email.PadRight(40) + "*");
Console.WriteLine("*                                        *");
Console.WriteLine("******************************************");

