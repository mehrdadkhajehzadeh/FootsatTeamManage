using FootsalTeamManage.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FootsalTeamManage.persistance.Players
{
    public class EFPlayerEntityMap : IEntityTypeConfiguration<Player>
    {
        public void Configure(EntityTypeBuilder<Player> builder)
        {
            builder.ToTable("Players");
            builder.HasKey("Id");
            builder.Property("PlayerName");
            builder.Property("PlayerRole");
        }
    }
}
