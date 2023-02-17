class Pessoas
{
    private string nome="";
    private int idade;
 public string Nome
{
    get{return nome;}
    set
    {
        while(value.Length >100)
        {
            Console.WriteLine("ERRO. Digite um nome até 100 caracteres.");
            Console.Write("Digite novamente o nome: ");
            value = Console.ReadLine()!;
        }
        nome = value;
    }
}
    public int Idade
    {
        get{return idade;}
        set{idade=value;}
    }
}