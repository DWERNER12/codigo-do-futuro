using System.Collections;

namespace basico;

class Program
{

    static void Main(string[] args)
    {
        /*
        Console.WriteLine("Digite um nome?");
        var nome = Console.ReadLine();

        
        formas de concatenar 
        Console.WriteLine($"Você digitou: {nome}");
        Console.WriteLine("Você digitou:" + nome);
        Console.WriteLine(String.Concat("Você digitou:", nome));
        */

        /*
        condicional  
        if(nome == "David")
        {
            Console.WriteLine($"Opa e ai David");
        }
        else
        {
            Console.WriteLine($"Você digitou o nome: {nome}");
        }
        
        var opcao = Convert.ToInt16(Console.ReadLine());
        switch (opcao)
        {
            case 1:
                Console.WriteLine("Você digitou a opção 1");
                break;
            case 2:
                Console.WriteLine("Você digitou a opção 2");
                break;
            default:
                Console.WriteLine("Opção padrão");
                break;
        }
       

        int i = 0;
        do
        {
            Console.WriteLine(i);
            i++;
        }
        while(i<100);
        
        int i = 0;
        while(i<100);
        {
            Console.WriteLine(i);
            i++;
        }
        
        for(var i = 0; i<100; i++)
        {
            if(i>10) break;
            
            if(i > 89 && i <100) continue;
            Console.WriteLine(i);
        }
        

        string[] nomes = new string[4];
        nomes[0] = "David";
        nomes[1] = "Gabriela";
        nomes[2] = "Mel";
        nomes[3] = "Pandora";

        string[] nomes = new string[]{"David", "Gabriela", "Mel", "Pandora"};
        
        foreach(var nome in nomes)
        {
            Console.WriteLine(nome);
        }
        */

        //List<string> nomes = new List<string>(){"David", "Gabriela", "Mel", "Pandora"};
        ArrayList nomes = new ArrayList();
        var novoNome = Console.ReadLine();
        nomes.Add(novoNome);

        foreach(var nomev in nomes)
        {
            Console.WriteLine(nomev);
        }
        
        
        

    }

}

