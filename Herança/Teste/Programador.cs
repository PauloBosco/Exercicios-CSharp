public sealed class Programador : Funcionario, IContrato
{
    public Programador(string? nome, int idade, int cPF, int rG, int salario, int numMatricula) : base(nome, idade, cPF, rG, salario, numMatricula)
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
        return $"O {this.Nome} está trabalhando";
    }

    public string Programar()
    {
        return $"O {this.GetType()} {this.Nome} está programando.";
    }
}