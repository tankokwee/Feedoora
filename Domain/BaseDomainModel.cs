using Feedoora.Configurations.Entities;
using Microsoft.EntityFrameworkCore;



namespace Feedoora.Domain
{
    public abstract class BaseDomainModel
    {
        public int Id { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public string? Createdby { get; set; }
        public string? Updatedby { get; set; }
       
    }
}
