namespace XMLOkuyucu.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class XmlApp : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Kullanicis",
                c => new
                    {
                        KullaniciId = c.Int(nullable: false, identity: true),
                        KullaniciAdi = c.String(nullable: false, maxLength: 50),
                        KullaniciParola = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.KullaniciId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Kullanicis");
        }
    }
}
