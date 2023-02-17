class Ingressos
{
    private double _preco;
    private string? _local;
    private string? _atracao;

    public double Preco
    { 
        get{return _preco;}
        set{_preco = value;}
    }

    public string? Local 
    {
        get{return _local;}
        set{_local = value;}
    }
    
    public string? Atracao 
    {
        get{return _atracao;}
        set{_atracao = value;}
    }

    public void novoValorIngresso(string atracao, double novoValor)
    {
        if(atracao == this._local)
        {
        this._local = atracao;
        this._preco = novoValor;
        }else{
            Console.WriteLine("Atração nao encontrada");
        }
       
    }

    public void mostraInformaçoes()
    {
        Console.WriteLine(this.Atracao);
        Console.WriteLine(this.Local);
        Console.WriteLine($"{this.Preco:C}");
    }
}