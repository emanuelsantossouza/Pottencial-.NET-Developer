﻿using ExemploExeplorando.Models;
using System.Globalization;
using Newtonsoft.Json;



















































// int a = 10;

// int b = a;

// Console.WriteLine($"Valor de A: {a}");
// Console.WriteLine($"Valor de B: {b}");





















// Pessoa p1 = new Pessoa(nome: "Emanuel", sobrenome: "Santos");

// Pessoa p2 = p1;
// p2.Nome = "Larry";

// Console.WriteLine($"NOME: {p1.NomeCompleto}");
// Console.WriteLine($"NOME: {p2.NomeCompleto}");




































// dynamic variavelDinamica = 4;
// Console.WriteLine($"Tipo da variável: {variavelDinamica.GetType()}, Valor: {variavelDinamica}");

// variavelDinamica = "Texto";
// Console.WriteLine($"Tipo da variável: {variavelDinamica.GetType()}, Valor: {variavelDinamica}");

// variavelDinamica = true;
// Console.WriteLine($"Tipo da variável: {variavelDinamica.GetType()}, Valor: {variavelDinamica}");














































// string contexto = File.ReadAllText("Arquivos/vendas.json");
// List<Venda1> listaVendas = JsonConvert.DeserializeObject<List<Venda1>>(contexto);

// var listaAnonimos = listaVendas.Select(x => new { x.Produto, x.Preco});

// foreach(var venda in listaAnonimos)
// {
//     Console.WriteLine($"Nome do Produto: {venda.Produto}, Valor do Produto: {venda.Preco}");
// }





































// var tipoAnonimo = new { Nome = "Emnuel", Sobrenome = "Santos Souza", Idade = 17, Altura = 1.75};

// Console.WriteLine("Nome: " + tipoAnonimo.Nome);
// Console.WriteLine("Sobrenome: " + tipoAnonimo.Sobrenome);
// Console.WriteLine("Idade: " + tipoAnonimo.Idade);
// Console.WriteLine("Altura: " + tipoAnonimo.Altura);



































// bool? desejaReceberEmail = false;

// if (desejaReceberEmail.HasValue && desejaReceberEmail.Value) // OU if (desejaReceberEmail != null && desejaReceberEmail.Value)
// {
//     Console.WriteLine("O usuário optou por receber e-mail.");
// }
// else 
// {
//     Console.WriteLine("O usuário não respondeu ou optou por não receber e-mail.");
// }
































// string contexto = File.ReadAllText("Arquivos/vendas.json");

// List<Venda1> listaVendas = JsonConvert.DeserializeObject<List<Venda1>>(contexto);

// foreach (Venda1 venda in listaVendas)
// {
//      Console.WriteLine($"Id: {venda.Id}, Produto: {venda.Produto}, Preço: {venda.Produto}, Data: {venda.HoradDVenda.ToString("dd/MM/yyyy HH:mm:ss")}, " +
//        $" {(venda.Desconto.HasValue ? $"Desconto de : {venda.Desconto}%" : "")}");
// }










































// DateTime dataAtual = DateTime.Now;
// List<Venda> listaVendas = new List<Venda>();
                                                                    
// Venda v1 = new Venda(1, "Materal de escritorio", 25.00M, dataAtual);
// Venda v2 = new Venda(2, "Linça de software", 100.00M, dataAtual);
// Venda v3 = new Venda(3, "Materal de casa", 357.00M, dataAtual);
// Venda v4 = new Venda(4, "Books de escritorio", 100.00M, dataAtual);
// Venda v5 = new Venda(5, "Comida de escritorio", 45.000M, dataAtual);

// listaVendas.Add(v1);
// listaVendas.Add(v2);
// listaVendas.Add(v3);
// listaVendas.Add(v4);
// listaVendas.Add(v5);

// string serializando = JsonConvert.SerializeObject(listaVendas, Formatting.Indented);


// File.WriteAllText("Arquivos/vendas.json", serializando);
// Console.WriteLine(serializando);











// string serializando = JsonConvert.SerializeObject(v1, Formatting.Indented);
















































// IF TERNÁRIO
// int numero = 20;
// bool ehPar = false;

// ehPar = numero % 2 == 0;
// Console.WriteLine($"O número {numero} é" + (ehPar ? "par": "ímpar"));






















// if(numero % 2 == 0)
// {
//     Console.WriteLine($"O numero é par {numero}");
// } else{
//     Console.WriteLine($"O numero é par {numero}");
// }



























// Pessoa p1 = new Pessoa("Emanuel", "Santos");

// (string nome, string sobrenome) = p1;

// Console.WriteLine($"{nome} {sobrenome}");

























// LeituraArquivo arquivo = new LeituraArquivo();

// var (sucesso, linhasArquivos, quantidadeLinhas) = arquivo.LerArquivo("Arquivos/arquivoLeitura.txt");

// if (sucesso)
// {    
//     Console.WriteLine("Quantidades de linhas do arquivo: " + quantidadeLinhas);
//     foreach(string linha in linhasArquivos)
//     {
//         Console.WriteLine(linha);
//     }
// }
// else
// {
//         Console.WriteLine("Não foi possível fazer a leitura do arquivo");
// }
     
        

    




















































// (int Id, string Nome, string Sobrenome, decimal Altura) tupla = (1, "Emanuel", "Santos Souza", 1.80M);

// // ValeuTuple<int, string, decimal> outroExemplo = (1, "Emanuel", "Santos Souza", 1.80M);
// // var outroExemploTuplaCreate = Tuple.Create(1, "Emanuel", "Santos Souza", 1.80M);


