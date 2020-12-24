using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.IO;
using Microsoft.Extensions.Configuration;

namespace DataAccess.DataContext
{
    public class AppContext 
    {
        public  AppContext()
        {
            var path = Path.Combine(Directory.GetCurrentDirectory(), "appsettings.json");
            //var configBuild = new ConfigurationBuilder()
            //    .SetBasePath(path)
            //    .AddJsonFile("appsettings.json");

            var builder = new ConfigurationBuilder();
            builder.AddJsonFile(path, false);
            var root = builder.Build();
           // var root = configBuild.Build();
            var appSetting = root.GetSection("Data:ApsMvcDB:ConnectionString");
            sqlConnectionString = appSetting.Value;
        }

        public string sqlConnectionString { get; set; }
    }
}
