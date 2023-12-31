
using DotNetBasico.Models;
using System.ComponentModel;
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

/*Mudar formato do PAis:
CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");
decimal valor = 1542.30M;

Console.WriteLine( $" VAlor em Real: {valor:C}");
Console.WriteLine($" VAlor em Dolar: {valor.ToString("C", CultureInfo.CreateSpecificCulture("en-US"))}");



*/

// Conceitos de Fila
Pessoa pessoa1 = new Pessoa(nome: "Burumungu", idade: 40);
Pessoa pessoa2 = new Pessoa(nome: "Luiza", idade: 45);
Pessoa pessoa3 = new Pessoa(nome: "MArcos Xarope", idade: 45);
Pessoa pessoa4 = new Pessoa(nome: "Cururuzão", idade: 50);


Queue<Pessoa> listaFila = new Queue<Pessoa>();

listaFila.Enqueue(pessoa1);
listaFila.Enqueue(pessoa2);
listaFila.Enqueue(pessoa3);
listaFila.Enqueue(pessoa4);

Console.WriteLine($"-- Antes da remoçaõ da Fila --");

foreach (var item in listaFila) {
        Console.WriteLine($"NOme: {item.Nome}");
    Console.WriteLine($"Idade: {item.Idade}");

}
Pessoa removido = listaFila.Dequeue();

Console.WriteLine($"Retirado da Fila -> {removido.Nome}");

Console.WriteLine($"-- Apos remoçaõ da Fila --");
foreach (var item in listaFila) {
    
    Console.WriteLine($"NOme: {item.Nome}");
    Console.WriteLine($"Idade: {item.Idade}");

}
//Conceitos de Pilha
Stack<Pessoa> listaPilha = new Stack<Pessoa>();
listaPilha.Push(pessoa1);
listaPilha.Push(pessoa2);
listaPilha.Push(pessoa3);
listaPilha.Push(pessoa4);

Console.WriteLine($"-- Antes da remoçaõ da Pilha --");

foreach (var item in listaPilha) {
    Console.WriteLine($"NOme: {item.Nome}");
    Console.WriteLine($"Idade: {item.Idade}");

}
Pessoa removidoPilha = listaPilha.Pop();

Console.WriteLine($"Retirado da Pilha-> {removido.Nome}");

Console.WriteLine($"-- Apos remoçaõ da Pilha--");
foreach (var item in listaPilha) {

    Console.WriteLine($"NOme: {item.Nome}");
    Console.WriteLine($"Idade: {item.Idade}");

}

//Dicionary
Dictionary<string, string> listaDicionario = new Dictionary<string, string> {
    { "SP", "São Paulo" },
    { "PE", "Pernambuco" },
    { "Pb", "Paraiba" }
};

Console.WriteLine($"Dicionario");
foreach (var item in listaDicionario)
{
    Console.WriteLine($"Chave: {item.Key} - Valor: {item.Value}");
}

Console.WriteLine("Pressione uma tecla para continuar");
Console.ReadLine();


