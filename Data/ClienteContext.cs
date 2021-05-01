using Microsoft.EntityFrameworkCore;
using LifeDental.Models;

namespace LifeDental.Data
{
    public class ClienteContext : DbContext
    {
        public ClienteContext(DbContextOptions<ClienteContext> option) : base(option)
        {
            Database.EnsureCreated();
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Registro> Registros { get; set; }
        public DbSet<Produto> Produtos { get; set; }


       /* protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Password=1234;Persist Security Info=True;User ID=Life;Initial Catalog=Life;Data Source=DESKTOP-H29MJV8");
        }*/

    }


}
