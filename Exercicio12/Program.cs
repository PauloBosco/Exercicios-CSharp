double media = 0;
LojasEletro[] vetLojas = new LojasEletro[3];

for (int i = 0; i < vetLojas.Length; i++)
{
    Console.WriteLine($"Loja {i + 1}:");
    vetLojas[i] = leLojas();
    Console.WriteLine();
}

menu(vetLojas);
Console.WriteLine();
media = retornaMedia(vetLojas);
Console.WriteLine($"A média de Preço das Lojas é: {media:C}");
Console.WriteLine();
retornaValorAbaixoMedia(media, vetLojas);

static void menu(LojasEletro[] vetLojas)
{
    int opcao;
    string nomeLoja;
    int telefoneLoja;
    double valor;

    Console.WriteLine("------------Menu de Lojas------------");
    Console.WriteLine("[1] - Ler informações de todas as Lojas");
    Console.WriteLine("[2] - Procurar por nome");
    Console.WriteLine("[3] - Procurar por telefone");
    Console.WriteLine("[4] - Procurar por valor");
    Console.WriteLine("[5] - Sair");
    Console.WriteLine();
    Console.Write("Digite a Opção escolhida: ");
    opcao = Convert.ToInt32(Console.ReadLine()!);

    while ((opcao != 1) && (opcao != 2) && (opcao != 3) && (opcao != 4) && (opcao != 5))
    {
        Console.WriteLine("Digite um Valor válido: ");
        Console.Write("Digite novamente: ");
        opcao = Convert.ToInt32(Console.ReadLine());
    }

    if (opcao == 1)
    {
        imprimeTodasLojas(vetLojas);
    }
    else if (opcao == 2)
    {
        Console.WriteLine("Digite o nome que deseja procurar: ");
        nomeLoja = Console.ReadLine()!;
        for (int i = 0; i < vetLojas.Length; i++)
        {
            if (nomeLoja == vetLojas[i].NomeLoja)
            {
                Console.WriteLine("-----------------");
                Console.WriteLine($"Nome da Loja: {vetLojas[i].NomeLoja} ");
                Console.WriteLine($"Telefone Loja: {vetLojas[i].Telefone} ");
                Console.WriteLine($"Valor do Eletrodoméstico: {vetLojas[i].Preco} ");
                Console.WriteLine("-----------------");
            }
        }
    }
    else if (opcao == 3)
    {
        Console.WriteLine("Digite o telefone que deseja procurar: ");
        telefoneLoja = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < vetLojas.Length; i++)
        {
            if (telefoneLoja == vetLojas[i].Telefone)
            {
                Console.WriteLine("-----------------");
                Console.WriteLine($"Nome da Loja: {vetLojas[i].NomeLoja} ");
                Console.WriteLine($"Telefone Loja: {vetLojas[i].Telefone} ");
                Console.WriteLine($"Valor do Eletrodoméstico: {vetLojas[i].Preco} ");
                Console.WriteLine("-----------------");
            }
        }
    }
    else if (opcao == 4)
    {
        Console.WriteLine("Digite o valor que deseja procurar: ");
        valor = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < vetLojas.Length; i++)
        {
            if (valor == vetLojas[i].Preco)
            {
                Console.WriteLine("-----------------");
                Console.WriteLine($"Nome da Loja: {vetLojas[i].NomeLoja} ");
                Console.WriteLine($"Telefone Loja: {vetLojas[i].Telefone} ");
                Console.WriteLine($"Valor do Eletrodoméstico: {vetLojas[i].Preco} ");
                Console.WriteLine("-----------------");
            }
        }
    }
    else if (opcao == 5)
    {
        Console.WriteLine("Obrigado por Usar o programa.");
    }
}

static void imprimeTodasLojas(LojasEletro[] vetLojas)
{
    Console.WriteLine("--------Imprimindo todas as Lojas--------");
    for (int i = 0; i < vetLojas.Length; i++)
    {
        Console.WriteLine($"Loja {i + 1}:");
        Console.Write("Nome da Loja: ");
        Console.WriteLine($"{vetLojas[i].NomeLoja}");
        Console.Write("Telefone: ");
        Console.WriteLine($"{vetLojas[i].Telefone}");
        Console.Write("Preço: ");
        Console.WriteLine($"{vetLojas[i].Preco}");
        Console.WriteLine();
    }
}

static LojasEletro leLojas()
{
    LojasEletro objeto = new LojasEletro();
    Console.Write("Nome da Loja: ");
    objeto.NomeLoja = Console.ReadLine()!;
    Console.Write("Telefone: ");
    objeto.Telefone = Convert.ToInt32(Console.ReadLine());
    Console.Write("Preço: ");
    objeto.Preco = Convert.ToDouble(Console.ReadLine());

    return objeto;
}

static double retornaMedia(LojasEletro[] vetLojas)
{
    double media = 0;
    double soma = 0;
    for (int i = 0; i < vetLojas.Length; i++)
    {
        soma += vetLojas[i].Preco;
        media = soma / vetLojas.Length;
    }
    return media;
}

static void retornaValorAbaixoMedia(double media, LojasEletro[] vetLojas)
{
    Console.WriteLine($"As lojas com preço abaixo da média sao: ");
    for (int i = 0; i < vetLojas.Length; i++)
    {
        if (vetLojas[i].Preco < media)
        {
            Console.WriteLine($"Loja: {vetLojas[i].NomeLoja} \tPreço: {vetLojas[i].Preco:C}");
        }
    }
}