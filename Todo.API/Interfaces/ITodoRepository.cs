using Todo.API.Models.Entities;

namespace Todo.API.Interfaces
{
    public interface ITodoRepository
    {
        TodoTask Create(TodoTask task);

        TodoTask Update(TodoTask task);

        void Delete(TodoTask task);
    }
}
