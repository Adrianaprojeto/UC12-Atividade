using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using back_end.interfaces;

namespace back_end.classes
{
    public class PessoaJuridica: Pessoa, IPessoaJuridica
        {
        public string? cnpj {get;set;}

        public string? razaoSocial {get;set;}

        public override float CalcularImposto(float rendimento)
        {
           if (rendimento <= 3000)
           {
             return rendimento * 0.03f; //3%
           }
           else if (rendimento > 3000 && rendimento <= 6000)
           {
            return rendimento * 0.05f; //5%
           }
           
           else if (rendimento > 3000 && rendimento <= 6000)
            
           {
            return rendimento * 0.07f; //7%
             
           }
            
            else  
           {
             return rendimento  * 0.09f; //9%
  
           }
            
        }




        public bool Validarcnpj(string cnpj)
        //xxxxxxxx0001xx - 14
        //xx.xxx.xxx/0001-xx  - 18


        {
           bool retornoCnpjvalido = Regex.IsMatch(cnpj,@"^(\d{14})|(\d{2}.\d{3}.\d{3}/d{4}-\{2})$");

           //a linha abaixo faz o mesmo if (retornoCnpjValido == true )
          if (retornoCnpjvalido)
          {
            string substringCnpj14 = cnpj.Substring( 8,4);

            if (substringCnpj14 == "0001")
            {
              return true;
            }

          }
             
             string substringCnpj18 = cnpj.Substring(11,4);

             if (substringCnpj18 == "0001")
             {
                
               return true;

             }

             return false;


        }
    }
}