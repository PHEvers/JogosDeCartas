using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baralhos.Entities
{
    public class Convencional
    {
        public int Id { get; set; }
        public int TotalMonte { get; set; }
        public int TotalLixeira { get; set; }
        public int TotalEmJogo { get; set; }
        public List<int> Monte { get; set; }
        public List<int> Lixeira{ get; set; }
        public List<int> EmJogo { get; set; }

        public void Inicio()
        {
            string coringa = "0";
            do
            {
                Console.WriteLine("Com coringa?");
                Console.WriteLine("1 = S | 2 = N");
                coringa = Console.ReadLine();
            } while (coringa != "1" || coringa != "2");
            for(int i = 0; i<52; i++)
            {
                Monte[i]= i+1;
            }
            Lixeira.Clear();
            EmJogo.Clear();
            TotalMonte = 52;
            TotalLixeira = 0;
            TotalEmJogo = 0;

            Console.WriteLine("Baralho criado");
        }
    }
}
