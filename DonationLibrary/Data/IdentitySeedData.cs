// using System.ComponentModel;
// using Microsoft.Extensions.DependencyInjection;
// using Microsoft.AspNetCore.Identity;
// using Microsoft.EntityFrameworkCore;
// using DonationLibrary.Model;
// using Microsoft.AspNetCore.Identity.EntityFrameworkCore;


// namespace DonationLibrary.Data;

// public class IdentitySeedData
// {
//     public static async Task Initialize(DonationDbContext context, UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager)
//     {
//         context.Database.EnsureCreated();
//         string adminRole = "Admin";
//         string financeRole = "Finance";
//         if (await roleManager.FindByNameAsync(adminRole) == null)
//         {
//             await roleManager.CreateAsync(new IdentityRole(adminRole));
//         }
//         if (await roleManager.FindByNameAsync(financeRole) == null)
//         {
//             await roleManager.CreateAsync(new IdentityRole(financeRole));
//         }
//         if (await userManager.FindByNameAsync("a@a.a") == null)
//         {
//             var user = new IdentityUser
//             {
//                 UserName = "a@a.a"
//             };
//             var result = await userManager.CreateAsync(user);
//             if (result.Succeeded)
//             {
//                 await userManager.AddPasswordAsync(user, "P@ssw0rd");
//                 await userManager.AddToRoleAsync(user, adminRole);
//             }
//         }
//         if (await userManager.FindByNameAsync("f@f.f") == null)
//         {
//             var user = new IdentityUser
//             {
//                 UserName = "f@f.f"
//             };
//             var result = await userManager.CreateAsync(user);
//             if (result.Succeeded)
//             {
//                 await userManager.AddPasswordAsync(user, "P@ssw0rd");
//                 await userManager.AddToRoleAsync(user, financeRole);
//             }
//         }
//     }    
// }
