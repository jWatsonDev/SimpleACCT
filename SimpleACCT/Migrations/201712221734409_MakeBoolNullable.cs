namespace SimpleACCT.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MakeBoolNullable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Transactions", "Paid", c => c.Boolean());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Transactions", "Paid", c => c.Boolean(nullable: false));
        }
    }
}
