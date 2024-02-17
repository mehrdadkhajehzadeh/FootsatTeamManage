using FootsalTeamManage.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FootsalTeamManage.persistance.Teams
{
    public class EFTeamEntityMap : IEntityTypeConfiguration<Team>
    {
        public void Configure(EntityTypeBuilder<Team> builder)
        {
            builder.ToTable("Teams");
            builder.HasKey("Id");
            builder.Property("TeamName");
            builder.Property("FirstClotheColor");
            builder.Property("SecondClotheColor");
        }
    }
}
