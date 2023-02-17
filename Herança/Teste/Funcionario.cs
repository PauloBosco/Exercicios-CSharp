public abstract class Funcionario : Pessoa
{
    public Funcionario(string? nome, int idade, int cPF, int rG, int salario, int numMatricula) : base(nome, idade, cPF, rG)
    {
        this.Salario = salario;
        this.NumMatricula = numMatricula;
    }
    public int Salario {get;set;}
    public int NumMatricula {get;set;}
}