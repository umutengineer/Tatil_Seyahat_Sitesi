namespace Tatil_Seyahat_Sitesi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addmigration : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Contacts", "AdSoyad", c => c.String(nullable: false));
            AlterColumn("dbo.Contacts", "Mail", c => c.String(nullable: false));
            AlterColumn("dbo.Contacts", "Konu", c => c.String(nullable: false));
            AlterColumn("dbo.Contacts", "Mesaj", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Contacts", "Mesaj", c => c.String());
            AlterColumn("dbo.Contacts", "Konu", c => c.String());
            AlterColumn("dbo.Contacts", "Mail", c => c.String());
            AlterColumn("dbo.Contacts", "AdSoyad", c => c.String());
        }
    }
}
