using Microsoft.EntityFrameworkCore;
using Todo.API.Interfaces;
using Todo.API.Models.DTOs;
using Todo.API.Models.Entities;

namespace Todo.API.Repository
{
    public class PersonRepository : BaseRepository, IPersonRepository
    {
        private readonly TodoContext _context;

        public PersonRepository(TodoContext context) : base(context)
        {
            _context = context;
        }

        public Person GetPersonById(int id)
        {
            var person = _context.Person.Include(x => x.EmailConfirm).Single(p => p.Id == id);
            return person;
        }

    }
}
