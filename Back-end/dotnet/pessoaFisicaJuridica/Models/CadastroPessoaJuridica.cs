using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pessoaFisicaJuridica.Models
{
    public class CadastroPessoaJuridica
    {
        public void fornecedor()
        {
            PessoaJuridica juridica = new PessoaJuridica();
            Console.WriteLine("Informe o nome do cliente:");
            juridica.Nome = Console.ReadLine();
            Console.WriteLine("Informe o cpf:");
            juridica.Cnpj = Convert.ToInt32(Console.ReadLine());
        }
    }
}