// // Console.WriteLine($"Id: {tupla.Id}");
// // Console.WriteLine($"Nome: {tupla.Nome}");
// // Console.WriteLine($"Sobrenome: {tupla.Sobrenome}");
// // Console.WriteLine($"Altura: {tupla.Altura}");























































// Dictionary<string, string> estados = new Dictionary<string, string>();

// estados.Add("SP", "São Paulo");
// estados.Add("RJ", "Rio de Janeiro");
// estados.Add("BH", "Bahia");
// estados.Add("MG", "Minas Genais");

// foreach(var sigla in estados){
//     Console.WriteLine($"Chave: {sigla.Key}, Valor: {sigla.Value}");
// }

// Console.WriteLine("________________________________________________________________________________________________________________________________");
// estados.Remove("MG");
// estados["SP"] = "São Paulo, Basil";

// foreach(var sigla in estados){
//     Console.WriteLine($"Chave: {sigla.Key}, Valor: {sigla.Value}");
// }

// string chave = "BH";

// if(estados.ContainsKey(chave)) {
//     Console.WriteLine($"Valor existente: {chave}");
// } else {
//     Console.WriteLine($"Valor não existente. é seguro adicionar a chave: {chave}");
// }

// try {
//     estados.Add("BH", "Bahia");
// }catch(Exception e) {
// Console.WriteLine("Chegou até aqui" + e.Message);
// }
































// Stack<int> pilha = new Stack<int>();

// pilha.Push(4);
// pilha.Push(6);
// pilha.Push(8);
// pilha.Push(10);

// foreach(int item in pilha){
//     Console.WriteLine(item);
// }


// Console.Write($"Removendo o elemento do topo {pilha.Pop()}");


// foreach(int item in pilha){
//     Console.WriteLine(item);
// }







































// Queue<int> fila = new Queue<int>();

// fila.Enqueue(2);
// fila.Enqueue(4);
// fila.Enqueue(6);
// fila.Enqueue(8);

// foreach(int item in fila)
// {
//     Console.WriteLine(item);
// }

// Console.WriteLine($"Removendo o elemento: {fila.Dequeue()} da fila ");

// foreach(int item in fila)
// {
//     Console.WriteLine($" Os elementos restantes: {item} ");
// }


































// new ExemploExcecao().Metdo1();









































// try { // try testa a string e ver se ela esta valida

// string[] linhas = File.ReadAllLines("Arquivos/arquivoLeitura.txt");

//     foreach (string linha in linhas)
//     {
//         Console.WriteLine(linha);
//     } 
// } catch(FileNotFoundException ex)
// {
//     Console.WriteLine($"Ocorreu uma erro, não foi possivel encontrar o arquivo desejado, certifique o nome dos arquivo e o caminho, excecão específica. {ex.Message}");
// } 
// catch(DirectoryNotFoundException ex)
// {
//     Console.WriteLine($"Ocorreu uma erro, não foi possivel encontrar o diretorio desejado, certifique o nome do diretorio e o caminho, excecão específica. {ex.Message}");
// } 
//  catch(Exception ex) // catch indentifica e trata o erro.
// {
//     Console.WriteLine($"Ocorreu uma exceção genérica. {ex.Message}");
// }
// finally{ // sempre sera enviado independente de erros ou não
//     Console.WriteLine("Chegou até aqui");
// } 

 
































// DateTime data = DateTime.Now;
// Console .WriteLine(data.ToString("dd/MM/yyyy HH:mm:ss"));
// Console .WriteLine(data.ToString("yyyy/MM/dd HH:mm"));
// Console .WriteLine(data.ToString("MM/YYYY HH:mm"));
// Console .WriteLine(data.ToString("dd/MM HH"));

























// decimal valorMonerario = 123.09M;

// Console.WriteLine(valorMonerario.ToString("C1"));




// double percemtagem = .3421;

// Console.WriteLine(percemtagem.ToString("P"));



// decimal cpf = 12312312301;
// Console.WriteLine(cpf.ToString("###-###-###-##"));





















// CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");

// decimal valorMonerario = 100382.40M;

// Console.WriteLine(valorMonerario.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));
// // Especificando a cultura. Bloqueado







// CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");
// // Formata A região assim mudando a formatação da moeda


// Decimal valorMonerario = 100382.40M;

// Console.WriteLine(valorMonerario);
// Console.WriteLine($"{valorMonerario:C}");// quando temos os : atras de um valor,
//                                          //  SIGNIFICA QUE QUEREMOS FORMATAR UM VALOR EM OUTRO





































// Pessoa p1 = new Pessoa("Emanuel", "Santos"); //estanciando um metodo 
//                                             // Utilizando Construt
// Pessoa p2 = new Pessoa("Karla", "Ferras Souza"); // estanciando um metodo
// Cursos cursosDeIngles = new Cursos(); //estanciando uma classe
// cursosDeIngles.Nome = "Inglês";
// cursosDeIngles.Alunos = new List<Pessoa>();


// cursosDeIngles.AdicionarAluno(p1);
// cursosDeIngles.AdicionarAluno(p2);
// cursosDeIngles.ListaAluno();
// cursosDeIngles.RemoverAluno(p2);
// cursosDeIngles.ListaAluno();











































// Pessoa p1 = new Pessoa();

// p1.Nome = "Emanuel";
// p1.Idade = 17;
// p1.Sobrenome = "Santos Souza";
// p1.Apesentar();