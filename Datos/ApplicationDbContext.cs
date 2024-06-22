using CRUD_7_RAZOR.Modelos;
using Microsoft.EntityFrameworkCore;

namespace CRUD_7_RAZOR.Datos
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        //Poner aquí los modelos
        public DbSet<Producto> Producto { get; set; }
    }
}
