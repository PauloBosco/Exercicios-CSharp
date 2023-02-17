class Funcionario
{
    private string? nome;
    private int valorPorHora;
    private int horasTrabalhadas;
    private static int numFunc = 0;
    private static int totalPago = 0;
     
    public Funcionario(string? nome, int valorPorHora, int horasTrabalhadas)
    {
        this.nome = nome;
        this.valorPorHora = valorPorHora;
        this.horasTrabalhadas = horasTrabalhadas;
        numFunc ++;
        totalPago += valorPorHora *horasTrabalhadas;
    }
   
    public int valorPago(){
        return valorPorHora*horasTrabalhadas;
    }

    public static int retornaNumFunc(){
        return Funcionario.numFunc;
    }

    public static int retornaTotalPago(){
        return Funcionario.totalPago;
    }


     
}
