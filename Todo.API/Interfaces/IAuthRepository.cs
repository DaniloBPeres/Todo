using Todo.API.Models.DTOs;

namespace Todo.API.Interfaces
{
    public interface IAuthRepository
    {
        LogedDTO Login(LoginDTO person);
    }
}
