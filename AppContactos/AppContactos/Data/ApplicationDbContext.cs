using AppContactos.Models;
using Microsoft.EntityFrameworkCore;

namespace AppContactos.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {
        }

        //Agregar los modelos aqui (Cada modelo corresponde a una tabla de la BD)

        public DbSet<Contacto> Contacto { get; set; }
    }
}
