using System;
using System.Collections.Generic;

class ex3
{

    static void LerEntradas(List<int> deltas, List<int> idades, List<int> gestantes)
    {
        string linha = Console.ReadLine();
        if (linha == null || linha.Trim() == "-1")
            return;

        var partes = linha.Split(' ');
        deltas.Add(int.Parse(partes[0]));
        idades.Add(int.Parse(partes[1]));
        gestantes.Add(partes.Length > 2 && partes[2] == "G" ? 1 : 0);

        LerEntradas(deltas, idades, gestantes);
    }

    static void Tempos(int[] deltas, int[] chegada, int pos)
    {
        if (pos >= deltas.Length) return;
        chegada[pos] = (pos == 0 ? 0 : chegada[pos - 1]) + deltas[pos];
        Tempos(deltas, chegada, pos + 1);
    }

    static void InicializarFilas(Queue<int>[] filas, int pos)
    {
        if (pos >= filas.Length) return;
        filas[pos] = new Queue<int>();
        InicializarFilas(filas, pos + 1);
    }
    static int EnfileirarAteProximoFim(int tempoAtual, int indiceProx,
                                       int[] chegada, int[] idades, int[] gestantes,
                                       Queue<int>[] filas)
    {
        int limite = tempoAtual + 10;
        if (indiceProx >= chegada.Length || chegada[indiceProx] > limite)
            return indiceProx;

        if (idades[indiceProx] >= 80)
            filas[3].Enqueue(indiceProx);
        else if (idades[indiceProx] >= 60)
            filas[0].Enqueue(indiceProx);
        else if (gestantes[indiceProx] == 1)
            filas[1].Enqueue(indiceProx);
        else
            filas[2].Enqueue(indiceProx);

        return EnfileirarAteProximoFim(tempoAtual, indiceProx + 1,
                                       chegada, idades, gestantes, filas);
    }
    static int ObterProximaNoRodizio(int filaAtual, Queue<int>[] filas)
    {
        if (filas[filaAtual].Count > 0)
            return filaAtual;
        return ObterProximaNoRodizio((filaAtual + 1) % 3, filas);
    }

    static void ProcessarAtendimentos(int tempoAtual,
                                     int filaRodizio,
                                     int indiceChegada,
                                     int[] chegada,
                                     int[] idades,
                                     int[] gestantes,
                                     Queue<int>[] filas,
                                     List<int> atendidos)
    {
        indiceChegada = EnfileirarAteProximoFim(tempoAtual,
                                                indiceChegada,
                                                chegada, idades, gestantes, filas);

        bool temAlguem = filas[0].Count + filas[1].Count + filas[2].Count + filas[3].Count > 0;
        if (!temAlguem)
        {
            if (indiceChegada < chegada.Length)
            {
                ProcessarAtendimentos(chegada[indiceChegada],
                                      filaRodizio,
                                      indiceChegada,
                                      chegada, idades, gestantes, filas, atendidos);
            }
            return;
        }

        int filaEscolhida = filas[3].Count > 0
                            ? 3
                            : ObterProximaNoRodizio(filaRodizio, filas);

        int cliente = filas[filaEscolhida].Dequeue();
        atendidos.Add(idades[cliente]);

        int proximoRodizio = (filaEscolhida == 3)
                             ? filaRodizio
                             : (filaEscolhida + 1) % 3;

        ProcessarAtendimentos(tempoAtual + 10,
                              proximoRodizio,
                              indiceChegada,
                              chegada, idades, gestantes, filas, atendidos);
    }

    static void Imprimir(List<int> res, int pos)
    {
        if (pos >= res.Count) return;
        Console.WriteLine(res[pos]);
        Imprimir(res, pos + 1);
    }

    static void Main()
    {
        var deltas    = new List<int>();
        var idades    = new List<int>();
        var gestantes = new List<int>();

        LerEntradas(deltas, idades, gestantes);
        int n = deltas.Count;
        if (n == 0) return;

        var chegada = new int[n];
        Tempos(deltas.ToArray(), chegada, 0);

        var filas = new Queue<int>[4];
        InicializarFilas(filas, 0);

        var atendidos = new List<int>();

        ProcessarAtendimentos(0, 0, 0,
                              chegada,
                              idades.ToArray(),
                              gestantes.ToArray(),
                              filas,
                              atendidos);

        Imprimir(atendidos, 0);
    }
}
