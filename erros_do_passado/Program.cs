


using System;

namespace MATRIZES
{
    class Program
    {
            public static void Main(string[] args)
            {
                int l,c;

                Console.WriteLine("Quantas Linhas na matriz gostaria de incluir? ");
                l = int.Parse(Console.ReadLine());
                Console.WriteLine("Quantas Colunas na matriz gostaria de incluir? ");
                c = int.Parse(Console.ReadLine());

                int[,] mat = new int[l,c];

                for (int i = 0; i < l; i++)
                {
                    Console.WriteLine("Inserir o {0} valores para linha {1}: ", c, i + 1);
                    string[] val = Console.ReadLine().Split(' ');
                    for (int j = 0; j < c; j++)
                    {
                        mat[i,j] = int.Parse(val[j]);
                    }
                    
                    

                }

                    Console.WriteLine();

                    int request = 0;
                    Console.WriteLine("Qual número devo procurar? ");
                    request = int.Parse(Console.ReadLine());

                    for (int i = 0; i < l; i++)
                    {
                        for (int j = 0; j < c; j++)
                        {
                            if(request == mat[i,j])
                            {
                                Console.WriteLine("Posição({0},{1})", i, j);
                                if (j - l >= 0)
                                {
                                    Console.WriteLine("Esquerda: " + mat[i, (j - l)]);
                                }
                                if (i - l >= 0)
                                {
                                    Console.WriteLine("Acima: " + mat[ (i - l), j]);
                                }
                                if (j + l < c)
                                {
                                    Console.WriteLine("Direita: " + mat[i, (j + l )]);
                                }
                                if (i + l < l)
                                {
                                    Console.WriteLine("Abaixo: " + mat[ (i + l), j]);
                                }
    
                            }                   
                        }

                    }
            }

    }
}