using Todo.API.Models.DTOs;
using Todo.API.Models.Entities;

namespace Todo.API.Interfaces
{
    public interface IPersonRepository
    {
        Person GetPersonById(int id);
    }
}
