// See https://aka.ms/new-console-template for more information
using Baralhos.Entities;

Console.WriteLine("Hello, World!");

Convencional deck = new Convencional();
foreach (var item in deck.Monte)
{
    deck.Leitor(item);
}

//deck.Sorteia();
/*foreach(int carta in deck.Monte)
{
    Console.WriteLine("Sua carta é: " + carta + "\n");
}*/