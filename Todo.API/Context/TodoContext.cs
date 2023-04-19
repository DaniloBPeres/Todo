﻿using Microsoft.EntityFrameworkCore;

namespace Todo.API.Models
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options) : base(options) { }

        public DbSet<Person> Person { get; set; }

        public DbSet<Todo> Todo { get; set; }
    }
}
