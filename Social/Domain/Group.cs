namespace Social.Domain
{
    public class Group : BaseDomainModel
    {
        public string? Name { get; set; }
        public List<Message>? Messages { get; set; }
    }
}
