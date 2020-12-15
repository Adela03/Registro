using Microsoft.EntityFrameworkCore;
using registro.Models;

namespace registro.Data
{
    public class WebAppContext : DbContext
    {
        public DbSet<Registro> Productos {get;set;}
        public WebAppContext(DbContextOptions dco) : base(dco){
            
        }
    }
}