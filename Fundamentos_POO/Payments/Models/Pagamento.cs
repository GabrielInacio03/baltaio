using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Payments.Interfaces;

namespace Payments.Models
{
    public class Pagamento : IPagamento
    {
        //Propriedades
        //private, protected, internal e public
        
        public decimal Saldo { get; set; }
        public DateTime Vencimento { get; set; }
        private DateTime _dataPagamento;
        public DateTime DataPagamento
        {
            get { return _dataPagamento; }
            set { _dataPagamento = value; }
        }

        //construtores
        public Pagamento(){}
        public Pagamento(decimal saldo) 
        {
            this.Saldo = saldo;
   
        } 
        //Métodos
        public virtual void Pagar() { }
        public void Pagar(string numero, DateTime vencimento)
        {
            //Pagamento
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public void VerificaPagamento(int id)
        {
            throw new NotImplementedException();
        }
    }
}