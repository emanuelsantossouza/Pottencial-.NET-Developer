using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ModuloAPI.Controllers
{   
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : ControllerBase 
    {
        [HttpGet("ObterDataHoraAtual")]
        public IActionResult ObterDataHora()
        {
            var obj = new 
            {
                Data = DateTime.Now.ToLongDateString(),
                Hora = DateTime.Now.ToShortDateString()
            };

            return Ok(obj);
        }

        [HttpGet("Apresentar/{nome}")]
        public IActionResult Aprsentar(string nome)
        { 
            var mensagem = $"Olá {nome}, seja Bem-Vindo!!";
            return Ok(new { mensagem });
        }
    }
}