using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//using MySql.Data.Entity;
using System.Data.Entity;

namespace EFMysql.DataLayer
{

    [DbConfigurationType(typeof(MySql.Data.Entity.MySqlEFConfiguration))]
    public class SchoolContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Standard> Standards { get; set; }
        public DbSet<V_Student> V_Student { get; set; }


        public SchoolContext()
            : base("name=EFMysql.Properties.Settings.schoolDbConnectionString")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<SchoolContext, Migrations.Configuration>());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }       
    }
}
