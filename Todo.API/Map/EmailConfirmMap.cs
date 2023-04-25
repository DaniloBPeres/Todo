using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Todo.API.Models.Entities;

namespace Todo.API.Map
{
    public class EmailConfirmMap : BaseMap<EmailConfirm>
    {
        public EmailConfirmMap() : base("tb_email_confirm") {}

        public override void Configure(EntityTypeBuilder<EmailConfirm> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.Email).HasColumnType("varchar(200)").HasColumnName("email_to_confirm").IsRequired();
            builder.Property(x => x.Code_confirm).HasPrecision(6).HasColumnName("code_to_confirm").IsRequired();
            builder.Property(x => x.Has_confirmed).HasColumnName("has_confirmed").HasDefaultValue(false);
            builder.Property(x => x.PersonId).HasColumnName("id_person").IsRequired();
        }

    }
}
