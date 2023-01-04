using ExemploExeplorando.Models;
using System.Globalization;


new ExemploExcecao().Metdo1();









































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