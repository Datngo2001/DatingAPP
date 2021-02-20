using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using API.Data;
using API.Entity;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly DataContext _context;
        public UsersController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers()
        {
            return await _context.Users.ToListAsync();
        }

        [HttpGet("{id}")]
        public ActionResult<AppUser> GetUser(int id)
        {
            var users = _context.Users.Find(id);
            return users;
        }
    }
}