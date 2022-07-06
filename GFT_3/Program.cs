
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using GFT_3.Entities;
using GFT_3.Entities.Enuns;

namespace GFT_3
 {
        class Program
        {
                
                public static void Main(string[] args)
                {
                   
                        Exception exception = null;

                        do
                        {
                            try
                            {
                                Console.WriteLine("Entre no departamento: ");
                                string DepartamentoNome = Console.ReadLine();
                                Console.WriteLine("Nome: ");
                                string nome = Console.ReadLine();
                                Console.WriteLine("Nivel(Junior / Pleno / Senior)");
                                ExperienciaNivel nivel = Enum.Parse<ExperienciaNivel>(Console.ReadLine());
                                Console.WriteLine("Salário Base: ");
                                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                                Departamento departamento = new Departamento(nome);
                                Funcionarios trabalhador = new Funcionarios(nome, nivel, salario, departamento);
                                
                                Console.WriteLine("Quantos contratos para esse trabalhador? ");
                                int n = int.Parse(Console.ReadLine());

                                for (int i = 0; i < n; i++)
                                {
                                    Console.WriteLine("Entre #" + i + " data do contrato: ");
                                    Console.Write("Data(DD/MM/YYYY)");
                                    DateTime contratoData = DateTime.Parse(Console.ReadLine());
                                    Console.Write("Valor por hora: ");
                                    double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                                    Console.Write("Duração(horas): ");
                                    int horas = int.Parse(Console.ReadLine());
                                    ContratoHora contrato = new ContratoHora(contratoData,valor,horas);
                                    trabalhador.AdicionarContrato(contrato);
                                }

                                Console.Write("Entre com mês e ano para calcular o inicio(MM/YYYY)");
                                string data = Console.ReadLine();
                                int mes = int.Parse(data.Substring(0,2));
                                int ano = int.Parse(data.Substring(3));
                                Console.WriteLine(trabalhador);
                                Console.Write("Inicio de " + data + ": R$ " + trabalhador.Inicio(ano,mes).ToString("F2", CultureInfo.InvariantCulture) + "\n");

                            }
                            catch (ArgumentException e)
                            {
                                exception = e;
                                Console.WriteLine("Opção inválida: " + e.Message);
                                Console.WriteLine();
                                Console.WriteLine("Vamos começar novamente");
                            }
                            catch(FormatException e)
                            {
                                exception = e;
                                Console.WriteLine("Erro de Formato " + e.Message);
                                Console.WriteLine();
                                Console.WriteLine("Vamos começar novamente");
                            }
                        } while (exception != null);

                        Console.ReadKey();
                    
                } 

         }   
}
 