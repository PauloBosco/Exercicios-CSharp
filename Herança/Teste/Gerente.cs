public sealed class Gerente : Funcionario , IContrato
{
    public Gerente(string? nome, int idade, int cPF, int rG, int salario, int numMatricula) : base(nome, idade, cPF, rG, salario, numMatricula)
    {
    }

    public string Almocar()
    {
        return $"{this.Nome} está almoçando.";
    }

    public void BaterPonto()
    {
        
    }

    public string Trabalhar()
    {
         return $"O {this.GetType()} {this.Nome} está trabalhando";
    }

    public string Delegar(object? obj)
    {
        return $"{this.Nome} está delegando alguma tarefa para {obj}";
    }
}