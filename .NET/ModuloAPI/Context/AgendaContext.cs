using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ModuloAPI.Entities;//Pasta Entities

namespace ModuloAPI.Context
{
    public class AgendaContext : DbContext
    {
        public AgendaContext(DbContextOptions<AgendaContext> options) : base(options)
        //Aqui vamos receber a conexão com o banco e vamos passar para o 'base', que vai gerenciar a conexão com o banco
        {
            //Aqui não pecisa escrever nada nesse construtor
            //Aqui vai receber configuração de BD
        }

        public DbSet<Contato> Contatos { get; set; }
        //Vai representar uma tabela através do DbSet
    }
}