using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Payments.Models
{
    public class PagamentoBoleto : Pagamento
    {
        public int NumeroBoleto { get; set; }

        public override void Pagar()
        {
            Console.WriteLine("pagando via boleto");
        }
    }
}