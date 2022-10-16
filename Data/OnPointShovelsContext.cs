using Microsoft.EntityFrameworkCore;
using OnPointShovels.Models;

namespace OnPointShovels.Data
{
    public class OnPointShovelsContext : DbContext
    {
        // Database context class for the company onPoint Shovels
        public OnPointShovelsContext(DbContextOptions<OnPointShovelsContext> options)
            : base(options)
        {
        }

        public DbSet<Shovel> Shovel { get; set; }
    }
}