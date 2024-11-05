using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Infrastructure.Extensions;

namespace Infrastructure.Data
{
    public class AppDBContext : IdentityDbContext<User>
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {

        }

        DbSet<Ticket> Tickets { get; set; }
        DbSet<Product> Products { get; set; }
        DbSet<Priority> Priorities { get; set; }
        DbSet<Discussion> Discussions { get; set; }
        DbSet<Category> Categories { get; set; }
        DbSet<Attachment> Attachments { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.GenerateSeed();

            builder.Entity<Ticket>()
                .HasOne(e => e.User)
                .WithMany()
                .OnDelete(DeleteBehavior.NoAction);

            builder.Entity<Discussion>()
                .HasOne(m => m.Ticket)
                .WithMany()
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
