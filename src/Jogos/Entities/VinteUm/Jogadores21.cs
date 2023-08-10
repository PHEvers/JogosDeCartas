using Baralhos.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogos.Entities.VinteUm
{
    public class Jogadores21
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public List<Carta> Mao{ get; set; }
        public int Pontuacao { get; set; }
    }
}
