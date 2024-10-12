namespace Domain.Models
{
    public class PlatformManagers
    {
        public PlatformManagers()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}