using Feedoora.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Drawing;

namespace Feedoora.Configurations.Entities
{
    public class CustomerSeed : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasData(
                new Customer
                {
                    Id = 1,
                    Username = "WayneToh",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    Createdby = "System",
                    Updatedby = "System"
                }
                );
        }
    }
}
