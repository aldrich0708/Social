namespace Social.Domain
{
    public class Message : BaseDomainModel
    {
        public string Content { get; set; } = string.Empty;
        public string? SenderId { get; set; }
        public int GroupId { get; set; }
        public Group? Group { get; set; }
    }
}