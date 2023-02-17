double menorValor=0;
double maiorValor=0;
Ingressos[] vetIngressos = new Ingressos[3];

for (int i = 0; i < vetIngressos.Length; i++)
{
    Console.WriteLine($"{i+1}º Ingresso: ");
    vetIngressos[i] = new Ingressos();
    Console.Write("Atração: ");
    vetIngressos[i].Atracao = Console.ReadLine()!;
    Console.Write("Local: ");
    vetIngressos[i].Local = Console.ReadLine()!;
    Console.Write("Valor: ");
    vetIngressos[i].Preco = Convert.ToDouble(Console.ReadLine()!);
    Console.WriteLine("---------------------");
    
}

maiorValor = vetIngressos[0].Preco;
menorValor = vetIngressos[0].Preco;
for (int i = 0; i < vetIngressos.Length; i++)
{
    if(vetIngressos[i].Preco > maiorValor)
    {
        maiorValor = vetIngressos[i].Preco;
    } else if (vetIngressos[i].Preco < menorValor)
    {
        menorValor = vetIngressos[i].Preco;
    }
}
Console.WriteLine($"O ingresso de menor valor é {menorValor}");
Console.WriteLine($"O ingresso de maior valor é {maiorValor}");


