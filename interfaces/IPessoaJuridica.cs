using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace back_end.interfaces
{
    public interface IPessoaJuridica
    {
        bool Validarcnpj (string cnpj);
    }
}