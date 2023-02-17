class Contato
{
    private string nome="",email="";
    private int telefone;
    private Endereco endereco;

    public string NomeContato
    {
        get { return nome; }
        set { nome = value; }
    }

    public string EmailContato
    {
        get { return email; }
        set { email = value; }
    }
    public int TelefoneContato
    {
        get { return telefone; }
        set { telefone = value; }
    }

    public Endereco Endereco {

    get { return endereco ; } 
    set { endereco = value; }

    }
}

class Endereco
{
    private string logradouro="", complemento="", bairro="", cidade="", uf="";
    private int numero;

    public string LogradouroContato
    {
        get { return logradouro; }
        set { logradouro = value; }
    }

    public string ComplementoContato
    {
        get { return complemento; }
        set { complemento = value; }
    }
    public string BairroContato
    {
        get { return bairro; }
        set { bairro = value; }
    }

    public string CidadeContato
    {
        get { return cidade; }
        set { cidade = value; }
    }
    
    public string UfContato
    {
        get { return uf; }
        set { uf = value; }
    }
    public int NumeroContato
    {
        get { return numero; }
        set { numero = value; }
    }

}
