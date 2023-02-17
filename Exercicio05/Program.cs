Pessoa[] pessoas = new Pessoa[6];

lePessoas(pessoas);

static void lePessoas(Pessoa[] pessoas)
{
    double somaSalario=0,somaIdades=0;
    for (int i = 0; i < pessoas.Length; i++)
    {
        Console.WriteLine($"Pessoa {i+1}/{pessoas.Length}");
        pessoas[i] = new Pessoa();
        Console.Write("Nome: ");
        pessoas[i].NomePessoa = Console.ReadLine()!;
        Console.Write("Salario: ");
        pessoas[i].SalarioPessoa = Convert.ToDouble(Console.ReadLine());
        Console.Write("Idade: ");
        pessoas[i].IdadePessoa = Convert.ToInt32(Console.ReadLine());
        somaSalario += pessoas[i].SalarioPessoa;
        somaIdades += pessoas[i].IdadePessoa;
        Console.WriteLine("--------------------");
    }
    Console.WriteLine($"A média salarial dos entrevistados foi: {somaSalario/pessoas.Length:n2}");
    Console.WriteLine($"A média de Idades dos entrevistados foi: {somaIdades/pessoas.Length:n1}");
}



