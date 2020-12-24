using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using static DataAccess.DataContext.DatabaseContext;

namespace DataAccess.DataContext
{
    public class DatabaseContext : DbContext
    {
        public class OptionBuild
        {
            public OptionBuild()
            {
                settings = new AppContext();
                opsBuilder = new DbContextOptionsBuilder<DatabaseContext>();
                opsBuilder.UseSqlServer(settings.sqlConnectionString);
                dbOptions = opsBuilder.Options;
            }
            public DbContextOptionsBuilder<DatabaseContext> opsBuilder  { get; set; }
            public DbContextOptions<DatabaseContext> dbOptions { get; set; }
            private AppContext settings { get; set; }

        }
        public static OptionBuild ops = new OptionBuild();
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
        }

        public DbSet<Person> PeopleDb { get; set; }
    }
}
