
namespace GFT1
{

        class Program
        {
            static void Main(string[] args)
            {
                        int[,] n=new int[4,4];
            

                        n[0,0]= 1;
                        n[0,1]= -1;
                        n[0,2]= 0;
                        n[0,3]= 1;
                        
                        n[1,0]=0;
                        n[1,1]=4;
                        n[1,2]=1;
                        n[1,3]=4;
                        
                        n[2,0]=2;
                        n[2,1]=3;
                        n[2,2]=2;
                        n[2,3]=4;
                        
                        n[3,0]=3;
                        n[3,1]=2;
                        n[3,2]=4;
                        n[3,3]=2;

                        Console.WriteLine("O 4 da linha 1 coluna 1 está a direita: " + n[1,2]);
                        Console.WriteLine("O 4 da linha 1 coluna 1 está a acima: " + n[0,1]);
                        Console.WriteLine("O 4 da linha 1 coluna 1 está a esquerda: " + n[1,0]);
                        Console.WriteLine("O 4 da linha 1 coluna 1 está a abaixo: " + n[2,1]);

            }
}       }