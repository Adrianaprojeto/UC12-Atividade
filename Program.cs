


using back_end.classes;

<<<<<<< HEAD
 
Utils.BarraCarregamento();

Console.Clear();

 string? opcao;

do
{
    Console.WriteLine(@$"

     ============================================
    |    Bem Vindo ao sistema de Cadastro       |
    |     de Pessoas Fisicas e juridicas        |
    =============================================
    |                                           |
    |        1 - Pessoa Fisica                  |
    |        2 - PessJuridica                   |
    |                                           |
    |        0 - Sair                           |
    =============================================
 ");


opcao = Console.ReadLine();
Thread.Sleep(1000);


switch (opcao)
{
    case "1":

    PessoaFisica NovaPF = new PessoaFisica();
    Endereco novoEndPf = new Endereco();
=======
 //PessoaFisica NovaPF = new PessoaFisica();
 PessoaJuridica novaPj = new PessoaJuridica();
 novaPj.cnpj = "21.137.998/0001-40";
 //Console.WriteLine(novaPj.Validarcnpj("21.137*998/0001-40"));

 Console.WriteLine(@$"
CNPJ: {novaPj.cnpj}
Valido:{novaPj.Validarcnpj(novaPj.cnpj)}
 
 ");




 //Endereco novoEndPf = new Endereco();
>>>>>>> 3248a2950a52dd7239e44afa5b74cdc6f420bd2f

 

 //NovaPF.nome = "Adriana";
 //NovaPF.cpf = "12345678975";
 //NovaPF.rendimento = 7000.5f;
 //DateTime temp = new DateTime(1979,01,01);

 NovaPF.ValidarDataNasc(temp);

 Console.WriteLine( $" Pessoa Fisica----------------");
 float resultado = NovaPF.CalcularImposto(NovaPF.rendimento);
Console.WriteLine(resultado);
Console.WriteLine( $" Validade de Datas --------------------------");
//DateTime temp = new DateTime(2000,01,01);
//Console.WriteLine(NovaPF.ValidarDataNasc(temp));

Console.WriteLine(NovaPF.ValidarDataNasc("2004/12/08"));

//novoEndPf.logradouro = "Rua Niteroi";
//novoEndPf.numero = 180;
//novoEndPf.complemento = "Predio";
//novoEndPf.endComercial = true;

//NovaPF.endereco = novoEndPf;

//Console.WriteLine(@$"
//Nome: {NovaPF.endereco.logradouro}, Num: {NovaPF.endereco.numero}
//Maior de Idade: {NovaPF.ValidarDataNasc(NovaPF.dataNasc)}

<<<<<<< HEAD
");
Console.WriteLine($"Para continuar, tecle Enter");
Console.ReadLine();
=======
//");
>>>>>>> 3248a2950a52dd7239e44afa5b74cdc6f420bd2f


        break;


    case "2":
    
    
    PessoaJuridica novaPj  =  new PessoaJuridica();
    Endereco novoEndPj = new Endereco();
    
 
    
    Console.WriteLine(novaPj.Validarcnpj("21.137*998/0001-40"));
    novaPj.cnpj = "21.137.998/0001-40";
    Console.WriteLine(@$"
    CNPJ: {novaPj.cnpj}
    Valido:{novaPj.Validarcnpj(novaPj.cnpj)}
 
 ");
  
Console.WriteLine ($"Pessoa Juridica============");

novoEndPj.logradouro = "Rua Paraiso";
novoEndPj.numero = 900;
novoEndPj.complemento = "Predio";
novoEndPj.endComercial = true;
novaPj.endereco = novoEndPj;


float impostoPagar = novaPj.CalcularImposto(12000.5f);

Console.WriteLine(novaPj.CalcularImposto(12000.5f));
Console.WriteLine($"R$ {impostoPagar:0.00}");
Console.WriteLine($"R$ {impostoPagar.ToString("C")}");
Console.WriteLine($"Para continuar, tecle Enter");
Console.ReadLine();

        break;   

    case "0":
            Console.WriteLine($"Obrigada por utilizar nosso sistema");
            Console.WriteLine($"Para continuar, tecle Enter");
            Console.ReadLine(); 
             
             


        break;     

    default:

             Console.WriteLine($"Opção inválida, digite um valor indicado");
             Console.WriteLine($"Para continuar, tecle Enter");
             Console.ReadLine();
             
    break;
}


} while (opcao!="0");

Utils.BarraCarregamento();




 
 


 
