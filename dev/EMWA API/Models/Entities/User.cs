namespace EMWA_API.Models.Entities
{
    public class User
    {
        public Guid Id { get; set; }
        public required string Name { get; set; }
        public required string HashedPassword { get; set; }
        public required Role Role { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
    }
}
