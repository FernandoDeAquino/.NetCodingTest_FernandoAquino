using Icatu.ListaLeitura.Modelos;
using Microsoft.EntityFrameworkCore;

namespace Icatu.ListaLeitura.Persistencia
{
    public class LeituraContext : DbContext
    {
        public DbSet<Funcionario> Funcionario { get; set; }

        public LeituraContext(DbContextOptions<LeituraContext> options) 
            : base(options)
        {
            //irá criar o banco e a estrutura de tabelas necessárias
            this.Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration<Funcionario>(new FuncConfiguration());
        }
    }
}
