namespace BirthdayEvent.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Login : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "LoginErrorMessge", c => c.String());
            AlterColumn("dbo.Users", "userRole", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Users", "userRole", c => c.String());
            DropColumn("dbo.Users", "LoginErrorMessge");
        }
    }
}
