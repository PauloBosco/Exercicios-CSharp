double menorDistancia;
string indice;
Ponto a = new Ponto();
Ponto b = new Ponto();
Ponto c = new Ponto();
Ponto d = new Ponto();

Console.WriteLine("Ponto A:");
lePonto(a);
Console.WriteLine("Ponto B:");
lePonto(b);
Console.WriteLine("Ponto C:");
lePonto(c);
Console.WriteLine("Ponto D:");
lePonto(d);

double distanciaAB = a.distancia(b);
double distanciaAC = a.distancia(c);
double distanciaAD = a.distancia(d);
menorDistancia = distanciaAB;
indice = "A-B";
if(menorDistancia>distanciaAC)
{
    menorDistancia = distanciaAC;
    indice ="A-C";
}else if(menorDistancia>distanciaAD) {
    menorDistancia = distanciaAD;
    indice = "A-D";
}
Console.WriteLine($"A distancia entre o Ponto A - B é: {a.distancia(b):n2}");
Console.WriteLine($"A distancia entre o Ponto A - C é: {a.distancia(c):n2}");
Console.WriteLine($"A distancia entre o Ponto A - D é: {a.distancia(d):n2}");
Console.WriteLine("------------------------------------------------------------------");
Console.WriteLine($"A menor distância entre os Pontos A,B,C e D é o ponto {indice} com a distância {menorDistancia:n2} ");


static void lePonto(Ponto obj)
{
    Console.WriteLine("Digite o eixo X");
    obj.X = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Digite o eixo Y");
    obj.Y = Convert.ToInt32(Console.ReadLine());
}
