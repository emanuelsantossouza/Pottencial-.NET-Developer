using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ModuloAPI.Entities;
using ModuloAPI.Context;


namespace ModuloAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ContatoController : ControllerBase
    {   
        private readonly AgendaContext _context;

        public ContatoController(AgendaContext context) 
        {
            _context = context;
        }


        [HttpPost]
        public IActionResult Create(Contato contato)
        { 
            _context.Add(contato);
            _context.SaveChanges();
            return CreatedAtAction(nameof(ObterPorId), new { id = contato.Id}, contato);
        }

        [HttpGet("{id}")]
        public IActionResult ObterPorId(int id)
        { 
            var contato = _context.Contatos.Find(id);

            if(contato == null)
                return NotFound();


            return Ok(contato);
        }


        [HttpGet("ObterPorNome")]
        public IActionResult ObterPorNome(string nome)
        {
            var contatosNome = _context.Contatos.Where(x => x.Nome.Contains(nome));
            return Ok(contatosNome);
        }


        [HttpPut("{id}")]
        public IActionResult Atualizar(int id, Contato contato) /*Vai receber um id e um contato*/
        {
            var contatoBanco = _context.Contatos.Find(id); /*Buscando as Informações no Banco*/

            if (contatoBanco == null) /*Validação do ID*/
                return NotFound();

                        /*Atualizando as informações para o banco*/
            contatoBanco.Nome = contato.Nome;
            contatoBanco.Telefone = contato.Telefone;
            contatoBanco.Ativo = contato.Ativo;

            _context.Contatos.Update(contatoBanco); /*Para realizar o Update no canto banco */
            _context.SaveChanges();                 /*Para salvar as alterações na api*/

            return Ok(contatoBanco);
        }

        // [HttpPutch("{id}")]
        // public IActionResult AtualizarTelefone(int id, Contato contato)
        // { 
        //     var contatoNumero = _context.Contatos.Find(id);

        //     if (contatoNumero == null)
        //         return NotFound();

        //     contatoNumero.Telefone = contato.Telefone;

        //     _context.Contatos.Update(contatoNumero);
        //     _context.SaveChanges();

        //     return Ok(contatoNumero);
        // }


        [HttpDelete("id")]
        public IActionResult Deletar(int id)
        { 
            var contatoBanco = _context.Contatos.Find(id);

            if (contatoBanco == null)
                return NotFound();

            _context.Contatos.Remove(contatoBanco);
            _context.SaveChanges();
            return NoContent();
        }

       
    }
}