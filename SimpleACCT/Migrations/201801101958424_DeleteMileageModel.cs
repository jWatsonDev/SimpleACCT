namespace SimpleACCT.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteMileageModel : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Mileages", "CategoryId", "dbo.Categories");
            DropIndex("dbo.Mileages", new[] { "CategoryId" });
            DropTable("dbo.Mileages");
        }
        
        public override void Down()
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
                .PrimaryKey(t => t.Id);
            
            CreateIndex("dbo.Mileages", "CategoryId");
            AddForeignKey("dbo.Mileages", "CategoryId", "dbo.Categories", "Id", cascadeDelete: true);
        }
    }
}
