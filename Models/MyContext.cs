using Microsoft.EntityFrameworkCore;

 
namespace chefsndishes.Models
{
    public class MyContext : DbContext
    {
        // base() calls the parent class' constructor passing the "options" parameter along
        public MyContext(DbContextOptions options) : base(options) { }
        public DbSet<Chef> chefs {get;set;}
        public DbSet<Dish> dishes {get;set;}
    }
}