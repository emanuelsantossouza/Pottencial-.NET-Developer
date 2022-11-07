using ExemploC.Models;


// LISTAS 

// List<string> listaString = new List<string>();

// listaString.Add("SP");
// listaString.Add("MG");
// listaString.Add("MS");

// Console.WriteLine($"Item na minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");

// listaString.Add("SC");

// Console.WriteLine($"Item na minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");

// listaString.Add("SC");

// Console.WriteLine($"Item na minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");

// listaString.Remove("SC");
// listaString.Remove("MG");

// Console.WriteLine($"Item na minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");

































// Console.WriteLine($"Percorrendo a lista com o FOR");
// for(int contador = 0;contador< listaString.Count; contador++)
// {
//    Console.WriteLine($"Posição Nº {contador} - {listaString[contador]}");
// }

// Console.WriteLine($"Percorrendo a lista com o FOREACH");
// int contadorForeach = 0;

// foreach(string item in listaString)
// {
//    Console.WriteLine($"Posição Nº {contadorForeach} - {item}");
//    contadorForeach++;
// }

































// // ARRAY COM FOR //
// int[] arrayInteiros = new int[3];

// arrayInteiros[0] = 2;
// arrayInteiros[1] = 467;
// arrayInteiros[2] = 76754;



// int[] arrayInteirosDobrados = new int[arrayInteiros.Length * 2];
// Array.Copy(arrayInteiros, arrayInteirosDobrados, arrayInteiros.Length)



// // Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2);


// Console.WriteLine("Com o For");
// for(int contador = 0; contador < arrayInteiros.Length; contador++){
//    Console.WriteLine($"Posição Nº {contador} - {arrayInteiros[contador]}");   
// }



























// // ARRAY COM FOREACH
// Console.WriteLine("Com o Foreach");
//  int contadorForeach = 0;
// foreach(int valor in arrayInteiros) {
//    Console.WriteLine($" Posição Nº {contadorForeach} - {valor}");
//    contadorForeach++;
// };

































// string opcao;
// bool exibir = true;

// while(exibir) {

      
//       Console.WriteLine("Digite a sua opção:");
//       Console.WriteLine("1 - Cadastro cliente");
//       Console.WriteLine("2 - Buscar cliente");
//       Console.WriteLine("3 - Apagar cliente");
//       Console.WriteLine("4 - Encerrar");

//       opcao = Console.ReadLine();

//       switch(opcao)
//       {
//          case "1":
//           Console.WriteLine("Cadastro de Cliente");
//           break;

//           case "2":
//           Console.WriteLine("Buscar cliente");
//           break;

//           case "3":
//           Console.WriteLine("Apagar cliente");
//           break;

//           case "4":
//           Console.WriteLine("Encerrar");
//           exibir =false;
//          //  Environment.Exit(0); Finaliza o programa
//           break;

//           default:
//                Console.WriteLine("Opção Invalida");
//                break;
//       }

//       Console.WriteLine("O programa se encerrou...");
// }























































// int soma = 0, numero= 0 ;

// do{
//     Console.WriteLine("Digite um número (0 para parar)");
//     numero = Convert.ToInt32(Console.ReadLine());

//    soma += numero;

// }while(numero != 0);

// Console.WriteLine($"Total de soma dos números digitados é: {soma}");
















































// //  Contador While   COM BREAK PARA QUEBRAR O LAÇO
// // int numero = 5;
// // int contador = 0;

// // while( numero > contador){
// //    contador++;
// //    Console.WriteLine($"{numero} X {contador} = {contador * numero}");

//       if (contador == 6) {
//          break;
//       }
// // }













         //CONTADOR FOR
// Console.WriteLine("Digite o número da tabuada");
// int numero = Convert.ToInt32(Console.ReadLine());

//  for(int contador = 0; numero >= contador; contador++){
//     Console.WriteLine($"{numero} x {contador} = {contador * numero}");
// };










// Calculadora calc = new Calculadora(); //Instanciando o metodo Calculadora

//Aqui Passamos os valores para ser realizado as contas, ja estruturadas pelo o metodo Calculadora
// calc.Somar(2111, 10); 
// calc.Subtrair(200, 500);
// calc.Multiplicar(100, 2);
// calc.Dividir(1000, 50);
// calc.Potencia(3,3);
// calc.Cos(50);
// calc.Seno(50);
// calc.Tangene(40);
// calc.RaizQuadrada(49);



