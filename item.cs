using System;

public class Item{

  public string Nome;

  public string Desc;

  public string Cat;

  public int Val;
  
  public int Quant;

  public string Atrib;

  public Item (string nome, string desc, string cat, int val, int quant, string atrib)
  {
    this.Nome = nome;
    this.Desc = desc;
    this.Cat = cat;
    this.Val = val;
    this.Quant = quant;
    this.Atrib = atrib;
    
  }

  public void Imprimir()
  {
    Console.WriteLine("O item {0}",this.Nome);

    Console.WriteLine("Descrição : {0}",this.Desc);

    Console.WriteLine("é um item {0}",this.Cat);

    Console.WriteLine("custa {0}",this.Val);

    Console.WriteLine("lhe concede {0} {1}",this.Quant,this.Atrib);

  }
}
