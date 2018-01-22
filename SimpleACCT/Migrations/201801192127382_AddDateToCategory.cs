namespace SimpleACCT.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDateToCategory : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Categories", "Date", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Categories", "Date");
        }
    }
}
