

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using GFT_4.Classes;

namespace GFT_4
{
        class Program
        {
            static async Task Main(string[] args)
            {
                DateTime dtInicio = DateTime.Now;

                Console.WriteLine(" Informe o valor maximo a ser analisado");
                var linha = Console.ReadLine();

                try
                {
                    var valor = !string.IsNullOrEmpty(linha) ? Convert.ToUInt64(linha) : long.MaxValue;
                    long min = 3;
                    long max = (long)valor;
                    List<NumerosPrimos> retorno = await CalcularPrimo(min,max);
                    ImprimePrimos(retorno,min,max);
                }
                catch (FormatException ex)
                {
                    
                    Console.WriteLine("Formato inválido: " + ex.Message);
                }

                DateTime dtFim = DateTime.Now;
                TimeSpan tempo_Execucao = dtFim.Subtract(dtInicio);
                Console.WriteLine($"Iniciado em {dtInicio}\nfinalizado em {dtFim} \nExecutado em {tempo_Execucao}");

                Console.ReadKey();
            }

            static async Task<List<NumerosPrimos>> CalcularPrimo(long inicio, long fim)
            {
                var tasks = 
                    Task.Factory.StartNew(async () =>
                    {
                        List<NumerosPrimos> primos = new List<NumerosPrimos>();

                        primos.Add( new NumerosPrimos{ Numero = 1, QuantidadeDeDivisores = 1, EPrimo = false, tempoCalculo = DateTime.Now.Subtract(DateTime.Now)});
                        primos.Add( new NumerosPrimos{ Numero = 3, QuantidadeDeDivisores = 2, EPrimo = true, tempoCalculo = DateTime.Now.Subtract(DateTime.Now)});
                        primos.Add( new NumerosPrimos{ Numero = 2, QuantidadeDeDivisores = 2, EPrimo = true, tempoCalculo = DateTime.Now.Subtract(DateTime.Now)});

                        Parallel.For(inicio,fim, new ParallelOptions{MaxDegreeOfParallelism = 4}, async Index =>{
                            NumerosPrimos numeros = new NumerosPrimos();
                            DateTime dtInicio = DateTime.Now;
                            numeros.Numero = Index;
                            numeros.QuantidadeDeDivisores = await Divisores(Index,primos);
                            numeros.EPrimo = numeros.QuantidadeDeDivisores > 2 ? false : true;
                            DateTime DtFim = DateTime.Now;
                            numeros.tempoCalculo = DtFim.Subtract(dtInicio);

                            primos.Add(numeros);
                        });
                        return primos;
                    });

                    return await await tasks;

            }

            

            static async Task<int> Divisores(long num,List<NumerosPrimos> primos)
            {
                int divisores = 0;
                long aux = num;
                if (aux > 3)
                {
                    var arrayPrimos = primos.AsParallel().Where(w => w.EPrimo).Select(s =>s.Numero).OrderBy(o => o).ToList();
                    arrayPrimos.Add(num);
                    arrayPrimos.Add(1);

                    Parallel.ForEach(arrayPrimos.OrderBy(o => o), new ParallelOptions {MaxDegreeOfParallelism = 4}, (item, loopState) =>
                    {
                        if (num % 2 == 0)
                        {
                            divisores += 3;
                            loopState.Stop();

                        }
                        if (num % item == 0)
                        {
                            divisores ++;
                        }
                        if (divisores >= 3)
                        {
                            loopState.Stop();
                        }
                    });
                }


                return divisores;
            }

            static void ImprimePrimos(List<NumerosPrimos> Imprime,long inicio, long max)
            {
                inicio = 2;
                Console.WriteLine($"Existem {Imprime.AsParallel().Where(w => w.EPrimo).Count()} números primos entre {inicio} e {max}");

                var quantidade = Imprime.AsParallel().Where(w => w.EPrimo).OrderBy(o => o.Numero);
                int indice = 0;

                Dictionary<int, string> matriz = new Dictionary<int, string>();
                var qtde = quantidade.Count();


                int raiz = (int)Math.Sqrt(qtde) + 1;

                string[] aux = new string[raiz];

                int i = 0;
                foreach (var item in quantidade)
                {
                    aux[i] = item.Numero.ToString();
                    i++;

                    if (i == aux.Length)
                    {
                        string insert = string.Empty;

                        string ta = max.ToString();
                        for (int X = 0; X < aux.Length; X++)
                        {
                            insert = (X != 0 ? insert + " | " : "") + aux[X].Trim().PadLeft(ta.Length, ' ');

                        }
                        matriz.Add(indice, insert);
                        i = 0;
                        indice++;


                    }
                }

                StreamWriter sw = new StreamWriter(@"C:\projetos\c#\-GFT-START-5-2022-CSHARP-Douglas_Aquino_Soares\GFT_4\Primos.txt");
                foreach (var item in matriz.OrderBy(o => o.Key))
                {
                    sw.WriteLine(item.Value);
                    Console.WriteLine(
                                    item.Value
                                );
                    sw.Flush();
                }
                sw.Flush();
                sw.Dispose();
                sw.Close();

            }

            public static string[][] MontaMatriz(Dictionary<int, string> matriz)
            {
                var qtde = matriz.Count();
                int raiz = (int)Math.Sqrt(qtde);

                string[][] aux = new string[raiz][];

                return aux;
            }
        }
        
}