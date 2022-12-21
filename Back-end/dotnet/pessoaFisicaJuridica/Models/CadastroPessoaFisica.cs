using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pessoaFisicaJuridica.Models
{
    public class CadastroPessoaFisica
    {
        public void usuario()
        {
            PessoaFisica fisica = new PessoaFisica();
            Console.WriteLine("Informe o nome do cliente:");
            fisica.Nome = Console.ReadLine();
            Console.WriteLine("Informe o cpf:");
            fisica.Cpf = Convert.ToInt32(Console.ReadLine());
           
            
        }
    }
}