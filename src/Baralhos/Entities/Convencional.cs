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
            if( (i/14) < 1)
            {
                if (i == 1)
                {
                    Console.WriteLine("Ás Espadas");
                    return "Ás Espadas";
                }
                if (i < 11)
                {
                    Console.WriteLine(i + " Espadas");
                    return i + " Espadas";
                }
                if (i == 11)
                {
                    Console.WriteLine("Valete Espadas");
                    return "Valete Espadas";
                }
                if (i == 12)
                {
                    Console.WriteLine("Dama Espadas");
                    return "Dama Espadas";
                }
                if (i == 13)
                {
                    Console.WriteLine("Rei Espadas");
                    return "Rei Espadas";
                }
            }
            if ( (i/14) < 2)
            {
                if (i == 14)
                {
                    Console.WriteLine("Ás Ouros");
                    return "Ás Ouros";
                }
                if ( i%13 < 11 && i % 13 > 0)
                {
                    Console.WriteLine(i % 13 + " Ouros");
                    return i + " Ouros";
                }
                if (i == 24)
                {
                    Console.WriteLine("Valete Ouros");
                    return "Valete Ouros";
                }
                if (i == 25)
                {
                    Console.WriteLine("Dama Ouros");
                    return "Dama Ouros";
                }
                if (i == 26)
                {
                    Console.WriteLine("Rei Ouros");
                    return "Rei Ouros";
                }

            }
            if ((i / 14) < 3)
            {
                if (i == 27)
                {
                    Console.WriteLine("Ás Copas");
                    return "Ás Copas";
                }
                if (i % 13 < 11 && i % 13 > 0)
                {
                    Console.WriteLine(i % 13 + " Copas");
                    return i + " Copas";
                }
                if (i == 37)
                {
                    Console.WriteLine("Valete Copas");
                    return "Valete Copas";
                }
                if (i == 38)
                {
                    Console.WriteLine("Dama Copas");
                    return "Dama Copas";
                }
                if (i == 39)
                {
                    Console.WriteLine("Rei Copas");
                    return "Rei Copas";
                }
            }
            if ((i / 14) < 4)
            {
                if (i == 40)
                {
                    Console.WriteLine("Ás Paus");
                    return "Ás Paus";
                }
                if (i % 13 < 11 && i % 13 > 0)
                {
                    Console.WriteLine(i % 13 + " Paus");
                    return i + " Paus";
                }
                if (i == 50)
                {
                    Console.WriteLine("Valete Paus");
                    return "Valete Paus";
                }
                if (i == 51)
                {
                    Console.WriteLine("Dama Paus");
                    return "Dama Paus";
                }
                if (i == 52)
                {
                    Console.WriteLine("Rei Paus");
                    return "Rei Paus";
                }
            }

            Console.WriteLine(i + " Vazamento");
            return "seila";
        } 
    }
}

