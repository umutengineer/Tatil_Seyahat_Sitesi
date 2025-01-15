namespace Tatil_Seyahat_Sitesi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateDatabaseSchema : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Yorumlars", "Otel_Id", "dbo.Otellers");
            DropIndex("dbo.Yorumlars", new[] { "Otel_Id" });
            DropColumn("dbo.Yorumlars", "Otel_Id");
            DropTable("dbo.Otellers");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Otellers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Location = c.String(),
                        Price = c.Int(nullable: false),
                        Description = c.String(),
                        ImageUrl = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Yorumlars", "Otel_Id", c => c.Int());
            CreateIndex("dbo.Yorumlars", "Otel_Id");
            AddForeignKey("dbo.Yorumlars", "Otel_Id", "dbo.Otellers", "Id");
        }
    }
}
