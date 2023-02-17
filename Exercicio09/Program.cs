double maiorNota=0;
string enderecoMaiorNota="";
Restaurante[] vetrest = new Restaurante[3];

for (int i = 0; i < vetrest.Length; i++)
{
   vetrest[i] = new Restaurante();
   Console.Write($"Digite o nome do {i+1}º restaurante: ");
   vetrest[i].NomeRestaurante = Console.ReadLine()!;
   Console.Write($"Digite o endereço: ");
   vetrest[i].Endereço = Console.ReadLine()!;
   Console.Write($"Qual o tipo de comida? ");
   vetrest[i].TipoComida = Console.ReadLine()!;
   Console.Write($"Qual a nota da Cozinha? [digite de 0 a 5] ");
   vetrest[i].NotaCozinha = Convert.ToDouble(Console.ReadLine());
   Console.WriteLine();
}

Console.WriteLine("A lista dos Restaurantes cadastrados foram: ");
for (int i = 0; i < vetrest.Length; i++)
{
    Console.WriteLine(vetrest[i].NomeRestaurante);
}

Console.WriteLine();

for (int i = 0; i < vetrest.Length; i++)
{
 maiorNota = vetrest[0].NotaCozinha;
 enderecoMaiorNota = vetrest[0].Endereço;
 if(vetrest[i].NotaCozinha > maiorNota )
 {
    maiorNota = vetrest[i].NotaCozinha;
    enderecoMaiorNota = vetrest[i].Endereço;
 }

}

Console.WriteLine($"O Restaurante com maior nota foi {maiorNota} com o endereço {enderecoMaiorNota}");
