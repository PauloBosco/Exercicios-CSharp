class Veiculo
{
    private string? _placa,_marca,_modelo;
    private int _ano;

    public string? Placa{
        get{ return _placa;}
        set{_placa = value;}
    }

    public string? Marca{
        get{ return _marca;}
        set{_marca = value;}
    }
    public string? Modelo{
        get{ return _modelo;}
        set{_modelo = value;}
    }
    public int Ano{
        get{ return _ano;}
        set{_ano = value;}
    }
}