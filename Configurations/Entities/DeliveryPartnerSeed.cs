using Feedoora.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Feedoora.Configurations.Entities
{
    public class DeliveryPartnerSeed : IEntityTypeConfiguration<DeliveryPartner>
    {
        public void Configure(EntityTypeBuilder<DeliveryPartner> builder)
        {
            builder.HasData(
                new DeliveryPartner
                {
                    Id = 1,
                    Username = "Kokwee",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    Createdby = "System",
                    Updatedby = "System"
                }
                );
        }
    }
}
