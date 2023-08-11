using Baralhos.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogos.Entities.VinteUm
{
    public class Partida21
    {
        public int Id { get; set; }
        public List<Jogadores21> Jogadores { get; set; }
        public Convencional Baralho { get; set; }

        public Partida21() 
        {
            Jogadores = new List<Jogadores21>();
            Baralho = new Convencional();
            Baralho.Embaralha();
            CadastrarJogadores();


            //cadastra os jogadores
        }
        public void CadastrarJogadores()
        {
            int i = 0;
            do
            {
                Console.WriteLine("Quantos jogagores? (Max: 4)");
                i = Convert.ToInt32(Console.ReadLine());
            } while (i <= 0 || i > 4);

            while (i > 0)
            {
                Console.WriteLine("Qual o nome do jogador " + (Jogadores.Count+1) + "?");
                Jogadores.Add(new Jogadores21
                {
                    Id = Jogadores.Count + 1,
                    Nome = Console.ReadLine(),
                    Mao = new List<Carta>(),
                    Pontuacao = 0,
                });
                i--;
            }
        }
    }
}
