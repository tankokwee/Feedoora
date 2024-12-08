namespace Feedoora.Domain
{
    public class Customer : BaseDomainModel
    {
        public string? Username { get; set; }
        public string? Password { get; set; }
        public int PhoneNum { get; set; }
    }
}
