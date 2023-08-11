using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baralhos.Entities
{
    public class Carta
    {
        public int Id { get; set; }
        public string Naipe { get; set; }
        public int Numercao { get; set; }

        public void Mostra()
        {
            Console.WriteLine(Numercao + " " + Naipe);
        }
        
    }
}
