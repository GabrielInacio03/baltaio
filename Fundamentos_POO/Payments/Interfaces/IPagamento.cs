using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Payments.Interfaces
{
    public interface IPagamento
    {
        public void VerificaPagamento(int id);
    }
}