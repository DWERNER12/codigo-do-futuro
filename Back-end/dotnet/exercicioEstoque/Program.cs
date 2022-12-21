using System.Collections;

namespace exercicioEstoque;

class Program
{

    public class Produto
    {
        public int Id {get;set;}
        public string Name {get;set;}
        public int Quantidade{get; set;}
        public Produto(int id ,string name, int quantidade)
        {
            this.Id = id;
            this.Name = name;
            this.Quantidade = quantidade;
        }
    }
    static void Main()
    {
        //List<string[]> produtos = new List<string[]>(){};
        ArrayList produto = new ArrayList();
        
        Console.WriteLine("Sejá Bem Vindo(a)\n informe seu nome?");
        var nome = Console.ReadLine(); 
        
        do
        { 
            Console.WriteLine($"Olá {nome}\n Escolha uma das opções abaixo?");
            Console.WriteLine("1 - Cadastrar produto");
            Console.WriteLine("2 - Listar produtos cadastrados");
            Console.WriteLine("3 - Quantidade total de itens no estoque");
            Console.WriteLine("4 - Sair");
            var opcaoMenu = Convert.ToInt16(Console.ReadLine());           
        
            switch(opcaoMenu)
                {
                    case 1:                        
                        Console.WriteLine("Informe o nome do Produto:");
                        var novoProduto= Console.ReadLine();
                        produto.Add(novoProduto);
                        
                    break;

                    default:

                    break;
                }
        }while(true);
        {
                        
        }
       
    }

}
    
   


