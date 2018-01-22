namespace SimpleACCT.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Transactions", "Date", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Transactions", "Date");
        }
    }
}
