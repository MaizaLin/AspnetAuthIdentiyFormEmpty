namespace FromEmpty.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ApplicationUserOpenId : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "OpenId", c => c.String());
            AddColumn("dbo.AspNetUsers", "UnionId", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "UnionId");
            DropColumn("dbo.AspNetUsers", "OpenId");
        }
    }
}
