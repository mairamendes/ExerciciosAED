using System;

class Program
{
    private static void Main()
    {
        int n = int.Parse(Console.ReadLine()); // Número de Registros 
        int[] tempo = new int[101]; 
        int contador = 0;

        for (int i = 0; i < n; i++)
        {
            string[] registro = Console.ReadLine().Split(' ');
            string indicador = registro[0]; // R (Recebida), E (Enviada) ou T (Tempo)
            int numAmigo = int.Parse(registro[1]); // Número do amigo ou tempo 

            if (indicador == "T")
            {
                contador += numAmigo - 1; // Ajuste do tempo 
                continue;
            }
            else if (indicador == "R")
            {
                tempo[numAmigo] = contador; // Tempo de recebimento da mensagem
            }
            else if (indicador == "E")
            {
                if (tempo[numAmigo] >= 0)
                {
                    tempo[numAmigo] = contador - tempo[numAmigo]; // Calcula o tempo de resposta
                }
                else
                {
                    tempo[numAmigo] = -1; // Indica que não há resposta
                }
            }
            contador++; // +1 segundo para cada registro (R ou E)
        }

        for (int i = 1; i <= 100; i++)
        {
            if (tempo[i] != 0)
            {
                Console.WriteLine($"{i} {tempo[i]}");
            }
        }
    }
}
