using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Payments.Interfaces
{
    public interface IPessoa
    {
        void Salvar();
        void Editar(int id);
    }
}