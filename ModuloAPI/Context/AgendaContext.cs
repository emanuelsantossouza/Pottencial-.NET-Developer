using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ModuloAPI.Context
{
    public class AgendaContext : DbContext /*Ela esta herdando as funções do EntityFrameWork*/
    {
        public AgendaContext(DbContextOptinos<AgendaContext> options) : base(options){

        }

        public DbSet<Contato> Contatos { get; set; }
    }
}