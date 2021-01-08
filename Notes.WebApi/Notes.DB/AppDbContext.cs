using Microsoft.EntityFrameworkCore;

namespace Notes.DB
{
    public class AppDbContext : DbContext
    {
        public DbSet<Note> Notes { get; set; }

        // Подключаем БД
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server=(localdb)\mssqllocaldb;Database=Notes;Integrated Security=True");
        }
    }
}
