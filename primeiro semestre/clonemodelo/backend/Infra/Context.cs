using Microsoft.EntityFrameworkCore;
using projeto_gamer_tarde.Models;

namespace projeto_gamer_tarde.Infra
{
    public class Context : DbContext
    {
        public Context()
        {            
        }

        public Context(DbContextOptions<Context> options) : base(options)
        {            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source = note03-s15; User = sa; Pwd= Senai@134; initial catalog = gamerTarde; TrustServerCertificate = true ");
            }
        }

        public DbSet<Jogador> Jogador {get;set;} 
        public DbSet<Equipe> Equipe {get;set;}
    }
}