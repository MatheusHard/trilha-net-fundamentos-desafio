
using DotNetBasico.Models;

/*Pessoa pessoa = new Pessoa();
pessoa.Nome = "Burumungu";
pessoa.Idade = -1;
pessoa.ExibirDados();
Console.WriteLine("Pressione uma tecla para continuar");
Console.ReadLine();*/

Pessoa pessoa = new Pessoa(nome:"Burumungu", idade: 40);

Pessoa pessoa2 = new Pessoa(nome: "Luiza", idade: 45);

Curso curso = new Curso();
curso.Nome = "Espanhol";
curso.Alunos = new List<Pessoa> ();

curso.Add(pessoa);
curso.Add(pessoa2);

curso.Listar();

Console.WriteLine("Pressione uma tecla para continuar");
Console.ReadLine();




