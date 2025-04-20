using System;
using System.Collections.Generic;

class ex1
{
    static void LerNumeros(List<string> operacoes, int pos)
    {
        if (pos >= operacoes.Count)
            return;

        operacoes[pos] = Console.ReadLine();
        LerNumeros(operacoes, pos + 1);
    }

    static int VerificarExpressao(string expressao, int index, char[] pilha, int topo)
    {
        if (index == expressao.Length)
        {
            if (topo == 0)
                Console.WriteLine("Expressão válida");
            else
                Console.WriteLine("Expressão inválida");

            return 0;
        }

        char atual = expressao[index];

        if (atual == '(' || atual == '[' || atual == '{')
        {
            pilha[topo] = atual;
            return VerificarExpressao(expressao, index + 1, pilha, topo + 1);
        }

        if (atual == ')' || atual == ']' || atual == '}')
        {
            if (topo == 0)
            {
                Console.WriteLine("Expressão inválida");
                return 0;
            }

            char ultimo = pilha[topo - 1];

            if ((atual == ')' && ultimo != '(') ||
                (atual == ']' && ultimo != '[') ||
                (atual == '}' && ultimo != '{'))
            {
                Console.WriteLine("Expressão inválida");
                return 0;
            }

            return VerificarExpressao(expressao, index + 1, pilha, topo - 1);
        }

        return VerificarExpressao(expressao, index + 1, pilha, topo);
    }

    static void VerificarAgrupamentos(List<string> operacoes, int pos)
    {
        if (pos >= operacoes.Count)
            return;

        string expressao = operacoes[pos];
        char[] pilha = new char[expressao.Length];

        VerificarExpressao(expressao, 0, pilha, 0);

        VerificarAgrupamentos(operacoes, pos + 1);
    }

    private static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        List<string> operacoes = new List<string>(new string[n]);

        LerNumeros(operacoes, 0);
        VerificarAgrupamentos(operacoes, 0);
    }
}
