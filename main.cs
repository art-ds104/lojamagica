using System;

class MainClass {
  public static void Main (string[] args) {

    Persona heroi = new Persona("Herói",100);


    Console.WriteLine ("bem vindo a Loja de equipamentos mágicos,{0} ! Selecione os itens que deseja",heroi.Nome);
    
    Loja armazen = new Loja();

    armazen.Glossario();

    do
    {
      Console.WriteLine("Seu saldo atual é de {0}, use todo o dinheiro que possui para comprar itens para desafiar o rei demonio",heroi.Din);

      Console.WriteLine("favor insira o nome do item que vocÊ deseja");
      string slot = Console.ReadLine();

      heroi.Comprar(slot,armazen);
      Console.WriteLine();
      heroi.Transc();
      Console.WriteLine();
      
    }while(heroi.Din != 0);

    
    
  }
}