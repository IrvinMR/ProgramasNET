using System;
using dvdCollection.Data;
using dvdCollection.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(dvdCollection.Areas.Identity.IdentityHostingStartup))]
namespace dvdCollection.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<dvdCollectionContext>(options =>
                    options.UseSqlite(
                        context.Configuration.GetConnectionString("DefaultConnection")));

                services.AddDefaultIdentity<User>()
                    .AddEntityFrameworkStores<dvdCollectionContext>();
            });
        }
    }
}