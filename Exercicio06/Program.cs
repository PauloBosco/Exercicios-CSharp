Ponto a = new Ponto();
Ponto b = new Ponto();

Console.WriteLine("Ponto A:");
lePonto(a);
Console.WriteLine("Ponto B:");
lePonto(b);


double distancia = a.distancia(b);

Console.WriteLine($"A distância entre o Ponto A e B é {distancia:n2}");

static void lePonto(Ponto obj)
{
    Console.WriteLine("Digite o eixo X");
    obj.X = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Digite o eixo Y");
    obj.Y = Convert.ToInt32(Console.ReadLine());
}
