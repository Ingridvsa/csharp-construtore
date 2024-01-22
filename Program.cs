using _4.Personagem.Models;

Console.WriteLine("Informe dados sobre o personagem:");

Console.WriteLine("Nome:");
string nome = Console.ReadLine();

Console.WriteLine("Raça:");
string raca = Console.ReadLine();

Console.WriteLine("Classe:");
string classe = Console.ReadLine();
      
Personagem meuPersonagem = new Personagem(nome, raca, classe);
      
Console.WriteLine("Status:");
meuPersonagem.ExibirStatus();