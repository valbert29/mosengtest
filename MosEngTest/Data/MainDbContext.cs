using System;
using System.IO;
using System.Runtime.Intrinsics.Arm;
using Microsoft.EntityFrameworkCore;
using MosEngTest.Data.Entities;
using System.Security.Cryptography;
using NpgsqlTypes;

namespace MosEngTest.Data
{
    public sealed class MainDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Todo> Todos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(
                @"Host=localhost;Port=5432;Database=mosengtest;Username=postgres;Password=postgres");
        }
    }
}