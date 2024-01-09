
using DotNetBasico.Models;
using Newtonsoft.Json;
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


    //------------------ Conceitos de TUpla--------------------------------------

    (int Id, string Nome, string SobreNome, decimal Altura) tupla = (1, "Mathues", "HArdman", 1.83M);

    Console.WriteLine(tupla);

    LeituraArquivo leituraArquivo = new LeituraArquivo();
    var (sucess, linhas, qtd, erro) = leituraArquivo.LerArquivo("C:/Projetos Desenvolvimento/Projetos_DotNet/trilha-net-fundamentos-desafio/DotNetBasico/Arquivos/arquivoLeitura.txt");
    //Caso queira usar o descarte de algum dado:
    //var (sucess, linhas, qtd, _) = leituraArquivo.LerArquivo("C:/Projetos Desenvolvimento/Projetos_DotNet/trilha-net-fundamentos-desafio/DotNetBasico/Arquivos/arquivoLeitura.txt");


    if (sucess) 
    {
    Console.WriteLine($"Qtd de LInhas -> {qtd}");
        foreach (var item in linhas)
        {
            Console.WriteLine(item);
        }
    }
    else 
    {
        Console.WriteLine($"Ocorreu um erro na leitura -> {erro}");
    }
//------------------Deconstruct--------------------------------------

Pessoa pessoa = new Pessoa("HArdman", 40);

(string nome, int idade) = pessoa;

Console.WriteLine($"NOme -> {nome}, Idade -> {idade}");*/

//------------------Serializacao--------------------------------------

DateTime data = DateTime.Now;
Venda venda = new Venda(1, "GEraladeira", 4002, data);
Venda venda2 = new Venda(2, "Micoondas", 502, data);

List<Venda> lista = new List<Venda> { venda, venda2 };

string serializado = JsonConvert.SerializeObject(lista, Formatting.Indented);

//Add no file .json:
File.WriteAllText("C:/Pessoal/Projetos_DotNet/trilha-net-fundamentos-desafio/DotNetBasico/Arquivos/vendas.json", serializado);
Console.WriteLine(serializado);

//------------------DeSerializacao--------------------------------------
string json = File.ReadAllText("C:/Pessoal/Projetos_DotNet/trilha-net-fundamentos-desafio/DotNetBasico/Arquivos/vendas.json");

List<Venda> listaDeserializar = JsonConvert.DeserializeObject<List<Venda>>(json);

foreach (var item in listaDeserializar)
{
    Console.WriteLine($"Id: {item.Id}");
    Console.WriteLine($"Cadastrado: {item.DataCadastro.ToString("dd-MM-yyyy")}");
    Console.WriteLine($"Descricao: {item.Descricao}");
    Console.WriteLine($"Preço: {item.Preco}");
    Console.WriteLine($"---------------------------------");

}

Console.WriteLine("Pressione uma tecla para continuar");
Console.ReadLine();


