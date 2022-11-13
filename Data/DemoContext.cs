

using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using src.Areas.Identity.Data;

namespace demo_webapp.Data
{
    public class DemoContext : IdentityDbContext
    {
        public DbSet<Upload>? Uploads { get; set; }
        public DbSet<DemoUser>? DemoUsers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            var path = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            string db_path = Path.Join(path, "demo-webapp.sqlite");
            options.UseSqlite($"Data Source={db_path}");
        }
            
    }

}