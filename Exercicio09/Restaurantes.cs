class Restaurante
{
    private string nome="";
    private string endereco="";
    private string tipoComida="";
    private double notaCozinha;

    public string NomeRestaurante
    {
        get{return nome;}
        set{nome = value;}
    }
    public string Endereço
    {
        get{ return endereco;}
        set{ endereco = value;}
    }
    public string TipoComida
    {
        get{ return tipoComida;}
        set{
            while((value != "Brasileira") && (value != "Chinesa") && (value != "Francesa") && (value != "Italiana") && (value != "Japonesa"))
            {
                Console.WriteLine("Escolha dentre as comidas possíveis");
                value = Console.ReadLine()!;
            }
            tipoComida = value;
        }
    }
    public double NotaCozinha
    {
        get{return notaCozinha;}
        set{
            while((value<0) || (value>5))
            {
                Console.WriteLine("Escolha uma nota de 0 a 5");
                value = Convert.ToDouble(Console.ReadLine());
            }
               notaCozinha = value; 
        }
    }
}


