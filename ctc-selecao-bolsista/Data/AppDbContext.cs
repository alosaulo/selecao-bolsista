using ctc_selecao_bolsista.Data.Entity;
using Microsoft.EntityFrameworkCore;

namespace ctc_selecao_bolsista.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }

        public DbSet<Aluno> Alunos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Aluno>()
                .HasKey(a=> a.alunoId);

            modelBuilder.Entity<Aluno>()
                .Property(a => a.alunoId)
                .ValueGeneratedOnAdd();

        }

    }
}
