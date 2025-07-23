using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Payments.Models
{
    public class PagamentoCartaoDeCredito : Pagamento
    {
        public int CartaoNumero { get; set; }

        public override void Pagar()
        {
            //base.Pagar();
            Console.WriteLine("Pagando via cartão de credito");
        }
    }
}