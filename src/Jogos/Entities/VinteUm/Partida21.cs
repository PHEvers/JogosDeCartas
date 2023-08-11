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
        public List<Jogadores21> JogadoresEliminados { get; set; }
        public Jogadores21 Mesa { get; set; }
        public Convencional Baralho { get; set; }

        public Partida21() 
        {
            Mesa = new Jogadores21();
            Jogadores = new List<Jogadores21>();
            
            Baralho = new Convencional();
            Baralho.Embaralha();
            
            CadastrarJogadores();

            Inicio();
            MostraMesa();

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
        public void Inicio()
        {
            Mesa.Mao.Add(Baralho.Retira(0));
            Mesa.Mao.Add(Baralho.Retira(0));

            for (int i = 0; i < Jogadores.Count; i++)
            {
                Jogadores[i].Mao.Add(Baralho.Retira(0));
                Jogadores[i].Mao.Add(Baralho.Retira(0));
            }
        }
        public void MostraMesa()
        {
            Mesa.MostraMao();
            for(int i = 0; i < Jogadores.Count; i++)
            {
                Jogadores[i].MostraMao();
            }
        }
    }
}
