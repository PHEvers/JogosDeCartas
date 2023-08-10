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
            //cadastra os jogadores
        }
    }
}
