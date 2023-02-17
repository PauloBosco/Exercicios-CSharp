class pessoa
{
    private string nome="";
    private double peso,altura;

    public string NomePessoa
    {
        get{ return nome;}
        set{nome = value;}
    }
    
    public double PesoPessoa
    {
        get{ return peso;}
        set{ peso = value;}
    }

    public double AlturaPessoa
    {
        get { return altura;}
        set { altura = value;}
    }
}