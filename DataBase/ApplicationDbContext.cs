using System.Data.Entity;
using EntityFramework.CodeFirst.Migrations;
using DataBase.Models;

namespace EntityFramework.CodeFirst
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
        {
            //Important performance code
            Configuration.AutoDetectChangesEnabled = false; 
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;
        }

        static ApplicationDbContext()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<ApplicationDbContext, ApplicationDbInitializer>());
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        // public DbSet<MyClass> Educations { get; set; } //Example for creating db table 

        public DbSet<Conta> Conta { get; set; }
        public DbSet<Contato> Contato { get; set; }
    }
}
