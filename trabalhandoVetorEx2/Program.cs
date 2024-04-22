int[] numeros = new int[10];
int[] impares =  new int[10];
int MaxValue = 10, contadorImp = 0;

Console.WriteLine("Digite um numero: ");

for (int i = 0; i < MaxValue; i++)
{
    numeros[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine("\nImpressão:");

for (int i = 0; i < MaxValue; i++)
{
    Console.WriteLine(numeros[i]);
}

Console.WriteLine("\nInvertido:");

for (int i = 9; i >= 0; i--)
{
    Console.WriteLine(numeros[i]);
}

Console.WriteLine("\nImpressão pela metade:");

for (int i = 0; i < MaxValue / 2; i++)
{
    Console.WriteLine(numeros[i]);
}


for (int i = 0; i < MaxValue; i++)
{
    if (numeros[i] % 2 != 0)
    {
        impares[contadorImp] = numeros[i];
        contadorImp++;
    }
}

Console.WriteLine("\nImpares:");

for (int i = 0; i < contadorImp; i++)
{
    Console.WriteLine(impares[i]);
}