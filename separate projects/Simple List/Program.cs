
using System;
using System.IO;



string? resposta;

var nomes = new List<String> {"coisalegal1", "coisalegal2"};

do
{

    Console.WriteLine("Deseja adicionar um novo item na lista? (y ou n)");
    resposta = Console.ReadLine();

    if(resposta?.ToLower().Trim() == "y")
    {
        Console.WriteLine("Digite o nome do item");
        nomes.Add(Console.ReadLine());
    }

}
while(resposta.ToLower().Trim() == "y");


Console.Clear();

foreach(string nome in nomes)
    Console.WriteLine(nome);

Console.WriteLine($"Atualmente temos {nomes.Count} itens na lista");


Console.Write("Deseja salvar? ");
string respostaSalvar = Console.ReadLine();

if(respostaSalvar == "sim")
{
 
    Console.Write("Insira o nome e formato do arquivo de texto:");
    string nomeFormatoArquivo = Console.ReadLine();

    File.WriteAllLines(nomeFormatoArquivo, nomes);

    Console.Clear();

    Console.WriteLine("Arquivo salvo com sucesso, você deve encontra-lo na pasta do programa.");
    
    
}
//adicionar um loop e tela de seleção pro usuario escolher quando sair, quando listar um arquivo e quando quiser colocar mais itens na lista.