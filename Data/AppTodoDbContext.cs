using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using TodoApplikasjonenAPI3.Models;

namespace TodoApplikasjonenAPI3.Data
{
    public class AppTodoDbContext : DbContext
    {
        // Konstruktøren initialiserer DbContext med valgene.
        public AppTodoDbContext(DbContextOptions<AppTodoDbContext> options) : base(options) { }

        // Representerer TodosTask-tabellen i databasen.
        public DbSet<Todo> TodosTask { get; set; }

        // Konfigurerer modellen og legger til startdata i databasen.
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Startdata som legges til TodosTask-tabellen når databasen opprettes.
            modelBuilder.Entity<Todo>().HasData(
                new Todo { Id = 1, Title = "Buy groceries", Description = "Get milk, bread, and eggs from the store", IsCompleted = false },
                new Todo { Id = 2, Title = "Finish project report", Description = "Complete the final section and review formatting", IsCompleted = true }
            );
        }
    }
}
