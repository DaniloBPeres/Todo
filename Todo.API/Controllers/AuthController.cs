using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Todo.API.Interfaces;
using Todo.API.Models.DTOs;

namespace Todo.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthRepository _repository;

        public AuthController(IAuthRepository repository)
        {
            _repository = repository;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginDTO person)
        {
            var loged = _repository.Login(person);

            if (loged.Id == 0)
                return Unauthorized();
            else
                return Ok(loged);
        }
    }
}
