using FluentMigrator;

namespace FootsalTeamManage.Migration.Migration
{
    [Migration(202402172011)]
    public class _202402172011_AddPlayerTable : FluentMigrator.Migration
    {

        public override void Up()
        {
            Create.Table("Players")
             .WithColumn("Id").AsInt32().PrimaryKey().Identity()
             .WithColumn("PlayerName").AsString(50).NotNullable()
             .WithColumn("playerRole").AsString().Nullable();
        }
        public override void Down()
        {
            Delete.Table("Players");
        }
    }
}
