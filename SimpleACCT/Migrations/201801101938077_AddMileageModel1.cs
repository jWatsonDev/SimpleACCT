namespace SimpleACCT.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMileageModel1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Mileages",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Amount = c.Single(nullable: false),
                        CategoryId = c.Int(nullable: false),
                        DateAdded = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.CategoryId, cascadeDelete: true)
                .Index(t => t.CategoryId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Mileages", "CategoryId", "dbo.Categories");
            DropIndex("dbo.Mileages", new[] { "CategoryId" });
            DropTable("dbo.Mileages");
        }
    }
}
