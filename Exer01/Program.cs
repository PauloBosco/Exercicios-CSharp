cartaoCredito cartao1 = new cartaoCredito();
Console.Write("Digite o nome do cartao01: ");
cartao1.NomeCartao = Console.ReadLine();
Console.Write("Digite o número do cartao01: ");
cartao1.NumeroCartao = Convert.ToInt32(Console.ReadLine());
Console.Write("Digite a validade do cartao01: ");
cartao1.ValidadeCartao = Convert.ToInt32(Console.ReadLine());

cartaoCredito cartao2 = new cartaoCredito();
Console.Write("Digite o nome do cartao02: ");
cartao2.NomeCartao = Console.ReadLine();
Console.Write("Digite o número do carta02: ");
cartao2.NumeroCartao = Convert.ToInt32(Console.ReadLine());
Console.Write("Digite a validade do cartao02: ");
cartao2.ValidadeCartao = Convert.ToInt32(Console.ReadLine());


Console.WriteLine($"Nome:{cartao1.NomeCartao}");
Console.WriteLine($"Numero:{cartao1.NumeroCartao}");
Console.WriteLine($"Validade:{cartao1.ValidadeCartao}");

Console.WriteLine();

Console.WriteLine($"Nome:{cartao2.NomeCartao}");
Console.WriteLine($"Numero:{cartao2.NumeroCartao}");
Console.WriteLine($"Validade:{cartao2.ValidadeCartao}");