
using System;
using GFT_3.Classes;

namespace GFT_3
 {
        class Program
        {
                static TrabalhoRepositorio repositorio = new TrabalhoRepositorio();
                public static void Main(string[] args)
                {
                    string opcaoUsuario = ObterOpcaoUsuario();

                        while (opcaoUsuario.ToUpper() != "X")
                        {
                            switch (opcaoUsuario)
                            {
                                case "1":
                                    SetTrabalhador();
                                    break;
                                case "2":
                                    //SetSalarioPorHora();
                                    break;
                                case "3":
                                    //SetHorasTrabalhadas();
                                    break;
                                case "4":
                                    GetTrabalhador();
                                    break;
                                case "5":
                                    //GetSalarioPorHora();
                                    break;
                                case "6":
                                    //GetHorasTrabalhadas();
                                    break;
                                case "7":
                                    //GetSalarioTotal();
                                    break;
                                case "C":
                                    Console.Clear();
                                    break;

                                default:
                
                                throw new ArgumentOutOfRangeException();
                            }  

                            opcaoUsuario = ObterOpcaoUsuario(); 
                        }

                        Console.WriteLine("Obrigado por utilizar nossos serviços.");
			            Console.ReadLine();

                }

            private static string ObterOpcaoUsuario()
            {
                Console.WriteLine();
                Console.WriteLine("DIO Séries a seu dispor!!!");
                Console.WriteLine("Informe a opção desejada:");

                Console.WriteLine("1- Inserir Nomes");
                Console.WriteLine("2- Inserir  Salario por Hora");
                Console.WriteLine("3- Horas trabalhadas");
                Console.WriteLine("4- Ler Nomes");
                Console.WriteLine("5- Ler Salario por Hora");
                Console.WriteLine("6- Horas trabalhadas");
                Console.WriteLine("C- Limpar Tela");
                Console.WriteLine("X- Sair");
                Console.WriteLine();

                string opcaoUsuario = Console.ReadLine().ToUpper();
                Console.WriteLine();
                return opcaoUsuario;
            }
                public static void SetTrabalhador()
                {

                   
                        
                        Console.WriteLine("Inserir o Id do funcionário");
                        int entradaId = int.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o nome do Funcionário");
                        string entradaNome = Console.ReadLine();
                        System.Console.WriteLine("Salario por hora: ");
                        double entradaSalarioPorHora = double.Parse(Console.ReadLine());
                        System.Console.WriteLine("Horas trababalhadas: ");
                        DateTime entradaHorasTrablhadas = DateTime.Parse(Console.ReadLine());

                        Trabalhador novoTrabalhador = new Trabalhador(id: repositorio.ProximoId(),
                                                                    nome: entradaNome,
                                                                    salarioPorHora: entradaSalarioPorHora,
                                                                    horasTrabalhadas: entradaHorasTrablhadas);
                    repositorio.Insere(novoTrabalhador);
                      
                      novoTrabalhador.LimitedeTrabalhador();
                    
                }
                public static void GetTrabalhador()
                {
                    Console.WriteLine("Listar Nomes:");
                    var lista = repositorio.Lista();

                    if (lista.Count == 0)
                    {
                        System.Console.WriteLine("Nenhum funcionário cadastrado");
                        return;
                    }
                }

         }   
}
 