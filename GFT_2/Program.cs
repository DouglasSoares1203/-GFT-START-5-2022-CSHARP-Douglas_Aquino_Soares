using System;
using GFT_2.Classes;

internal class Program
{
    private static void Main(string[] args)
    {
        
        Cheques c = new Cheques();
        Promissorias p = new Promissorias();
        TitulosDoGoverno t = new TitulosDoGoverno();

        Console.WriteLine("Sua promissoria:" + c.Recebiveis);
        Console.WriteLine("Escolha quantos dias deseja receber esse Cheque:");
        c.TipoRecebivel = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Escolha quantos dias deseja receber essa Promissoria:");
        p.TipoRecebivel = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Escolha quantos dias deseja receber esse Titulo do Governo:");
        t.TipoRecebivel = Convert.ToInt32(Console.ReadLine());
        
        c.calcularValorRecebivel();
        p.calcularValorRecebivel();
        t.calcularValorRecebivel();
        

    }
}