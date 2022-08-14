using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using e_commerce.Areas.Identity.Data;
var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("E_commerceDbContextConnection") ?? throw new InvalidOperationException("Connection string 'E_commerceDbContextConnection' not found.");

builder.Services.AddDbContext<E_commerceDbContext>(options =>
    options.UseSqlServer(connectionString));

builder.Services.AddDefaultIdentity<E_commerceUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<E_commerceDbContext>();

AddAuthrozitionPolitics();



// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication();;

app.UseAuthorization();
app.MapRazorPages();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();


void AddAuthrozitionPolitics()
{
    builder.Services.AddAuthorization(ops =>
    ops.AddPolicy("Vendor", policy =>
    policy.RequireRole("Vendor")));
    
    builder.Services.AddAuthorization(ops =>
        ops.AddPolicy("Customer", policy =>
        policy.RequireRole("Customer")));
   
    builder.Services.AddAuthorization(ops =>
        ops.AddPolicy("Admin", policy =>
        policy.RequireRole("Admin")));
}

