using System;
using System.Collections.Generic;

public class Loja
{
  public Dictionary<string,Item> Estoque = new Dictionary<string,Item>();

  public Loja()
  {
    Item adaga = new Item("adaga","item comum","Guerreiro",10,5,"de ataque");

    this.Estoque.Add(adaga.Nome,adaga);

    Item espada = new Item("espada","item raro","Guerreiro",20,15,"de ataque");

    this.Estoque.Add(espada.Nome,espada);

    Item claymore = new Item("claymore","item epíco","Guerreiro",40,45,"de ataque");
    
    this.Estoque.Add(claymore.Nome,claymore);

    Item arco = new Item("arco","item comum","atirador",10,10,"de velocidade de ataque");

    this.Estoque.Add(arco.Nome,arco);

    Item besta = new Item("besta","item raro","atirador",20,30,"de velocidade de ataque");

    this.Estoque.Add(besta.Nome,besta);

    Item pistola = new Item("pistola","item epíco","atirador",40,50,"de velocidade de ataque");

    this.Estoque.Add(pistola.Nome,pistola);

    
    Item varinha = new Item("varinha","item comum","mago",10,10,"de feitiçaria");

    this.Estoque.Add(varinha.Nome,varinha);

    Item cajado = new Item("cajado","item raro","mago",20,30,"de feitiçaria");

    this.Estoque.Add(cajado.Nome,cajado);

    Item grimorio = new Item("grimório","item epíco","mago",40,60,"de feitiçaria");

    this.Estoque.Add(grimorio.Nome,grimorio);

    Item broquel = new Item("broquel","item normal","tank",10,10,"de armadura");

    this.Estoque.Add(broquel.Nome,broquel);
    
    Item escudo = new Item("escudo","item raro","tank",20,15,"de armadura");

    this.Estoque.Add(escudo.Nome,escudo);

    Item aegis = new Item("aegis","item epíco","tank",40,40,"de armadura");

    this.Estoque.Add(aegis.Nome,aegis);

    Item capa = new Item("capa mistica","item normal","tank",10,10,"de resistência mágica");

    this.Estoque.Add(capa.Nome,capa);

    Item tunica = new Item("tunica","item raro","tank",20,15,"de resistência mágica");

    this.Estoque.Add(tunica.Nome,tunica);


    Item selo = new Item("selo","item raro","tank",40,40,"de resistência mágica");

    this.Estoque.Add(selo.Nome,selo);

    
  }
  
  public void Adic(Item item)
  {
    this.Estoque.Add(item.Nome,item );
  }

  public void Glossario ()
  {
    foreach(KeyValuePair<string,Item> i in this.Estoque)
    {
      i.Value.Imprimir();
      Console.WriteLine();

    }


  }
}