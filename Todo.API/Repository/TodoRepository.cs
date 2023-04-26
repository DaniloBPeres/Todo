using Todo.API.Interfaces;
using Todo.API.Models.Entities;

namespace Todo.API.Repository
{
    public class TodoRepository : BaseRepository, ITodoRepository
    {
        private readonly TodoContext _context;

        public TodoRepository(TodoContext context) : base(context)
        {
            _context = context;
        }

        public TodoTask Create(TodoTask task)
        {
            Add(task);
            SaveChanges();
            return task;
        }

        public void Delete(TodoTask task)
        {
            Delete(task);
            SaveChanges();
        }

        public TodoTask Update(TodoTask task)
        {
            Update(task);
            SaveChanges();
            return task;
        }
    }
}
