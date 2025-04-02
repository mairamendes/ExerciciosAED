using System;

class ex3
{
    private static void Main()
    {
        string n = Console.ReadLine();
        string[] numerosN = n.Split(' '); //divide entrada por espaços
        string[] numerosInvertidos = new string[numerosN.Length]; 

        for (int i = 0; i < numerosN.Length; i++)
        {
            string numero = numerosN[i];
            string invertido = "";

            //verifica se o número é válido (não vazio, até 8 caracteres, não começa nem termina com 0)
            if (numero != "" && numero.Length <= 8 && numero[0] != '0' && numero[numero.Length - 1] != '0')
            {
                for (int j = 0; j < numero.Length; j++) 
                {
                    invertido += numero[numero.Length - 1 - j]; //inverte os caracteres
                }
                numerosInvertidos[i] = invertido;
            }
            else
            {
                numerosInvertidos[i] = numero; //mantém o original se não atender às condições
            }

            Console.WriteLine(numerosInvertidos[i]); //imprime o resultado
        }
    }
}