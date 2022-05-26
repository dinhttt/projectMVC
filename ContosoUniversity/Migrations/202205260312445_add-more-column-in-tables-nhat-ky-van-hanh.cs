namespace ContosoUniversity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addmorecolumnintablesnhatkyvanhanh : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Nhatkyvanhanh", "Luuluongvao", c => c.Single(nullable: false));
            AddColumn("dbo.Nhatkyvanhanh", "Luuluongra", c => c.Single(nullable: false));
            AddColumn("dbo.Nhatkyvanhanh", "Chisotieuthudien", c => c.Single(nullable: false));
            AddColumn("dbo.Nhatkyvanhanh", "Khoiluongtieuthudien", c => c.Single(nullable: false));
            AddColumn("dbo.Nhatkyvanhanh", "polymervao", c => c.Single(nullable: false));
            AddColumn("dbo.Nhatkyvanhanh", "polymerra", c => c.Single(nullable: false));
            AddColumn("dbo.Nhatkyvanhanh", "phabotvao", c => c.Single(nullable: false));
            AddColumn("dbo.Nhatkyvanhanh", "phabotra", c => c.Single(nullable: false));
            AddColumn("dbo.Nhatkyvanhanh", "NguoiTruc", c => c.String());
            AlterColumn("dbo.Nhatkyvanhanh", "Thongtinsuco", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Nhatkyvanhanh", "Thongtinsuco", c => c.Int(nullable: false));
            DropColumn("dbo.Nhatkyvanhanh", "NguoiTruc");
            DropColumn("dbo.Nhatkyvanhanh", "phabotra");
            DropColumn("dbo.Nhatkyvanhanh", "phabotvao");
            DropColumn("dbo.Nhatkyvanhanh", "polymerra");
            DropColumn("dbo.Nhatkyvanhanh", "polymervao");
            DropColumn("dbo.Nhatkyvanhanh", "Khoiluongtieuthudien");
            DropColumn("dbo.Nhatkyvanhanh", "Chisotieuthudien");
            DropColumn("dbo.Nhatkyvanhanh", "Luuluongra");
            DropColumn("dbo.Nhatkyvanhanh", "Luuluongvao");
        }
    }
}
