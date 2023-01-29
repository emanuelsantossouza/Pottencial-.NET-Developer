using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ModuloAPI.Entities;


namespace ModuloAPI.Context
{
    public class AgendaContext : DbContext /*Ela esta herdando as funções do EntityFrameWork*/
    {
        public AgendaContext(DbContextOptions<AgendaContext> options) : base(options){ /*O contexto server para receber a conexão com o banco*/

        }

        public DbSet<Contato> Contatos { get; set; } /*O DbSet server criar uma tabela com a migration*/
    }
}