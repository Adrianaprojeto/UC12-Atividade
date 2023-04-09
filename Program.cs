
// See https://aka.ms/new-console-template for more information
//Console.Clear();

//Console.WriteLine("Hello, World!");

//Console.WriteLine("Hello, World!");

//Console.WriteLine("Hello, World!");

using back_end.classes;

 PessoaFisica NovaPF = new PessoaFisica();
 PessoaJuridica novaPj = new PessoaJuridica();
 Endereco novoEndPf = new Endereco();

 

 NovaPF.nome = "Adriana";
 NovaPF.cpf = "12345678975";
 NovaPF.rendimento = 7000.5f;
 DateTime temp = new DateTime(1979,01,01);

 //NovaPF.ValidarDataNasc(temp);

 //Console.WriteLine( $" Pessoa Fisica----------------");
 //float resultado = NovaPF.CalcularImposto(NovaPF.rendimento);
//Console.WriteLine(resultado);
//Console.WriteLine( $" Validade de Datas --------------------------");
//DateTime temp = new DateTime(2000,01,01);
//Console.WriteLine(NovaPF.ValidarDataNasc(temp));

//Console.WriteLine(NovaPF.ValidarDataNasc("2004/12/08"));

novoEndPf.logradouro = "Rua Niteroi";
novoEndPf.numero = 180;
novoEndPf.complemento = "Predio";
novoEndPf.endComercial = true;

NovaPF.endereco = novoEndPf;

Console.WriteLine(@$"
Nome: {NovaPF.endereco.logradouro}, Num: {NovaPF.endereco.numero}
Maior de Idade: {NovaPF.ValidarDataNasc(NovaPF.dataNasc)}

");





 //Console.WriteLine(NovaPF.nome);
 //Console.WriteLine(NovaPF.cpf);

//Interpolacao
 //Console.WriteLine( $" --------------------------");

 //Console.WriteLine( $" Bem Vindo {NovaPF.nome} Seu cpf  é :{NovaPF.cpf}");

 // Concatenacao

//Console.WriteLine( $" Bem Vindo " +NovaPF.nome+", Seu cpf  é" +NovaPF.cpf+"!!!!");

//Console.WriteLine ($"Pessoa Juridica============");
//PessoaJuridica novaPj  =  new PessoaJuridica();
//float impostoPagar = novaPj.CalcularImposto(12000.5f);

//Console.WriteLine(novaPj.CalcularImposto(12000.5f));
//Console.WriteLine($"R$ {impostoPagar:0.00}");
//Console.WriteLine($"R$ {impostoPagar.ToString("C")}");



 
