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
        //
        private Random random = new Random();
        private List<int> temporaria;
        //
        public Convencional()
        {
            Inicio();
        }
        public void Inicio()
        {
            string coringa = "0";
            /*   do
               {
                   Console.WriteLine("Com coringa?");
                   Console.WriteLine("1 = S | 2 = N");
                   coringa = Console.ReadLine();
               } while (coringa != "1" && coringa != "2");
   */
            Monte = new List<int>();
            Lixeira = new List<int>();
            EmJogo = new List<int>();
            for (int i = 0; i<52; i++)
            {
                Monte.Add(i+1);
            }

            TotalMonte = 52;
            TotalLixeira = 0;
            TotalEmJogo = 0;
            
            Console.WriteLine("Baralho criado");
        }
        public void Sorteia()
        {
            
            for (int i = 0; i > TotalMonte; i++)
            {
                temporaria[i] = Monte[random.Next(TotalMonte-i)];
            }
            for (int i = 0; i > TotalMonte; i++)
            {
                Monte[i] = temporaria[i];
            }
            Console.WriteLine("Monte embaralhado");
            for (int i = 0; i < TotalMonte; i++)
            {
                Console.WriteLine("Sua carta é: " + Monte[i]);
            }
            Console.WriteLine("Monte embaralhado");
            return;
        }
        public string Leitor(int i)
        {
            if( (i/13) < 1)
            {
                if(i < 11)
                {
                    Console.WriteLine(i + " Espadas");
                    return i + " Espadas";
                }
            }
            if ( (i/13) < 2)
            {
                if ( i%13 < 11 && i % 13 > 0)
                {
                    Console.WriteLine(i % 13 + " Ouros");
                    return i + " Ouros";
                }
            }
            if ((i / 13) < 3)
            {
                if (i % 13 < 11 && i % 13 > 0)
                {
                    Console.WriteLine(i % 13 + " Copas");
                    return i + " Copas";
                }
            }
            if ((i / 13) < 4)
            {
                if (i % 13 < 11 && i % 13 > 0)
                {
                    Console.WriteLine(i % 13 + " Paus");
                    return i + " Paus";
                }
            }
            Console.WriteLine(i + " Vazamento");
            return "seila";
        } 
    }
}

