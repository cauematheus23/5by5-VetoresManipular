int[] vetor = new int[10];
int cont_pares = 0, cont_impares = 0, cont_vetor = 0,c1 = 0, c2 = 0;
for (int i = 0; i < 10; i++)
{
    do {
        Console.WriteLine($"Digite o {i + 1}° valor: ");
        vetor[i] = int.Parse(Console.ReadLine());
    } while (vetor[i] < 0);
    cont_vetor++;
    if (vetor[i] %2 == 0)
    {
        cont_pares ++;
    }
    else
    {
        cont_impares++;
    }
}
int[] pares = new int[cont_pares];
int[] impares = new int[cont_impares];
Console.WriteLine("Vetor Lido");
for (int i = 0; i < 10; i++)
{
    Console.Write(vetor[i] + " ");
    
}
Console.WriteLine();
Console.WriteLine("Vetor de traz pra frente");
for (int i = 9; i >=0 ; i--)
{
    Console.Write(vetor[i] + " ");
}
Console.WriteLine();
Console.WriteLine("Metade do vetor");
cont_vetor =  cont_vetor / 2;
for (int i = 0; i < cont_vetor; i++)
{
    Console.Write(vetor[i] + " ");
}
Console.WriteLine();
Console.WriteLine("Guardar os valores pares e impares");

for (int i = 0; i <10; i++)
{
    if (vetor[i] % 2 == 0)
    {
        pares[c1] = vetor[i];
        c1 ++;

    }
    else
    {
        impares[c2] = vetor[i];
        c2++;
    }
}
Console.WriteLine("Vetor pares");
for (int i = 0; i < cont_pares; i++)
{
    Console.Write(pares[i] + " ");

}
Console.WriteLine();
Console.WriteLine("Vetor Impares");
for (int i = 0; i < cont_impares; i++)
{
    Console.Write(impares[i] + " ");

}
