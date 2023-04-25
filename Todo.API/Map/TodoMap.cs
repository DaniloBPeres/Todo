using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Todo.API.Models.Entities;

namespace Todo.API.Map
{
    public class TodoMap : BaseMap<TodoTask>
    {
        public TodoMap() : base("tb_todo_task") {}

        public override void Configure(EntityTypeBuilder<TodoTask> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.Task).HasColumnType("varchar(1000)").HasColumnName("task").IsRequired();
            builder.Property(x => x.Has_finished).HasColumnName("has_finished").HasDefaultValue(false);
            builder.Property(x => x.Todo_datetime).HasColumnName("task_datetime").IsRequired();
            builder.Property(x => x.Finished_date).HasColumnName("task_finished_date");

            builder.Property(x => x.PersonId).HasColumnName("id_person").IsRequired();
            builder.HasOne(x => x.Person).WithMany(x => x.Tasks).HasForeignKey(x => x.PersonId);
        }
    }
}
