
// See https://aka.ms/new-console-template for more information
//Console.Clear();

//Console.WriteLine("Hello, World!");

//Console.WriteLine("Hello, World!");

//Console.WriteLine("Hello, World!");

using back_end.classes;

 PessoaFisica NovaPF = new PessoaFisica();

 NovaPF.nome = "Adriano";
 NovaPF.cpf = "12345678975";
 NovaPF.rendimento = 7000.5f;
 float resultado = NovaPF.CalcularImposto(NovaPF.rendimento);
Console.WriteLine(resultado);



 //Console.WriteLine(NovaPF.nome);
 //Console.WriteLine(NovaPF.cpf);

//Interpolacao
 //Console.WriteLine( $" --------------------------");

 //Console.WriteLine( $" Bem Vindo {NovaPF.nome} Seu cpf  é :{NovaPF.cpf}");

 // Concatenacao

//Console.WriteLine( $" Bem Vindo " +NovaPF.nome+", Seu cpf  é" +NovaPF.cpf+"!!!!");

Console.WriteLine ($"Pessoa Juridica============");
PessoaJuridica novaPj  =  new PessoaJuridica();
float impostoPagar = novaPj.CalcularImposto(12000.5f);

Console.WriteLine(novaPj.CalcularImposto(12000.5f));
Console.WriteLine($"R$ {impostoPagar:0.00}");
Console.WriteLine($"R$ {impostoPagar.ToString("C")}");



 
