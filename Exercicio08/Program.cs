int auxIdade=0;
string auxNome="";

Pessoas[] vetpessoas = new Pessoas[3];

for (int i = 0; i < vetpessoas.Length; i++)
{
    vetpessoas[i] = new Pessoas();
    Console.Write($"Escreva o nome da {i+1}ª pessoa: ");
    vetpessoas[i].Nome = Console.ReadLine()!;
    Console.Write($"Escreva a Idade da {i+1}ª pessoa: ");
    vetpessoas[i].Idade = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("---------------------");
}

Console.WriteLine("Os nomes por ordem crescente de Idade são: ");
for (int i = 0; i < vetpessoas.Length; i++)
{
    for (int j = i+1; j < vetpessoas.Length; j++)
    {
        if(vetpessoas[i].Idade>vetpessoas[j].Idade)
        {
            auxIdade = vetpessoas[i].Idade;
            auxNome = vetpessoas[i].Nome;

            vetpessoas[i].Idade = vetpessoas[j].Idade;
            vetpessoas[i].Nome = vetpessoas[j].Nome;

            vetpessoas[j].Idade = auxIdade;
            vetpessoas[j].Nome = auxNome;
        }
    }
}

for (int i = 0; i < vetpessoas.Length; i++)
{
    Console.WriteLine($"Nome: {vetpessoas[i].Nome} \tIdade: {vetpessoas[i].Idade}");
    
}

//Console.WriteLine($"Nome: {vetpessoas[i].Nome} Idade: {vetpessoas[i].Idade}");
