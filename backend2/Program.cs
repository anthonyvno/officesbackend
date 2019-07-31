using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using backend2.Data;
using backend2.Models;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace backend2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IWebHost host = CreateWebHostBuilder(args).Build();
            using (IServiceScope scope = host.Services.CreateScope())
            {
                ApplicationContext context = scope.ServiceProvider.GetRequiredService<ApplicationContext>();

                context.Offices.AddRange(
                  new Office
                  {
                      Name = "Dunder Mifflin Ghent",
                      City = "Ghent",
                      Latitude = 51.043476,
                      Longitude = 3.709138,
                      Email = "ghent@dundermifflin.com"
                  },
                  new Office
                  {
                      Name = "Dunder Mifflin Kortrijk",
                      City = "Kortrijk",
                      Latitude = 50.822956,
                      Longitude = 3.250962,
                      Email = "kortrijk@dundermifflin.com"
                  },
                  new Office
                  {
                      Name = "Dunder Mifflin Harelbeke",
                      City = "Harelbeke",
                      Latitude = 50.855366,
                      Longitude = 3.312553,
                      Email = "harelbeke@dundermifflin.com"
                  }
                );

                context.SaveChanges();

            }
            host.Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
