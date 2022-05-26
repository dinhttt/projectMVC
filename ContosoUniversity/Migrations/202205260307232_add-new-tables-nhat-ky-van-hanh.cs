namespace ContosoUniversity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addnewtablesnhatkyvanhanh : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Nhatkyvanhanh",
                c => new
                    {
                        NhatkyvanhanhID = c.Int(nullable: false, identity: true),
                        MotaNhatky = c.String(),
                        Thongtinsuco = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.NhatkyvanhanhID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Nhatkyvanhanh");
        }
    }
}
