namespace SimpleACCT.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteMilelageModel : DbMigration
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
                        Name = c.String(),
                        Notes = c.String(),
                        DateAdded = c.String(),
                        CategoryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateIndex("dbo.Mileages", "CategoryId");
            AddForeignKey("dbo.Mileages", "CategoryId", "dbo.Categories", "Id", cascadeDelete: true);
        }
    }
}
