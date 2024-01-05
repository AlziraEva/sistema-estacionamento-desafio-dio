using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioFundamentos.Models
{
    public class ValidacoesPreco
    {
        public decimal preco;


        public void CapturarPreco(string precoEstacionamento)
        {
            decimal preco2 = 0;
            decimal.TryParse(precoEstacionamento, out preco2);


            if (preco2 > 0)
            {
                preco = preco2;

            }
            else
            {
                Console.WriteLine("Preço inválido");
            }

        }
    }
}