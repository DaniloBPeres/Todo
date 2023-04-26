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
            _context.Add(entity);
        }

        public void Delete<T>(T entity) where T : class
        {
            _context.Remove(entity);
        }

        public bool SaveChanges()
        {
            var save = _context.SaveChanges();
            if (save <= 0)
                return false;
            else
                return true;
        }

        public void Update<T>(T entity) where T : class
        {
            _context.Update(entity);
        }
    }
}
