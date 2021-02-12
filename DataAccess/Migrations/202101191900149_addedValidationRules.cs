namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedValidationRules : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Referees", "FirstName", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Referees", "LastName", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Referees", "Country", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Stadia", "Name", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Teams", "TeamName", c => c.String(nullable: false, maxLength: 100));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Teams", "TeamName", c => c.String());
            AlterColumn("dbo.Stadia", "Name", c => c.String());
            AlterColumn("dbo.Referees", "Country", c => c.String());
            AlterColumn("dbo.Referees", "LastName", c => c.String());
            AlterColumn("dbo.Referees", "FirstName", c => c.String());
        }
    }
}
