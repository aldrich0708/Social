using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Social.Domain;

public class GroupSeed : IEntityTypeConfiguration<Group>
{
    public void Configure(EntityTypeBuilder<Group> builder)
    {
        builder.HasData(
            new Group { Id = 1, Name = "General", DateCreated = DateTime.Now, CreatedBy = "System" },
            new Group { Id = 2, Name = "Tech Talk", DateCreated = DateTime.Now, CreatedBy = "System" }
        );
    }
}