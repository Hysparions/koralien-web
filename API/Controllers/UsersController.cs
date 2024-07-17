using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers;

[ApiController]
[Route("koralien/[controller]")] // api/users
public class UsersController(DataContext context) : ControllerBase
{ 

    [HttpGet]
    public async Task<ActionResult<IEnumerable<User>>> GetUsers() => await context.Users.ToListAsync();

    [HttpGet("{id}")]
    public async Task<ActionResult<User>> GetUser(int id)
    {
        var user = await context.Users.FindAsync(id);
        return user == null ? NotFound() : user;
    } 
}