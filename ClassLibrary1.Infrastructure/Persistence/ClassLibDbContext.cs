using ClassLibrary1.Application.Common.Interfaces;
using ClassLibrary1.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace ClassLibrary1.Infrastructure.Persistence
{
    public class ClassLibDbContext : DbContext, IClassLibDbContext
    {
        public DbSet<User> Users { get; set; }

        public ClassLibDbContext(DbContextOptions<ClassLibDbContext> dbContextOpt) : base(dbContextOpt)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
