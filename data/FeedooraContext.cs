using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Feedoora.Domain;
using Feedoora.Configurations.Entities;

namespace Feedoora.Data
{
    public class FeedooraContext : DbContext
    {
        public FeedooraContext (DbContextOptions<FeedooraContext> options)
            : base(options)
        {
        }

        public DbSet<Feedoora.Domain.Customer> Customer { get; set; } = default!;
        public DbSet<Feedoora.Domain.DeliveryPartner> DeliveryPartner { get; set; } = default!;
        public DbSet<Feedoora.Domain.Restaurant> Restaurant { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new CustomerSeed());
        }
    }
}
