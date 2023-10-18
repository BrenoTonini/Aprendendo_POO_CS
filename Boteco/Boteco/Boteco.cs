using System.Collections.Generic;
using System;
class Boteco{
    private List<Produto> cardapio = new List<Produto>();
    private List<Produto> comanda = new List<Produto>();
    private bool pago = true;

    public Boteco()
    {
        Produto skol = new Produto("Skol", 7, true, "1");
        Produto cachaca_51 = new Produto("Cachaça 51", 15, true, "2");
        Produto bohemia = new Produto("Bohemia", 8, true, "3");
        Produto kibe = new Produto("Kibe assado", 5, false, "4");
        Produto file_tilapia = new Produto("Filé de tilápia", 20, false, "5");
        Produto agua = new Produto("Agua", 3, false, "6");
      
        cardapio.Add(skol);
        cardapio.Add(cachaca_51);
        cardapio.Add(bohemia);
        cardapio.Add(kibe);
        cardapio.Add(file_tilapia);
        cardapio.Add(agua);
    }

  public List<Produto> getCardapio(){
    return cardapio;
  }

  public void setCardapio(List<Produto> cardapio){
    this.cardapio = cardapio;
  }

  public List<Produto> getComanda(){
    return comanda;
  }

  public void setComanda(List<Produto> comanda){
    this.comanda = comanda;
  }

  public void addComanda(Produto p){
    comanda.Add(p);
    pago = false;
  }

  public void operarComanda(Produto produto){
    getComanda().Add(produto);
  }

  public float getTotalConta(){ //Retorna o valor total da conta
    float totalizador = 0f;
    foreach(Produto produto in comanda){
      totalizador += produto.getPreco();
    }
    return totalizador;
  }

  public void getPago(bool pago){
    this.pago = pago;
  }

  public void setPago(bool p){
    pago = p;
  }

}