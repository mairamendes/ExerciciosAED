using System;
using System.Collections.Generic;
public class Comandos
{
    public static void Fila(Queue<Producoes> fila, List<Producoes> lista, string[] comando)
    {
        if (comando[0] == "queue")
        {
            if (comando[1].Length == 4)
            {
                int ano = int.Parse(comando[1]);
                foreach (Producoes producao in lista)
                {
                    if (producao.release_year == ano)
                        fila.Enqueue(producao);
                }
            }
            else if (comando[1] == "TV_Show")
            {
                foreach (Producoes producao in lista)
                {
                    if (producao.type == "TV_Show")
                        fila.Enqueue(producao);
                }
            }
            else if (comando[1] == "Movie")
            {
                foreach (Producoes producao in lista)
                {
                    if (producao.type == "Movie")
                        fila.Enqueue(producao);
                }
            }
        }
        else if (comando[0] == "dequeue")
        {
            if (comando[1] == "all")
            {
                while (fila.Count > 0)
                {
                    Console.WriteLine(fila.Dequeue().FormatarEntrada());
                }
            }
            else
            {
                int num = int.Parse(comando[1]);
                for (int i = 0; i < num; i++)
                    Console.WriteLine(fila.Dequeue().FormatarEntrada());
            }
        }
    }

    public static void Pilha(Stack<Producoes> pilha, List<Producoes> lista, string[] comando)
    {
        if (comando[0] == "push")
        {
            if (comando[1].Length == 4)
            {
                int ano = int.Parse(comando[1]);
                foreach (Producoes producao in lista)
                {
                    if (producao.release_year == ano)
                    {
                        pilha.Push(producao);
                    }
                }
            }
            else if (comando[1] == "TV_Show")
            {
                foreach (Producoes producao in lista)
                {
                    if (producao.type == "TV_Show")
                    {
                        pilha.Push(producao);
                    }
                }
            }
            else if (comando[1] == "Movie")
            {
                foreach (Producoes producao in lista)
                {
                    if (producao.type == "Movie")
                    {
                        pilha.Push(producao);
                    }
                }
            }
        }
        else if (comando[0] == "pop")
        {
            if (comando[1] == "all")
            {
                while (pilha.Count > 0)
                {
                    Console.WriteLine(pilha.Pop().FormatarEntrada());
                }
            }
            else
            {
                int num = int.Parse(comando[1]);
                for (int i = 0; i < num; i++)
                    Console.WriteLine(pilha.Pop().FormatarEntrada());
            }
        }
    }

}
public class Producoes
{
    public string show_id;
    public string type;
    public string title;
    public string director;
    public string cast;
    public string country;
    public string date_added;
    public int release_year;
    public string rating;
    public string duration;
    public string listed_in;
    public string description;

    public string FormatarEntrada()
    {
        return $"{show_id};{type};{title};{director};{cast};{country};{date_added};{release_year};{rating};{duration};{listed_in};{description}";
    }

}
class EssDisney
{
    public static void FormatarData(List<Producoes> lista)
    {
        for (int i = 0; i < lista.Count; i++)
        {
            string[] data = lista[i].date_added.Split(" "); //ex: September 22, 2021

            switch (data[0])
            {
                case "January": data[0] = "01"; break;
                case "February": data[0] = "02"; break;
                case "March": data[0] = "03"; break;
                case "April": data[0] = "04"; break;
                case "May": data[0] = "05"; break;
                case "June": data[0] = "06"; break;
                case "July": data[0] = "07"; break;
                case "August": data[0] = "08"; break;
                case "September": data[0] = "09"; break;
                case "October": data[0] = "10"; break;
                case "November": data[0] = "11"; break;
                case "December": data[0] = "12"; break;
                default:; break;
            }
            // Tratar virgula e 0 nos dias de 1 a 9
            data[1] = data[1].Replace(",", "");
            if (data[1] == "1" || data[1] == "2" || data[1] == "3" || data[1] == "4" || data[1] == "5" || data[1] == "6" || data[1] == "7" || data[1] == "8" || data[1] == "9")
                data[1] = $"0{data[1]}";

            string dataFormatada = $"{data[1]}/{data[0]}/{data[2]}";
            lista[i].date_added = dataFormatada;
        }
    }
    public static void VerificaComando(Queue<Producoes> fila, Stack<Producoes> pilha, List<Producoes> lista, string[] comando)
    {
        if (comando[0] == "push" || comando[0] == "pop")
            Comandos.Pilha(pilha, lista, comando);
        else if (comando[0] == "queue" || comando[0] == "dequeue")
            Comandos.Fila(fila, lista, comando);
    }
    private static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine()); // Quantidade de produções 

        List<Producoes> listaDeProducoes = new List<Producoes>();

        for (int i = 0; i < n; i++)
        {
            string[] dados = Console.ReadLine().Split(';'); //Preenche array separando valores por ";"

            Producoes p = new Producoes
            {
                show_id = dados[0],
                type = dados[1],
                title = dados[2],
                director = dados[3],
                cast = dados[4],
                country = dados[5],
                date_added = dados[6],
                release_year = int.Parse(dados[7]),
                rating = dados[8],
                duration = dados[9],
                listed_in = dados[10],
                description = dados[11]
            };

            listaDeProducoes.Add(p);
        }
        FormatarData(listaDeProducoes);

        int qtdComandos = int.Parse(Console.ReadLine()); // Lê a quantidade de comandos a serem executados

        Queue<Producoes> filaProducoes = new Queue<Producoes>();
        Stack<Producoes> pilhaProducoes = new Stack<Producoes>();

        for (int i = 0; i < qtdComandos; i++)
        {
            string[] c = Console.ReadLine().Split(' ');
            VerificaComando(filaProducoes, pilhaProducoes, listaDeProducoes, c);
        }
    }
}