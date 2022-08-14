using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace e_commerce.Areas.Identity.Data;

// Add profile data for application users by adding properties to the E_commerceUser class
public class E_commerceUser : IdentityUser
{
    public string FullName { get; set; }
    public string Role { get; set; }
}

