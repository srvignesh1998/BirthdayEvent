namespace BirthdayEvent.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TableCreated : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AddOns",
                c => new
                    {
                        addOnId = c.Int(nullable: false, identity: true),
                        addOnName = c.String(),
                        addOnDescription = c.String(),
                        addOnPrice = c.Long(nullable: false),
                        addOnImageURL = c.String(),
                    })
                .PrimaryKey(t => t.addOnId);
            
            CreateTable(
                "dbo.Events",
                c => new
                    {
                        eventId = c.Int(nullable: false, identity: true),
                        eventName = c.String(),
                        applicantName = c.String(),
                        ApplicantAddress = c.String(),
                        applicantMobile = c.String(),
                        applicantEmail = c.String(),
                        eventAddress = c.String(),
                        eventDate = c.String(),
                        eventTime = c.String(),
                        eventMenuId = c.Int(nullable: false),
                        addonId = c.Int(nullable: false),
                        EventCost = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.eventId);
            
            CreateTable(
                "dbo.Menus",
                c => new
                    {
                        foodMenuId = c.Int(nullable: false, identity: true),
                        foodMenuImageURL = c.String(),
                        foodMenuType = c.String(),
                        foodMenuItems = c.String(),
                        foodMenuCost = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.foodMenuId);
            
            CreateTable(
                "dbo.Themes",
                c => new
                    {
                        themeId = c.Int(nullable: false, identity: true),
                        themeName = c.String(),
                        themeImageURL = c.String(),
                        themeAddress = c.String(),
                        themeDescription = c.String(),
                        themePhotographer = c.String(),
                        themeVideographer = c.String(),
                        themeReturnGift = c.String(),
                        themeCost = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.themeId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        userId = c.Int(nullable: false, identity: true),
                        Email = c.String(nullable: false),
                        name = c.String(nullable: false),
                        password = c.String(nullable: false),
                        mobileNumber = c.String(nullable: false),
                        userRole = c.String(),
                    })
                .PrimaryKey(t => t.userId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Users");
            DropTable("dbo.Themes");
            DropTable("dbo.Menus");
            DropTable("dbo.Events");
            DropTable("dbo.AddOns");
        }
    }
}
