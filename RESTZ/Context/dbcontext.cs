using Microsoft.EntityFrameworkCore;

namespace RESTZ.Context
{
    public class dbcontext: DbContext
    {
        public dbcontext(DbContextOptions<dbcontext> opt): base(opt)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<autores_has_libros>().HasKey(x => new { x.libros_ISBN, x.autores_id });
        }
    }
}
