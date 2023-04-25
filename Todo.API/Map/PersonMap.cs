using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Todo.API.Models.Entities;

namespace Todo.API.Map
{
    public class PersonMap : BaseMap<Person> 
    {
        public PersonMap() : base("tb_person") {}

        public override void Configure(EntityTypeBuilder<Person> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.User_name).HasColumnType("varchar(40)").HasColumnName("user_name").IsRequired();
            builder.Property(x => x.Pass).HasColumnType("varchar(100)").HasColumnName("password").IsRequired();
            builder.Property(x => x.Email).HasColumnType("varchar(200)").HasColumnName("email").IsRequired();
            builder.HasIndex(x => x.Email).IsUnique();
            builder.Property(x => x.Created_on).HasColumnName("created_at").IsRequired().HasDefaultValue(DateTime.Now);
            builder.Property(x => x.Last_login).HasColumnName("last_login");

        }
    }
}
