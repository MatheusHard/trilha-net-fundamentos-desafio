
using DotNetBasico.Models;
using System.Globalization;

/*Pessoa pessoa = new Pessoa();
pessoa.Nome = "Burumungu";
pessoa.Idade = -1;
pessoa.ExibirDados();
Console.WriteLine("Pressione uma tecla para continuar");
Console.ReadLine();*/

/*Pessoa pessoa = new Pessoa(nome:"Burumungu", idade: 40);

Pessoa pessoa2 = new Pessoa(nome: "Luiza", idade: 45);

Curso curso = new Curso();
curso.Nome = "Espanhol";
curso.Alunos = new List<Pessoa> ();

curso.Add(pessoa);
curso.Add(pessoa2);

curso.Listar();

Console.WriteLine("Pressione uma tecla para continuar");
Console.ReadLine();*/

//Mudar formato do PAis:
CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");
decimal valor = 1542.30M;

Console.WriteLine( $" VAlor em Real: {valor:C}");
Console.WriteLine($" VAlor em Dolar: {valor.ToString("C", CultureInfo.CreateSpecificCulture("en-US"))}");




Console.WriteLine("Pressione uma tecla para continuar");
Console.ReadLine();


