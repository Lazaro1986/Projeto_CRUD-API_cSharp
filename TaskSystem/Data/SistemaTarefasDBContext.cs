using Microsoft.EntityFrameworkCore;
using TaskSystem.Data.Map;
using TaskSystem.Models;

namespace TaskSystem.Data
{
    public class SistemaTarefasDBContext : DbContext
    {
        public SistemaTarefasDBContext(DbContextOptions<SistemaTarefasDBContext> options) : base(options)
        {
        }

        // Configurando as tabelas e configurações gerais das tabelas do banco de dados
        public DbSet<UsuarioModel> Usuarios { get; set; }   // UsuarioModel representa a tabela "Usuarios"
        public DbSet<TarefaModel> Tarefas { get; set; }     // TarefaModel representa a tabela "Tarefas"

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Adiciona o mapeamento para o context
            modelBuilder.ApplyConfiguration(new UsuarioMap());
            modelBuilder.ApplyConfiguration(new TarefaMap());

            base.OnModelCreating(modelBuilder);
        }
    }
}
