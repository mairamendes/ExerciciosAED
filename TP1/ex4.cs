using System;

class Program
{
    private static void Main()
    {
        if (!int.TryParse(Console.ReadLine(), out int n) || n <= 0)
        {
            Console.WriteLine("Número de casos de teste inválido");
            return;
        }

        for (int i = 0; i < n; i++)
        {
            int[] vencedores = new int[101];
            const int num_linhas = 15;

            for (int j = 0; j < num_linhas; j++)
            {
                string entrada = Console.ReadLine();
                if (string.IsNullOrEmpty(entrada))
                {
                    Console.WriteLine($"Erro: linha {j + 1} vazia");
                    return;
                }

                string[] jogo = entrada.Trim().Split(' ');
                if (jogo.Length < 3 || !int.TryParse(jogo[2], out int v) || v < 0 || v > 100)
                {
                    Console.WriteLine($"Erro: valor inválido na linha {j + 1}");
                    return;
                }

                vencedores[v]++;
            }

            for (int j = 1; j <= 100; j++)
            {
                int vitorias = vencedores[j];
                if (vitorias > 0)
                {
                    int grupo;
                    if (vitorias == 6)
                        grupo = 1;
                    else if (vitorias == 3 || vitorias == 4)
                        grupo = 2;
                    else if (vitorias == 1 || vitorias == 2)
                        grupo = 3;
                    else
                        grupo = -1;

                    if (grupo != -1)
                    {
                        Console.WriteLine($"{j} {grupo}");
                    }
                }
            }
        }
    }
}