using System.IdentityModel.Tokens.Jwt;
using Todo.API.Models.Entities;

namespace Todo.API.Models.DTOs
{
    public class LogedDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<TodoTask> todoTasks { get; set; } 
        public string tokenJWT { get; set; }

    }
}
