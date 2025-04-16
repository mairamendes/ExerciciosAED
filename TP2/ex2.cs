using System;

class ex2
{
    /// <summary>
    /// A primeira linha da entrada contém um inteiro N indicando quantidade de números inteiros do primeiro vetor que estará na linha a seguir (2 <= N <= 100). A terceira linha da entrada contém um inteiro M indicando quantidade de números inteiros do segundo vetor que estará na linha a seguir (2 <= M <= 100). Em todo os dois vetores os núeros estarão em ordem crescente e não haverá números em comum entre os dois conjuntos.
    /// Deverá conter uma linha para os N+M números apresentados na entrada com os valores intercalados e em ordem crescente.
    /// </summary>
    
    static void ConverterVetor(int[] vetor, string[] valores, int pos)
    {
        if (pos == vetor.Length)
            return;

        vetor[pos] = int.Parse(valores[pos]);
        ConverterVetor(vetor, valores, pos + 1);
    }

    static void JuntarVetores(int[] vetor1, int[] vetor2, int[] vetorPrincipal, int i, int j)
    {
        if (i < vetor1.Length)
        {
            vetorPrincipal[i] = vetor1[i];
            JuntarVetores(vetor1, vetor2, vetorPrincipal, i + 1, j);
        }
        else if (j < vetor2.Length)
        {
            vetorPrincipal[i + j] = vetor2[j];
            JuntarVetores(vetor1, vetor2, vetorPrincipal, i, j + 1);
        }
    }

    static int[] VetorPrincipal(int[] vetor1, int[] vetor2)
    {
        int[] vetorPrincipal = new int[vetor1.Length + vetor2.Length];
        JuntarVetores(vetor1, vetor2, vetorPrincipal, 0, 0);
        return vetorPrincipal;
    }

    // Ordenar o vetor com recursão 
    static void OrdenarVetor(int[] vetor, int tamanho)
    {
        if (tamanho == 1) return;

        TrocarElementos(vetor, 0, tamanho);
        OrdenarVetor(vetor, tamanho - 1);
    }

    static void TrocarElementos(int[] vetor, int pos, int tamanho)
    {
        if (pos == tamanho - 1) return;

        if (vetor[pos] > vetor[pos + 1])
        {
            int temp = vetor[pos];
            vetor[pos] = vetor[pos + 1];
            vetor[pos + 1] = temp;
        }

        TrocarElementos(vetor, pos + 1, tamanho);
    }

    // Imprimir o vetor
    static void ImprimirVetor(int[] vetor, int pos)
    {
        if (pos == vetor.Length)
        {
            return;
        }

        Console.WriteLine(vetor[pos]);
        if (pos < vetor.Length - 1)

        ImprimirVetor(vetor, pos + 1);
    }

    private static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string[] valoresVetor1 = Console.ReadLine().Split(' ');
        int[] vetor1 = new int[n];
        ConverterVetor(vetor1, valoresVetor1, 0);

        int m = int.Parse(Console.ReadLine());
        string[] valoresVetor2 = Console.ReadLine().Split(' ');
        int[] vetor2 = new int[m];
        ConverterVetor(vetor2, valoresVetor2, 0);

        int[] vetorPrincipal = VetorPrincipal(vetor1, vetor2);

        OrdenarVetor(vetorPrincipal, vetorPrincipal.Length);

        ImprimirVetor(vetorPrincipal, 0);
    }
}
