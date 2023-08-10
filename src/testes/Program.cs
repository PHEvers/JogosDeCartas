// See https://aka.ms/new-console-template for more information
using Baralhos.Entities;

Console.WriteLine("Hello, World!");

Convencional deck = new Convencional();
deck.Embaralha();
for (int i = 0; i < deck.Monte.Count; i++)
{
    deck.Mostra(i);
}
