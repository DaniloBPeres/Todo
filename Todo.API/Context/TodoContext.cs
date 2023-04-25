using Microsoft.EntityFrameworkCore;
using Todo.API.Models.Entities;

namespace Todo.API.Models.Entities
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options) : base(options) 
        {
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
        }

        public DbSet<Person> Person { get; set; }

        public DbSet<TodoTask> Todo { get; set; }

        public DbSet<EmailConfirm> EmailConfirm { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
        }
    }
}
