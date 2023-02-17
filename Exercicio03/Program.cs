pessoa joao = new pessoa();
joao.NomePessoa = "João";
joao.PesoPessoa = 98;
joao.AlturaPessoa = 1.90;

pessoa maria = new pessoa();
maria.NomePessoa = "Maria";
maria.PesoPessoa = 55;
maria.AlturaPessoa = 1.50;

Console.Write("Qual a nova altura de João? ");
joao.AlturaPessoa = Convert.ToDouble(Console.ReadLine());
Console.Write("Qual o novo peso de Maria? ");
maria.PesoPessoa = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"A média das Alturas entre João e Maria é: {(joao.AlturaPessoa + maria.AlturaPessoa)/2:n2} ");
Console.WriteLine($"A média dos pesos entre João e Maria é: {(joao.PesoPessoa + maria.PesoPessoa)/2} ");