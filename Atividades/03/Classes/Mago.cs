using System;
using System.Collections.Generic;

public class Mago : Personagem
    {
        public List<string> Magia { get; set; } 
        
        public Mago(string nome, int vida, int mana, float xp, int inteligencia, int forca, int level, List<string> magias) : base(nome, vida, mana, xp, inteligencia, forca, level)
        {
            Nome = nome;
            Vida = vida;
            Mana = mana;
            Xp = xp;
            Inteligencia = inteligencia;
            Forca = forca;
            Level = level;
            Magia = magias;
        }

        public override void lvlUp()
        {
            Level++;
            Inteligencia++;
            Mana ++;
        }

        public  int Attack()
        {
            Random randNum = new Random();
            int numRandomico = randNum.Next(0,300);
            return (Inteligencia * Level) + numRandomico;
        }

        public bool AprenderMagia(string novaMagia)
        {
            Magia.Add(novaMagia);
            foreach (var item in Magia)
            {
                Console.WriteLine($"{item}");
            }

            return true;
        }
    }
    