class Pessoa 
{
    private string nome="";
    private double salario;
    private int idade;

    public string NomePessoa
    {
        get { return nome; }
        set { nome = value; }
    }

    public double SalarioPessoa
    {
        get { return salario; }
        set { salario = value; }
    }

    public int IdadePessoa
    {
        get { return idade; }
        set { idade = value; }   
    }
}