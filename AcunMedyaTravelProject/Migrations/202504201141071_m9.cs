namespace AcunMedyaTravelProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class m9 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Destinations",
                c => new
                    {
                        DestinationsID = c.Int(nullable: false, identity: true),
                        ImageURL = c.String(),
                        Title = c.String(),
                        Description = c.String(),
                        Description2 = c.String(),
                    })
                .PrimaryKey(t => t.DestinationsID);
            
            CreateTable(
                "dbo.Services",
                c => new
                    {
                        ServicesID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Description = c.String(),
                        ImageURL = c.String(),
                    })
                .PrimaryKey(t => t.ServicesID);
            
            CreateTable(
                "dbo.Sliders",
                c => new
                    {
                        SliderID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Description = c.String(),
                        Description2 = c.String(),
                        ImageURL = c.String(),
                    })
                .PrimaryKey(t => t.SliderID);
            
            CreateTable(
                "dbo.Subscriptions",
                c => new
                    {
                        SubscriptionID = c.Int(nullable: false, identity: true),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.SubscriptionID);
            
            AddColumn("dbo.Bookings", "Title", c => c.String());
            AddColumn("dbo.Testimonials", "Title", c => c.String());
            DropColumn("dbo.Bookings", "TitleName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Bookings", "TitleName", c => c.String());
            DropColumn("dbo.Testimonials", "Title");
            DropColumn("dbo.Bookings", "Title");
            DropTable("dbo.Subscriptions");
            DropTable("dbo.Sliders");
            DropTable("dbo.Services");
            DropTable("dbo.Destinations");
        }
    }
}
