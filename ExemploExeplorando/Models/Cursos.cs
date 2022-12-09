using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExeplorando.Models
{
    public class Cursos
    {
        public string Nome { get; set; }
        public List<Pessoa> Alunos { get; set; }

        public void AdicionarAluno(Pessoa aluno) //Add um aluno
        {
            Alunos.Add(aluno);
        }

        public int obterAlunosMatriculados()
        {
            int quantiade = Alunos.Count; //Count é usado para contar o toda de alunos
            return quantiade;             //Asimm retornado o toda da lista
            
        }

        public bool RemoverAluno(Pessoa aluno) 
        {
            return Alunos.Remove(aluno); // Remove tem um retorno em bool, 
        }                                // true ou false, então podemos usar diretamente esse retorno  


        public void ListaAluno()
        {
            
            Console.WriteLine($"Alunos do curso de: {Nome}");

            for (int count = 0; count < Alunos.Count; count++)
            {
                string texto = $"N° {count + 1} - {Alunos[count].NomeCompleto}"; // Fazer count mais um modificando o count e começando do 1 e não do zero
                Console.WriteLine(texto);
            }
            // foreach(Pessoa aluno in Alunos)
            // {
            //     Console.WriteLine(aluno.NomeCompleto);
            // }
        }

      
    }
}