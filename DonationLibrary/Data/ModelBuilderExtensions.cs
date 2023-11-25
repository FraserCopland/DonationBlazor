// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;
// using Microsoft.CodeAnalysis.CSharp.Syntax;
// using Microsoft.AspNetCore.Identity;
// using Microsoft.EntityFrameworkCore;
// using DonationLibrary.Model;
// using DonationLibrary.Donation;

// namespace DonationLibrary.Data
// {
//     public static class ModelBuilderExtensions
//     {
//         public static void Seed(this ModelBuilder modelBuilder){
//             var passwordHasher = new PasswordHasher<IdentityUser>();
//             var adminRole = new CustomRole("Admin", "Administrator",DateTime.Now);
//             var financeRole = new CustomRole("Finance", "Finance User", DateTime.Now);
//             List<CustomRole> roles = new List<CustomRole>(){
//                 adminRole,
//                 financeRole
//             };
//             modelBuilder.Entity<CustomRole>().HasData(roles);

//             var adminUser = new CustomUser{
//                 UserName = "a@a.a"
//             };
//             adminUser.PasswordHash = passwordHasher.HashPassword(adminUser, "P@ssw0rd");
//             var financeUser = new CustomUser{
//                 UserName = "f@f.f"
//             };
//             financeUser.PasswordHash = passwordHasher.HashPassword(financeUser, "P@ssw0rd");
//             List<CustomUser> users = new List<CustomUser>(){
//                 adminUser,
//                 financeUser
//             };
//             modelBuilder.Entity<CustomUser>().HasData(users);
//             List<IdentityUserRole<string>> userRoles = new List<IdentityUserRole<string>>();
//             userRoles.Add(new IdentityUserRole<string>(){
//                 UserId = users[0].Id,
//                 RoleId = roles.First(q=>q.Name == "Admin").Id
//             });
//             userRoles.Add(new IdentityUserRole<string>(){
//                 UserId = users[1].Id,
//                 RoleId = roles.First(q=>q.Name == "Finance").Id
//             });
//             modelBuilder.Entity<IdentityUserRole<string>>().HasData(userRoles);
//             }
//         }
//     }