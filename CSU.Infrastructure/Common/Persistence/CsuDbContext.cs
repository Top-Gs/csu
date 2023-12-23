﻿using CSU.Application.Common.Interfaces;
using NewsDomain = CSU.Domain.News;
using CSU.Domain.Users;

using Microsoft.EntityFrameworkCore;

using System.Reflection;

namespace CSU.Infrastructure.Common.Persistence
{
    public class CsuDbContext : DbContext, IUnitOfWork
    {
        public CsuDbContext(DbContextOptions<CsuDbContext> options) : base(options) { }

        public async Task CommitChangesAsync()
        {
            await SaveChangesAsync();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<NewsDomain.News> News { get; set; } = null!;
        public DbSet<NewsDomain.Image> Images { get; set; } = null!;
        public DbSet<NewsDomain.Hashtag> Hashtags { get; set; } = null!;
        public DbSet<User> Users { get; set; } = null!;
    }
}
