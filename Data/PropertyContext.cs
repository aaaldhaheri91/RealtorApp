using Microsoft.EntityFrameworkCore;
using RealtorApp.Models;

namespace RealtorApp.Data 
{
    public class PropertyContext : DbContext
    {
        public PropertyContext(DbContextOptions<PropertyContext> options) : base(options)
        {
        }

        public DbSet<Property> Property { get; set; }

        public DbSet<User> User { get; set; }
    }
}