namespace FaceCode.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Changeusernametoemail : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Users", new[] { "username" });
            AddColumn("dbo.Users", "email", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Users", "password", c => c.String(nullable: false));
            CreateIndex("dbo.Users", "email", unique: true);
            DropColumn("dbo.Users", "username");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "username", c => c.String(maxLength: 50));
            DropIndex("dbo.Users", new[] { "email" });
            AlterColumn("dbo.Users", "password", c => c.String());
            DropColumn("dbo.Users", "email");
            CreateIndex("dbo.Users", "username", unique: true);
        }
    }
}
