using Microsoft.EntityFrameworkCore;

namespace TaskManager.Models
{
    public class TaskManagerContext : DbContext
    {
        public TaskManagerContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<TaskModel> Tasks { get; set; }
        //klasa DbSet reprezentuje system ENCJI, której można używać do tworzenia, odczytu, usuwania itp.
        //klasa kontekstu musi zawierać właściwości typu DbSet dla encji, które są mapowane na tabele i widoki w bazie danych
    }
}
