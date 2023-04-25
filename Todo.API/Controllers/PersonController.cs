using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Todo.API.Interfaces;

namespace Todo.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonController : ControllerBase
    {
        private readonly IPersonRepository _repository;

        public PersonController(IPersonRepository repository)
        {
            _repository = repository;
        }

        
        [HttpGet("{id}")]
        [Authorize]
        public IActionResult Get(int id)
        {
            var person = _repository.GetPersonById(id);
            if (person.Id == id)
            {
                return Ok(person);
            }
            else
            {
                return BadRequest("Usuário não Encontrado");
            }
        }


    }
}
