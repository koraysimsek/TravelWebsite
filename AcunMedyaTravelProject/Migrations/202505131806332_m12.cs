namespace AcunMedyaTravelProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class m12 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Subscriptions", "Email", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Subscriptions", "Email", c => c.String());
        }
    }
}
