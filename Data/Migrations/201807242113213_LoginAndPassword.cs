namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class LoginAndPassword : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Workers", "Login", c => c.String());
            AddColumn("dbo.Workers", "Password", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Workers", "Password");
            DropColumn("dbo.Workers", "Login");
        }
    }
}
