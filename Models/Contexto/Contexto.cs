using ListaTelefonica.Models.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Threading.Tasks;

namespace ListaTelefonica.Models.Contexto
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Telefones> Telefones { get; set; }
        public DbSet<Contato> Contato { get; set; }

        public DbSet<Grupo> Grupo { get; set; }

        

    }
}
