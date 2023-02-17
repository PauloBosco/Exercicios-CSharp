Programador programador1 = new Programador("Paulo",34,12345678,803812,2500,123);
Console.WriteLine(programador1.Programar());
Console.WriteLine(programador1.Almocar());


Console.WriteLine();

Gerente gerente1 = new Gerente("Andre",45,654789-78,56489789,4800,456);
Console.WriteLine(gerente1.Trabalhar());
Console.WriteLine(gerente1.Delegar(programador1.Nome));




