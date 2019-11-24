using IdentityDemo2.Data;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;

namespace AdminPortal
{
    class Program
    {
        static void Main(string[] args)
        {
            var host = new HostBuilder().Build();

            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                try
                {
                    var context = services.GetRequiredService<ApplicationDbContext>();
                    context.Database.Migrate();
                }
            }
        }
    }
}
