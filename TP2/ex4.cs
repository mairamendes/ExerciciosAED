using System;

class ex4
{

    static void LerNumeros(int[] numeros, int pos)
    {
        if (pos >= numeros.Length)
            return;

        numeros[pos] = int.Parse(Console.ReadLine());
        LerNumeros(numeros, pos + 1);
    }
    static void ImprimirVetorBinario(int[] numeros, int pos)
    {
        if (pos >= numeros.Length)
            return;

        int valor = numeros[pos];
        ConverterValor(valor);

        Console.WriteLine();
        ImprimirVetorBinario(numeros, pos + 1);
    }

    static void ConverterValor(int numero)
    {
        if (numero > 1)
            ConverterValor(numero / 2);
        Console.Write(numero % 2);
    }

    private static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] i = new int[n];
        LerNumeros(i, 0);
        ImprimirVetorBinario(i, 0);
        Console.WriteLine();

    }
}