using System;
using System.Collections.Generic;

public class Guerreiro : Personagem
    {
        public List<string> Habilidade { get; set; } 
        public Guerreiro(string nome, int vida, int mana, float xp, int inteligencia, int forca, int level, List<string> habilidades) : base(nome, vida, mana, xp, inteligencia, forca, level)
        {
            Nome = nome;
            Vida = vida;
            Mana = mana;
            Xp = xp;
            Inteligencia = inteligencia;
            Forca = forca;
            Level = level;
            Habilidade = habilidades;
        }

        public override void lvlUp()
        {
            Level++;
            Forca++;
            Vida++;
        }



        public  int Attack()
        {
            Random randNum = new Random();
            int numRandomico = randNum.Next(0,300);
            return (Forca * Level) + numRandomico;
        }

        public bool AprenderHabilidade(string habilidade)
        {
            Habilidade.Add(habilidade);
            foreach (var item in Habilidade)
            {
                Console.WriteLine($"{item}");
            }
            return true;
        }
    }