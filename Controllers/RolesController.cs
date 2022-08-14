using e_commerce.Areas.Identity.Data;
using e_commerce.Models;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace e_commerce.Controllers
{
    public class RolesController : Controller
    {
        private readonly E_commerceDbContext _context;
       

        public RolesController(E_commerceDbContext context)
        {
            _context = context;   
        }
        // GET: RolesController
        public async Task<IActionResult> Index()
        {
          var users = await _context.Users.ToListAsync();
          foreach (var user in users)
            {
                var IsExixts = _context.usersAndRoles.Any(x => x.Name == user.UserName && x.Roles == user.Role);
                if (!IsExixts) {
                    var userandrole = new UserAndRole { Name = user.UserName, Roles = user.Role };
                    await _context.usersAndRoles.AddAsync(userandrole);
                    await _context.SaveChangesAsync();
                }
            }
          var result = await _context.usersAndRoles.ToListAsync();

            return View(result);

        }
        

        

        

        // GET: RolesController/Details/5


    }
}
