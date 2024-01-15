using DatingApp.Data;
using DatingApp.Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly DataContext _db;
        public UsersController(DataContext db)
        {
            _db = db;
        }

        [HttpGet]
        public async Task<ActionResult <IEnumerable<AppUser>>> Users()
        {
            var users= await _db.Users.ToListAsync();

            return Ok(users);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<AppUser>> Users(int id) 
        {
            var user = await _db.Users.FindAsync(id);

            return Ok(user);
        }
    }
}