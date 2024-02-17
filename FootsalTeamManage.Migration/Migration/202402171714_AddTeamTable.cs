using FluentMigrator;

namespace FootsalTeamManage.Migration.Migration
{
    [Migration(202402171714)]
    public class _202402171714_AddTeamTable : FluentMigrator.Migration
    {

        public override void Up()
        {
            Create.Table("Teams")
             .WithColumn("Id").AsInt32().PrimaryKey().Identity()
             .WithColumn("TeamName").AsString(50).NotNullable()
             .WithColumn("FirstClotheColor").AsString().Nullable()
             .WithColumn("secondClotheColor").AsString().Nullable();

        }
        public override void Down()
        {
            Delete.Table("Teams");

        }
    }
}
