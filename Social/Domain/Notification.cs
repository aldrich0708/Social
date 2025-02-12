namespace Social.Domain
{
    public class Notification : BaseDomainModel
    {
        public string? Content { get; set; }
        public string? UserId { get; set; }
    }
}
