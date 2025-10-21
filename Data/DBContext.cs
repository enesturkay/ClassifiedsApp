using ilanApp.Models;
using Microsoft.EntityFrameworkCore;

namespace ilanApp.Data
{
    public class DBContext : DbContext
    {
        public DBContext(DbContextOptions<DBContext> options) : base(options)
        {
            
        }
        public DbSet<advertInfo> AdvertInfs => Set<advertInfo>();
        public DbSet<Category> categoriesInfs => Set<Category>();        
    }
}