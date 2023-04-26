using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Todo.API.Interfaces;
using Todo.API.Models.DTOs;
using Todo.API.Models.Entities;

namespace Todo.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthRepository _repository;
        private readonly IRegexService _regex;

        public AuthController(IAuthRepository repository, IRegexService regex)
        {
            _repository = repository;
            _regex = regex;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginDTO person)
        {
            var loged = _repository.Login(person);

            if (loged.Id == 0)
                return Unauthorized("Incorrect Pass!");
            else if (loged.Id == -1)
                return Unauthorized("Email not confirmed!");
            else
                return Ok(loged);
        }

        [HttpPost("register")]
        public IActionResult Register(RegisterDTO person)
        {
            if (!_regex.ValidateEmail(person.Email))
                return BadRequest("Email Inválido");

            AwaitEmailConfirmDTO register = _repository.Register(person);

            if (register.Email == null)
                return NotFound("Registro Vazio!");
            else if (!string.IsNullOrEmpty(register.Email))
                return Ok("success");
            else
                return BadRequest(register);
        }

        [HttpPost("confirm_email")]
        public IActionResult ConfirmEmail(AwaitEmailConfirmDTO emailConfirm)
        {
            bool result = _repository.ConfirmEmail(emailConfirm);

            if (result)
                return Ok("Email Confirmed!");
            else
                return BadRequest("Erro ao Confirmar email");
        }
    }
}
