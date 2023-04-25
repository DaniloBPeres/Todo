using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Todo.API.Interfaces;
using Todo.API.Models.DTOs;
using Todo.API.Models.Entities;
using Todo.API.Services;

namespace Todo.API.Repository
{
    public class AuthRepository : BaseRepository, IAuthRepository
    {
        private readonly TodoContext _context;

        public AuthRepository(TodoContext context) : base(context)
        {
            _context = context;
        }

        public LogedDTO Login(LoginDTO person)
        {
            var person1 = _context.Person.Single(x => x.Email == person.Email);

            if (person1.Pass == person.Password)
                return new LogedDTO()
                {
                    Id = person1.Id,
                    Name = person1.User_name,
                    todoTasks = _context.Todo.ToList().Where(x => x.PersonId == person1.Id),
                    tokenJWT = TokenService.GenerateToken(person1)
                };
            else
                return new LogedDTO();
        }

    }
}
