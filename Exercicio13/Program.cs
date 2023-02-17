int opcao,indiceCadastro;
string respCadastro;
bool istrue = true;
Veiculo[] vetVeiculo = new Veiculo[2];

menu();


void CadastroVeiculo(Veiculo[] vetVeiculo)
{
    /* Console.Clear();
    Console.Write("Digite o índice que deseja Cadastrar: ");
    indiceCadastro = Int32.Parse(Console.ReadLine()!);
    vetVeiculo[indiceCadastro] = cadastroObjetoVeiculo();

    while(istrue)
    {
        Console.WriteLine("Deseja continuar cadastrando? (s/n)");
        respCadastro = Console.ReadLine()!;
        if(respCadastro == "s")
        {
            CadastroVeiculo(vetVeiculo);
            continue;

        }else if (respCadastro == "n") {
            menu();
            istrue=false;
            continue;
        }else{
            Console.WriteLine("Resposta Inválida");
            Thread.Sleep(1000);
            continue;
        }
    } */

    for (int i = 0; i < vetVeiculo.Length; i++)
    {
        Console.WriteLine($"Veiculo {i + 1} ");
        vetVeiculo[i] = cadastroObjetoVeiculo();
        Console.WriteLine("----------------");
    }
    menu();
}
    

void menu()
{
    Console.WriteLine("--------MENU CADASTRO VEÍCULOS--------");
    Console.WriteLine("[1] Cadastrar Veículo");
    Console.WriteLine("[2] Validar Placa");
    Console.WriteLine("[3] Pesquisar Veículos por ANO");
    Console.WriteLine("[4] Pesquisar Veículos por PLACA");
    Console.WriteLine("[5] Mostrar TODOS os veículos cadastrados");
    Console.WriteLine("[6] Sair");

    Console.Write("Digite a opção: ");
    opcao = Int32.Parse(Console.ReadLine()!);
    Console.WriteLine();

    switch (opcao)
    {
        case 1:
            CadastroVeiculo(vetVeiculo);
            break;
        case 2:
            validaPlaca(vetVeiculo);
            break;
        case 3:
            imprimePorAno(vetVeiculo);
            break;
        case 4:
            imprimePorPlaca(vetVeiculo);
            break;
        case 5:
            mostrarVeiculosCadastrados(vetVeiculo);
            break;
        case 6:
            break;
        default:
            Console.WriteLine("Opção INVÁLIDA.");
            break;
    }
}

void validaPlaca(Veiculo[] vetVeiculo)
{
    int z=0;
    string imprimePlaca;
    Console.Write($"Informe a Placa que gostaria de validar: ");
    imprimePlaca = Console.ReadLine()!;

    for (int i = 0; i < vetVeiculo.Length; i++)
    {
        if(imprimePlaca.Length == 7 && imprimePlaca == vetVeiculo[i].Placa)
        {
            Console.WriteLine("Placa VÁLIDA.");
            z++;
        }
    }

    if(z==0)
    {
        Console.WriteLine("Placa INVÁLIDA.");
    }else
    {
        z=0;
    }

     while(istrue)
    {
        Console.WriteLine("Deseja voltar ao Menu Principal? (s/n)");
        respCadastro = Console.ReadLine()!.ToLower();
        if(respCadastro == "s")
        {
            menu();
            istrue=false;
            continue;
        
        }else if (respCadastro == "n"){
            break;
        
        }else{
            Console.WriteLine("Resposta Inválida");
            Thread.Sleep(1000);
            continue;
        }
    }
}

Veiculo cadastroObjetoVeiculo()
{
    Veiculo objeto = new Veiculo();
    Console.Write("Placa: ");
    objeto.Placa = Console.ReadLine();
    Console.Write("Marca: ");
    objeto.Marca = Console.ReadLine();
    Console.Write("Modelo: ");
    objeto.Modelo = Console.ReadLine();
    Console.Write("Ano: ");
    objeto.Ano = Int32.Parse(Console.ReadLine()!);

    return objeto;
}

void imprimePorPlaca(Veiculo[] vetVeiculo)
{
    string imprimePlaca;
    Console.Write($"Informe a Placa que gostaria de consultar: ");
    imprimePlaca = Console.ReadLine()!;
    Console.WriteLine();
    for (int i = 0; i < vetVeiculo.Length; i++)
    {
        if(imprimePlaca == vetVeiculo[i].Placa)
        {
            Console.WriteLine($"Imprimindo Veículo de placa {vetVeiculo[i].Placa}");
            Console.WriteLine($"Marca: {vetVeiculo[i].Marca}");
            Console.WriteLine($"Modelo: {vetVeiculo[i].Modelo}");
            Console.WriteLine($"Placa: {vetVeiculo[i].Placa}");
            Console.WriteLine($"Ano: {vetVeiculo[i].Ano}");
            Console.WriteLine();
        }
    }
}

void imprimePorAno(Veiculo[] vetVeiculo)
{
    int anoMinimo, anoMaximo;
    Console.WriteLine("Qual o ano MÍNIMO: ");
    anoMinimo = Int32.Parse(Console.ReadLine()!);
    Console.WriteLine("Qual o ano MÁXIMO: ");
    anoMaximo = Int32.Parse(Console.ReadLine()!);
    for (int i = 0; i < vetVeiculo.Length; i++)
    {
        if(anoMinimo <= vetVeiculo[i].Ano && anoMaximo >= vetVeiculo[i].Ano)
        {
            Console.WriteLine($"Veículo {i+1}");
            Console.WriteLine($"Marca: {vetVeiculo[i].Marca}");
            Console.WriteLine($"Modelo: {vetVeiculo[i].Modelo}");
            Console.WriteLine($"Placa: {vetVeiculo[i].Placa}");
            Console.WriteLine($"Ano: {vetVeiculo[i].Ano}");
            Console.WriteLine();
        }
    }
}

void mostrarVeiculosCadastrados(Veiculo[] vetVeiculo)
{
    for (int i = 0; i < vetVeiculo.Length; i++)
    {
        Console.WriteLine($"Veículo {i+1}");
        Console.WriteLine($"Marca: {vetVeiculo[i].Marca}");
        Console.WriteLine($"Modelo: {vetVeiculo[i].Modelo}");
        Console.WriteLine($"Placa: {vetVeiculo[i].Placa}");
        Console.WriteLine($"Ano: {vetVeiculo[i].Ano}");
        Console.WriteLine();
    }
}