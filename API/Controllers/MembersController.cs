using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using API.Data;
using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MembersController(AppDbContext context) : ControllerBase
    {
        [HttpGet]
        public async Task <ActionResult<List<AppUser>>> GetAppUser()
        {
            var members = await context.AppUsers.ToListAsync();
            return members;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<AppUser>> GetAppUserById(string id)
        {
            var member = await context.AppUsers.FindAsync(id);
            if (member == null)
            {
                return NotFound();
            }
            return member;
        }
    }
}