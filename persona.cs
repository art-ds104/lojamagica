using System;
using System.Collections.Generic;

public class Persona {

  public string Nome;

  public int Din;

  public List<Item> Invent = new List<Item>();

  public Persona (string nome, int din)
  {
    this.Nome = nome; 

    this.Din = din;
  }

  public void Comprar(string nome,Loja loja)
  {
   
    if(loja.Estoque.ContainsKey(nome))
    {
      Item itemSelec = loja.Estoque[nome];

      if(this.Din >= itemSelec.Val)
      {
        Console.WriteLine("Tem certeza que deseja prosseguir ? digite 1 para sim ou 2 para não ");
        
        int alt = Convert.ToInt32(Console.ReadLine());
      
        if(alt == 1)
        {
          this.Din = Din - itemSelec.Val;

          this.Invent.Add(itemSelec);

        }
      
      }
      else
      {
        Console.WriteLine("saldo insuficiente");
      }
    }
    else
    {
      Console.WriteLine("esse item não existe, tente de novo");
    }

  }

  public void Transc()
  {
    Console.WriteLine("os itens que você possui no momento são : ");
    foreach(Item i in Invent)
    {
      Console.WriteLine(i.Nome);
    }
  }

}