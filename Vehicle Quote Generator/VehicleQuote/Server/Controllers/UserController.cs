using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VehicleQuote.Shared;
using VehicleQuoteApp.Data;

namespace VehicleQuoteApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly AppDbContext _context;

        public UserController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<User>>> GetUsers(string username)
        {
            var userList = await _context.Users.Where(u => u.username == username).ToListAsync();
            return userList;
        }
    }
}
