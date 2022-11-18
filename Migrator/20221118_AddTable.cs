using FluentMigrator;

namespace Migrator;

[Migration(20221118121800)]
public class AddTable : Migration
{
    public override void Up()
    {
        Create.Table("Log")
            .WithColumn("Id").AsInt64().PrimaryKey().Identity()
            .WithColumn("Text").AsString();
    }

    public override void Down()
    {
        Delete.Table("Log");
    }
}