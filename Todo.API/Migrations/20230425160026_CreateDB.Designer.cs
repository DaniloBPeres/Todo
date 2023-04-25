﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Todo.API.Models.Entities;

#nullable disable

namespace Todo.API.Migrations
{
    [DbContext(typeof(TodoContext))]
    [Migration("20230425160026_CreateDB")]
    partial class CreateDB
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Todo.API.Models.Entities.EmailConfirm", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("Code_confirm")
                        .HasPrecision(6)
                        .HasColumnType("integer")
                        .HasColumnName("code_to_confirm");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(200)")
                        .HasColumnName("email_to_confirm");

                    b.Property<bool>("Has_confirmed")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(false)
                        .HasColumnName("has_confirmed");

                    b.HasKey("Id");

                    b.ToTable("tb_email_confirm", (string)null);
                });

            modelBuilder.Entity("Todo.API.Models.Entities.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Created_on")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValue(new DateTime(2023, 4, 25, 13, 0, 26, 23, DateTimeKind.Local).AddTicks(174))
                        .HasColumnName("created_at");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(200)")
                        .HasColumnName("email");

                    b.Property<DateTime>("Last_login")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("last_login");

                    b.Property<string>("Pass")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasColumnName("password");

                    b.Property<string>("User_name")
                        .IsRequired()
                        .HasColumnType("varchar(40)")
                        .HasColumnName("user_name");

                    b.HasKey("Id");

                    b.ToTable("tb_person", (string)null);
                });

            modelBuilder.Entity("Todo.API.Models.Entities.TodoTask", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Finished_date")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("task_finished_date");

                    b.Property<bool>("Has_finished")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(false)
                        .HasColumnName("has_finished");

                    b.Property<string>("Task")
                        .IsRequired()
                        .HasColumnType("varchar(1000)")
                        .HasColumnName("task");

                    b.Property<DateTime>("Todo_datetime")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("task_datetime");

                    b.HasKey("Id");

                    b.ToTable("tb_todotask", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
