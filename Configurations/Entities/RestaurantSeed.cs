using Feedoora.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Feedoora.Configurations.Entities
{
    public class RestaurantSeed : IEntityTypeConfiguration<Restaurant>
    {
        public void Configure(EntityTypeBuilder<Restaurant> builder)
        {
            builder.HasData(
                new Restaurant
                {
                    Id = 1,
                    Username = "Mcdonald_Yishun",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    Createdby = "System",
                    Updatedby = "System"
                }
                );
        }
    }
}
