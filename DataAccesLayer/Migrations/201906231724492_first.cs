namespace DataAccesLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class first : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Kategoris",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Ad = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Kitaps",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Ad = c.String(),
                        IsbnNo = c.String(),
                        KategoriId_Id = c.Int(),
                        RafId_Id = c.Int(),
                        KitaplikId_Id = c.Int(),
                        YazarId_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Kategoris", t => t.KategoriId_Id)
                .ForeignKey("dbo.Rafs", t => t.RafId_Id)
                .ForeignKey("dbo.Kitapliks", t => t.KitaplikId_Id)
                .ForeignKey("dbo.Yazars", t => t.YazarId_Id)
                .Index(t => t.KategoriId_Id)
                .Index(t => t.RafId_Id)
                .Index(t => t.KitaplikId_Id)
                .Index(t => t.YazarId_Id);
            
            CreateTable(
                "dbo.Kitapliks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Ad = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Rafs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RafNo = c.String(),
                        KitaplikId_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Kitapliks", t => t.KitaplikId_Id)
                .Index(t => t.KitaplikId_Id);
            
            CreateTable(
                "dbo.Yazars",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Ad = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Kitaps", "YazarId_Id", "dbo.Yazars");
            DropForeignKey("dbo.Kitaps", "KitaplikId_Id", "dbo.Kitapliks");
            DropForeignKey("dbo.Rafs", "KitaplikId_Id", "dbo.Kitapliks");
            DropForeignKey("dbo.Kitaps", "RafId_Id", "dbo.Rafs");
            DropForeignKey("dbo.Kitaps", "KategoriId_Id", "dbo.Kategoris");
            DropIndex("dbo.Rafs", new[] { "KitaplikId_Id" });
            DropIndex("dbo.Kitaps", new[] { "YazarId_Id" });
            DropIndex("dbo.Kitaps", new[] { "KitaplikId_Id" });
            DropIndex("dbo.Kitaps", new[] { "RafId_Id" });
            DropIndex("dbo.Kitaps", new[] { "KategoriId_Id" });
            DropTable("dbo.Yazars");
            DropTable("dbo.Rafs");
            DropTable("dbo.Kitapliks");
            DropTable("dbo.Kitaps");
            DropTable("dbo.Kategoris");
        }
    }
}
