using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pessoaFisicaJuridica.Models
{
    public class Menu
    {
        public void menu()
        {
            int opcao = 0;
            string opcaoTipoPessoa; 
            bool exibirMenu = true;

            while(exibirMenu)
            {
                Console.Clear();
                Console.WriteLine("Escolha uma das opções abaixo:");
                Console.WriteLine("1 - Cadastrar");
                Console.WriteLine("2 - Lista de usuários");
                Console.WriteLine("3 - Lista de Fornecedores");
                Console.WriteLine("4 - Sair");

                opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("f - Para pessoa fisica ");
                        Console.WriteLine("j - Para pessoa fisica ");
                        opcaoTipoPessoa  = Console.ReadLine();
                        if(opcaoTipoPessoa == "f")
                        {
                            CadastroPessoaFisica cadastroUsuario = new CadastroPessoaFisica();
                            cadastroUsuario.usuario();
                        }
                        break;
                    case 2:
                        Console.WriteLine("");
                        break;
                    case 3:
                        Console.WriteLine("");
                        break;
                    case 4:
                        Console.WriteLine("Sair");
                        Environment.Exit(0);//encerra o programa, não executa mais nada
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
            }

            Console.WriteLine("Você encerrou o programa.");

            
        }
    }
}