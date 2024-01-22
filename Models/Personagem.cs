using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _4.Personagem.Models
{
    public class Personagem
    {
        public string Nome { get; set; }
        public string Raca { get; set; }
        public string Classe { get; set; }
        public int Nivel { get; set; } = 1;
        public int Vida { get; set; } = 10;

        public Personagem(string nome,string raca, string classe)
        {
            Nome = nome;
            Raca = raca;
            Classe = classe;
        }

        public void ExibirStatus()
        {
            Console.WriteLine($"Nome: {Nome} Raça: {Raca} Classe: {Classe} Nível: {Nivel} Vida: {Vida}");
        }
    }
}