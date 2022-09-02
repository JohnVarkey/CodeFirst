namespace CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedEmail : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "EmailId", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Employees", "EmailId");
        }
    }
}
