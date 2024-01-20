using Microsoft.EntityFrameworkCore;
using PessoaFisica.Models;
using System.Collections.Generic;

namespace PessoaFisica.Data
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {
        }


        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }


    }
}
