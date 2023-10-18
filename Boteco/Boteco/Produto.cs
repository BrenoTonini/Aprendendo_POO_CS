class Produto
{
    private string nomeProd;
    private float preco;
    private bool alcolico;
    private string codBarra;

    public Produto(string nomeProd, float preco, bool alcolico, string codBarra)
    {
        this.nomeProd = nomeProd;
        this.preco = preco;
        this.alcolico = alcolico;
        this.nomeProd = nomeProd;
    }

    public string getNomeProd()
    {
        return nomeProd;
    }
    public void setNomeProd(string nomeProd)
    {
        this.nomeProd = nomeProd;
    }
    public float getPreco()
    {
        return preco;
    }
    public void setPreco(float preco)
    {
        this.preco = preco;
    }
    public bool getAlcolico()
    {
        return alcolico;
    }
    public void setPreco(bool alcolico)
    {
        this.alcolico = alcolico;
    }
    public string getCodBarra()
    {
        return codBarra;
    }
    public void setCodBarra(string codBarra)
    {
        this.codBarra = codBarra;
    }
}

