using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using TextbookFinder.Models;

namespace TextbookFinder.Models
{

    public static class IdentitySeedData
    {
        private const string adminUser = "Gus";
        private const string adminPassword = "G0ldf1sh!";

        public static async void EnsurePopulated(IApplicationBuilder app)
        {

            AppIdentityDbContext context = app.ApplicationServices
                .CreateScope().ServiceProvider
                .GetRequiredService<AppIdentityDbContext>();
            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            UserManager<IdentityUser> userManager = app.ApplicationServices
                .CreateScope().ServiceProvider
                .GetRequiredService<UserManager<IdentityUser>>();

            IdentityUser user = await userManager.FindByIdAsync(adminUser);
            if (user == null)
            {
                user = new IdentityUser("Gus");
                user.Email = "gus@example.com";
                user.PhoneNumber = "555-6789";
                await userManager.CreateAsync(user, adminPassword);
            }
        }
    }
}