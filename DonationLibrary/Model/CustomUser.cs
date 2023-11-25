using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
namespace DonationLibrary.Model

{
public class CustomUser : IdentityUser {
  public CustomUser() : base() { }

  public string? Username { get; set; }
}
}