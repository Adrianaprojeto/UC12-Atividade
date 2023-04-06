using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace back_end.classes
{
    public abstract class Pessoa
    {
       public string? nome {get; set;}

       public float rendimento {get; set;}

       public string? endereco {get; set; }

       public abstract float CalcularImposto (float rendimento);
    }
}