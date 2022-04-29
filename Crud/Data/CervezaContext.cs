using Microsoft.EntityFrameworkCore;
namespace Crud
{
    public class CervezaContext : DbContext
    {
       public DbSet<Cerveza> Cervezas {get; set;}
       protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
       {
           optionsBuilder.UseSqlServer(@"Server=(LocalDB)\PVE;Database=Cervezas;Trusted_Connection=True;");
       }
    }
}