﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Todo.API.Models.Entities;

namespace Todo.API.Map
{
    public class BaseMap<T> : IEntityTypeConfiguration<T> where T : Base
    {
        private readonly string _tableName;

        public BaseMap(string tableName)
        {
            _tableName = tableName;
        }

        public virtual void Configure(EntityTypeBuilder<T> builder)
        {
            if (!string.IsNullOrEmpty(_tableName)) builder.ToTable(_tableName);

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd().HasColumnName("id");
        }
    }
}
