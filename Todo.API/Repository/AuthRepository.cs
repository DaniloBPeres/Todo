using Microsoft.EntityFrameworkCore;
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
        private readonly IPassService _passService;
        private readonly IEmailRepository _emailServ;

        public AuthRepository(TodoContext context, IPassService passService, IEmailRepository mailServ) : base(context)
        {
            _context = context;
            _passService = passService;
            _emailServ = mailServ;
        }

        public LogedDTO Login(LoginDTO person)
        {
            var person1 = _context.Person.Include(x => x.EmailConfirm).Include(x => x.Tasks).Single(x => x.Email == person.Email);

            if (person1.Pass == _passService.GetPass(person.Password))
            {
                if(!person1.EmailConfirm.Has_confirmed)
                    return new LogedDTO() { Id = -1};
                else
                {
                    person1.Last_login = DateTime.Now;
                    Update(person1);
                    SaveChanges();
                    return new LogedDTO()
                    {
                        Id = person1.Id,
                        Name = person1.User_name,
                        todoTasks = _context.Todo.ToList().Where(x => x.PersonId == person1.Id),
                        tokenJWT = TokenService.GenerateToken(person1)
                    };
                }
            }
            else
                return new LogedDTO() { Id = 0};
        }

        public AwaitEmailConfirmDTO Register(RegisterDTO person)
        {
            if (person == null) return new AwaitEmailConfirmDTO();

            if(person.Pass == person.PassConfirm && person.Email == person.EmailConfirm)
            {
                Person PersonRegister = new()
                {
                    User_name = person.User_name,
                    Email = person.Email,
                    Pass = _passService.GetPass(person.Pass),
                    Created_on = DateTime.Now
                };
                Add(PersonRegister);
                SaveChanges();
                _emailServ.CreateEmailConfirm(person.Email);
                return new AwaitEmailConfirmDTO() { Email = person.Email, UserName = person.User_name };
            }
            else
                return new AwaitEmailConfirmDTO() { Email = ""};
        }

        public bool ConfirmEmail(AwaitEmailConfirmDTO confirm)
        {
            if (confirm == null) return false;

            EmailConfirm emailConfirm = _context.EmailConfirm.Single(x => x.Email == confirm.Email);
            
            if(confirm.CodeToConfirm == emailConfirm.Code_confirm)
            {
                emailConfirm.Has_confirmed = true;
                Update(emailConfirm);
                SaveChanges();
                return true;
            }

            return false;
        }
    }
}
