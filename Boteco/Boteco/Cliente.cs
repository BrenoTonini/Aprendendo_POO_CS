class Cliente
{
    private string nome;
    private string dtNascimento;
    private float carteira;
    private bool isMaiorDeIdade;


    public Cliente(string nome, string dtNascimento, float carteira){
      this.nome = nome;
      this.carteira = carteira;//Qtd de dinheiro do cliente
      this.dtNascimento = dtNascimento;
      this.isMaiorDeIdade = maiorIdade();
        
    }

  public string getNome(){
    return nome;
  }
  
  public void setNome(string nome){
    this.nome = nome;
  }
  
  public string getDtNascimento(){
    return dtNascimento;
  }
  public void setDtNascimento(string dtNascimento){
    this.dtNascimento = dtNascimento;
    isMaiorDeIdade = maiorIdade();  
  }

  public float getCarteira(){
    return carteira;
  }
  public void setCarteira(float carteira){
    this.carteira = carteira;
  }

  public bool getIsMaiorDeIdade(){
    return isMaiorDeIdade;
  }//O set do maior idade está no set da idade

    public bool maiorIdade(){
      string[] stringNascrimento = dtNascimento.Split('/', '-', ' ');
      int ano = int.Parse(stringNascrimento[2]);
      int mes = int.Parse(stringNascrimento[1]);
        //ano > 2003 ? return True : return False;
      if (ano<2005){
        return true;
      }else{
        return false;
      }
    }

  

}