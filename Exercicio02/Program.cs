pessoa pessoa1 = new pessoa();
Console.Write("Qual o seu nome? ");
pessoa1.NomePessoa = Console.ReadLine();
Console.Write("Qual o seu peso(kg)? ");
pessoa1.PesoPessoa = Convert.ToDouble(Console.ReadLine());
Console.Write("Qual sua altura(metros)? ");
pessoa1.AlturaPessoa = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("----------Resultado----------");
Console.WriteLine($"Nome: {pessoa1.NomePessoa}");
Console.WriteLine($"Peso: {pessoa1.PesoPessoa:n1} kg");
Console.WriteLine($"Altura: {pessoa1.AlturaPessoa:n2} m");