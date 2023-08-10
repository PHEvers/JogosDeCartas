using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baralhos.Entities
{
    public class Convencional
    {
        public int Id { get; set; }
        public List<Carta> Monte { get; set; }
        public List<Carta> Lixeira{ get; set; }
        //
        private Random random = new Random();
        private List<int> temporaria;
        //
        public Convencional()
        {
            Inicia();
        }
        public void Inicia()
        {
            Monte = new List<Carta>();
            Lixeira = new List<Carta>();
            int i = 0;
            for (int j = 0; j < 13; j++)
            {
                Monte.Add(new Carta
                {
                    Id = i + 1,
                    Naipe = "Ouros",
                    Numercao = j + 1,
                });
                i++;
            }
            for (int j = 0; j < 13; j++)
            {
                Monte.Add(new Carta
                {
                    Id = i + 1,
                    Naipe = "Espadas",
                    Numercao = j + 1,
                });
                i++;
            }
            for (int j = 0; j < 13; j++)
            {
                Monte.Add(new Carta
                {
                    Id = i + 1,
                    Naipe = "Copas",
                    Numercao = j + 1,
                });
                i++;
            }
            for (int j = 0; j < 13; j++)
            {
                Monte.Add(new Carta
                {
                    Id = i + 1,
                    Naipe = "Paus",
                    Numercao = j + 1,
                });
                i++;
            }

            Console.WriteLine("Baralho criado");
        }
        public void Embaralha()
        {   
            List<Carta> NovoMonte = new List<Carta>();
            do
            {
                int i = random.Next(0, Monte.Count);
                NovoMonte.Add(Monte[i]);
                Monte.RemoveAt(i);
            } while (Monte.Count > 0);
            Monte = NovoMonte;
            Console.WriteLine("Baralho embaralhado");
            return;
        }
        public void Mostra(int i)
        {
            Console.WriteLine(Monte[i].Numercao + " " + Monte[i].Naipe);
        }
        public Carta Retira(int i)
        {
            Carta carta = Monte[i];
            Monte.RemoveAt(i);
            return carta;
        }
        public void Retorna(Carta carta)
        {
            Monte.Add(carta);
            return;
        }
        public void JogarLixeira(Carta carta)
        {
            Lixeira.Add(carta);
            return;
        }
    }
}

