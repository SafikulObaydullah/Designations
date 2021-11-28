namespace PartialViewToController.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class des : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Designations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Basic = c.Decimal(nullable: false, precision: 18, scale: 2),
                        HRrate = c.Decimal(nullable: false, precision: 18, scale: 2),
                        MARate = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Convence = c.Decimal(nullable: false, precision: 18, scale: 2),
                        MobileBill = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Designations");
        }
    }
}
