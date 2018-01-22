namespace SimpleACCT.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddLocationCategory : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Categories", "Location", c => c.String());
            AddColumn("dbo.Categories", "Address", c => c.String());
            AddColumn("dbo.Categories", "City", c => c.String());
            AddColumn("dbo.Categories", "State", c => c.String());
            AddColumn("dbo.Categories", "Zip", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Categories", "Zip");
            DropColumn("dbo.Categories", "State");
            DropColumn("dbo.Categories", "City");
            DropColumn("dbo.Categories", "Address");
            DropColumn("dbo.Categories", "Location");
        }
    }
}
