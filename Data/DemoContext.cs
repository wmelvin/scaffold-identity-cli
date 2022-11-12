

using Microsoft.EntityFrameworkCore;

namespace demo_webapp.Data
{
    public class DemoContext : DbContext
    {
        public DbSet<Upload> Uploads { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            var path = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            string db_path = Path.Join(path, "demo-webapp.sqlite");
            options.UseSqlite($"Data Source={db_path}");
        }
            
    }

}