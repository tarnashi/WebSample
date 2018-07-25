namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AccessGroups",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Workers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Salary = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.WorkerAccessGroups",
                c => new
                    {
                        Worker_Id = c.Int(nullable: false),
                        AccessGroup_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Worker_Id, t.AccessGroup_Id })
                .ForeignKey("dbo.Workers", t => t.Worker_Id, cascadeDelete: true)
                .ForeignKey("dbo.AccessGroups", t => t.AccessGroup_Id, cascadeDelete: true)
                .Index(t => t.Worker_Id)
                .Index(t => t.AccessGroup_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.WorkerAccessGroups", "AccessGroup_Id", "dbo.AccessGroups");
            DropForeignKey("dbo.WorkerAccessGroups", "Worker_Id", "dbo.Workers");
            DropIndex("dbo.WorkerAccessGroups", new[] { "AccessGroup_Id" });
            DropIndex("dbo.WorkerAccessGroups", new[] { "Worker_Id" });
            DropTable("dbo.WorkerAccessGroups");
            DropTable("dbo.Workers");
            DropTable("dbo.AccessGroups");
        }
    }
}
