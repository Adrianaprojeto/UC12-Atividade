using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace back_end.interfaces
{
    public interface IPessoaFisica
    {
        bool ValidarDataNasc (DateTime dataNasc);
    }
}