Funcionario x = new Funcionario("Maria",100,15);
Funcionario y = new Funcionario("Jorge",80,10);
var z = new Funcionario("Paulo",75,8);




Console.WriteLine("Salário pago para {0} x: {1}",x.GetType(),x.valorPago());
Console.WriteLine("Salário pago para {0} y: {1}",y.GetType(),y.valorPago());
Console.WriteLine("Salário pago para {0} z: {1}",z.GetType(),z.valorPago());
Console.WriteLine();

Console.WriteLine("Número de Funcionários: {0}",Funcionario.retornaNumFunc());
Console.WriteLine("Total Pago............: {0}",Funcionario.retornaTotalPago());
