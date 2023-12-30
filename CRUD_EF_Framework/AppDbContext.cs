using CRUD_EF_Framework.Models;
using System.Data.Entity;

namespace CRUD_EF_Framework
{
    public class AppDbContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        public AppDbContext():base("name=DefaultConnection")
        {
            
        }
    }
}