namespace ContosoUniversity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addtablethongtinme : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ThongtinMe",
                c => new
                    {
                        ThongTinMeID = c.Int(nullable: false, identity: true),
                        ThongTinMeCode = c.String(),
                        CreateBy = c.String(),
                        CreateDate = c.DateTime(nullable: false),
                        UpdateBy = c.String(),
                        UpdateDate = c.DateTime(nullable: false),
                        Begom = c.String(),
                        CycloTron = c.String(),
                        Belang = c.String(),
                        BomHoaChat = c.String(),
                        BeDieuHoa = c.String(),
                        BeSBR1 = c.String(),
                        BeSBR2 = c.String(),
                        MayEpBun = c.String(),
                    })
                .PrimaryKey(t => t.ThongTinMeID);
            
            CreateTable(
                "dbo.ThongtinSuCo",
                c => new
                    {
                        ThongtinSuCoID = c.Int(nullable: false, identity: true),
                        ThongTinSuCoCode = c.String(),
                        CreateDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ThongtinSuCoID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ThongtinSuCo");
            DropTable("dbo.ThongtinMe");
        }
    }
}
