public abstract class Pessoa
{
    public Pessoa(string? nome, int idade, int cPF, int rG)
    {
        this.Nome = nome;
        this.Idade = idade;
        this.CPF = cPF;
        this.RG = rG;
    }
    
    public string? Nome {get;private set;}
    public int Idade {get;private set;}
    public int CPF {get;private set;}
    public int RG {get;private set;}

}

