using e_commerce.Areas.Identity.Data;
using e_commerce.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace e_commerce.Areas.Identity.Data;

public class E_commerceDbContext : IdentityDbContext<E_commerceUser>
{
    public E_commerceDbContext(DbContextOptions<E_commerceDbContext> options)
        : base(options)
    {
    }
    public DbSet<Product> products { get; set; }
    public DbSet<UserAndRole> usersAndRoles { get; set; }
    

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
        Roles.AddAsync(new IdentityRole { Name = "Admin" });
        Roles.AddAsync(new IdentityRole { Name = "Vendor" });
        Roles.AddAsync(new IdentityRole { Name = "Customer" });

    }


    public DbSet<e_commerce.Models.Role>? Role { get; set; }
}
