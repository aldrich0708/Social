using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Social.Domain;

namespace Social.Data
{
    public class SocialContext : DbContext
    {
        public SocialContext (DbContextOptions<SocialContext> options)
            : base(options)
        {
        }

        public DbSet<Social.Domain.Message> Message { get; set; } = default!;
        public DbSet<Social.Domain.Group> Group { get; set; } = default!;
        public DbSet<Social.Domain.Notification> Notification { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new GroupSeed());
        }
    }
}
