using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace EasyBlog.Data
{
    public static class ApplicationDbContextSeed
    {
        public static async Task SeedAsync(RoleManager<IdentityRole> roleManager,UserManager<IdentityUser> userManager)
        {
            if(!await roleManager.RoleExistsAsync("Administrator"))
            {
                await roleManager.CreateAsync(new IdentityRole("Administrator"));
            }

            if(!await userManager.Users.AnyAsync(u => u.UserName == "admin@example.com"))
            {
                var user = new IdentityUser()
                {
                    UserName = "admin@example.com",
                    Email = "admin@example.com",
                    EmailConfirmed = true
                };
                await userManager.CreateAsync(user,"P@sword1");
                await userManager.AddToRoleAsync(user, "Administrator");
            }
        }
    }
}
