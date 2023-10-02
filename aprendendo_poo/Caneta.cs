class Caneta{
    private string cor;
    private float tamanhoPonta;
    private int qntTinta;


    public Caneta(string cor, float tamanhoPonta, int qntTinta){
        this.cor = cor;
        this.tamanhoPonta = tamanhoPonta;
        this.qntTinta = qntTinta;
    }

    public void setCor(string cor){
        this.cor = cor;
    }

    public string getCor(){
        return cor;
    }

    public void setTamanhoPonta(float tamanhoPonta){
        this.tamanhoPonta = tamanhoPonta;
    }

    public float getTamanhoPonta(){
        return tamanhoPonta;
    }

    public void setQntTinta(int qntTinta){
        this.qntTinta = qntTinta;
    }

    public int getQntTinta(){
        return qntTinta;
    }

    public void infoCaneta(){
        Console.WriteLine($"Caneta cor: {cor}, ponta tamanho: {tamanhoPonta}, tinta restante: {qntTinta}");
    }

    public bool escrever(int qntEscrita){
        if (this.qntTinta >= qntEscrita){
            qntTinta -= qntEscrita;
            return true;
        }
        return false;
    }

    public void recarregar(int qntTinta){
        this.qntTinta += qntTinta;
    }

}