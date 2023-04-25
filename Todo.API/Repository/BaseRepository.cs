using Todo.API.Interfaces;
using Todo.API.Models.Entities;

namespace Todo.API.Repository
{
    public class BaseRepository : IBaseRepository
    {
        private readonly TodoContext _context;

        public BaseRepository(TodoContext context)
        {
            _context = context;
        }

        public void Add<T>(T entity) where T : class
        {
            throw new NotImplementedException();
        }

        public void Delete<T>(T entity) where T : class
        {
            throw new NotImplementedException();
        }

        public bool SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void Update<T>(T entity) where T : class
        {
            throw new NotImplementedException();
        }
    }
}
