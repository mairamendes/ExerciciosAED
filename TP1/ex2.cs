using System;

class ex2
{
    private static void Main()
    {
        int t = int.Parse(Console.ReadLine()); // número de casos de teste
        for (int i = 0; i < t; i++)
        {
            int contador = 0; // reinicia para cada teste

            string[] ab = Console.ReadLine().Split(" ");
            string a = ab[0];
            string b = ab[1];
            char[] letrasDeA = a.ToCharArray(); //quebra a string em array de caracteres 
            char[] letrasDeB = b.ToCharArray();//quebra a string em array de caracteres

            if (a.Length != b.Length)
            {
                return;
            }
            else
            {
                for (int j = 0; j < letrasDeA.Length; j++) // loop sobre cada letra
                {
                    if (letrasDeA[j] != letrasDeB[j])
                    {
                        while (letrasDeA[j] != letrasDeB[j])
                        {

                            if (letrasDeA[j] == 'z')
                            {
                                letrasDeA[j] = 'a';
                            }
                            else
                            {
                                letrasDeA[j]++; //caracteres reconhecem o alfabeto, então iteram para a próxima letra 
                            }
                            contador++; // conta quantidade de operações

                            if (letrasDeA[j] == letrasDeB[j])
                                break;

                        }
                    }
                }
            }
            Console.WriteLine($"{contador}");
        }
    }
}