// int numero = 10;

// Console.WriteLine(numero);

// Console.WriteLine("Incremente o 10");




// numero++;

// int numeroMenos = 10;

// Console.WriteLine(numeroMenos);

// Console.WriteLine("Incremente o 10");

// numeroMenos--;





















































      //END (&&)
//bool possuiPresencaMinima = true;
//double media = 7.5;

//if (possuiPresencaMinima && media >= 7) {
//   Console.WriteLine("Aprovado!");
//} else {
//   Console.WriteLine("Reprovado!");
//}



                  //Not (!)
/*
bool choveu = true;
bool estaTarde = true;

if (!choveu && !estaTarde) {
   Console.WriteLine("Vou pedalar");
} else {
   Console.WriteLine("Não vou pedalar");
}
*/



                  //OR(||)
/*
bool ehMaiorDeIdade = true;
bool possuiAutorizacaoDoResponsasvel = false; 

if (ehMaiorDeIdade || possuiAutorizacaoDoResponsasvel) {
   Console.WriteLine("Entrada liberada");
} else {
   Console.WriteLine("Entrada não liberada");
}
*/








               //Switch - Case - Break
/*
Console.WriteLine("Digite uma letra: ");
string ?letra = Console.ReadLine();


switch (letra) { 
   case "a":
   case "e":
   case "i":
   case "o":
   case "u":
         Console.WriteLine("Volgal");
         break;
   default:
         Console.WriteLine("não é uma volgal");
         break;
}   








               //If 
/*
if (volgal == letra ) {
Console.WriteLine($"A letra {letra} é uma folgal");
} else {
   Console.WriteLine($"A letra {letra} é uma consoante");
}
*/






               //If e variavel Boolean
/*
int quantidadeDEstoque = 140 ;
int usarioCompra = 120 ;
bool possivelVenda = quantidadeDEstoque > 0 && quantidadeDEstoque >= usarioCompra;

Console.WriteLine($"Quantidade em estoque: {quantidadeDEstoque}");
Console.WriteLine($"Quantidade compra: {usarioCompra}");
Console.WriteLine($"É possivel realizar a venda? {possivelVenda}");


if (usarioCompra > quantidadeDEstoque ) {
      Console.WriteLine("Não temos estoque sufuiciente");
} else {
   Console.WriteLine("Sua compra foi realizada com sucesso");
}
*/ 





               //Soma de interios
/*
string a = "15000";
 
string soma = a + 15;
   Console.WriteLine(soma);

int b = 11;

int.TryParse(a, out  b);
Console.WriteLine("Valor aceito com sucesso " + b);

*/






// Cast Implícito || hierarquia sempre o maior vai caber no menor
// int a = 5;
// long b = a;
//ou    converte do jeito Casting
//  long a = 5;
//  int b = Convert.ToInt32(a);
//  Console.WriteLine(a);

// Console.WriteLine(a);


// int inteiro = 5;
// string a = inteiro.ToString();
// Console.WriteLine(a);



//cast - Casting || Conversão de String = Int
// int a = Convert.ToInt32("5");
//int a = int.Parse("5");
// Console.WriteLine(a);




// int b = 10;

// int a = 20;

// int  c = a + b;

// //c = c + 5;

// c += 5;
// Console.Write(c);

// c *= 10;


// Console.Write(c);





// DateTime dataAtual = DateTime.Now.AddDays(5);
// Console.WriteLine(dataAtual.ToString("dd/MM/yyyy HH:mm"));


// string apresentacao = "Olá seja bem vindo";

// int quantidade = 1;
// quantidade = 10;

// double altura = 1.80;

// decimal preco = 1.800M;

// bool condicao = true;

// Console.WriteLine(apresentacao);
// Console.WriteLine("Valor da variavle altura:" + altura.ToString("0.00"));
// Console.WriteLine("Valor da variavel quantiade:" + quantidade );
// Console.WriteLine("Valor da variavel preço:" + preco );
// Console.WriteLine("Valor da variavel condição:" + condicao );

/*
Pessoa pessoa1 = new Pessoa();

pessoa1
.Nome = "Emanuel";
pessoa1.Idade = 17;
pessoa1.Peso = 120;
pessoa1.Aprasentar(); */