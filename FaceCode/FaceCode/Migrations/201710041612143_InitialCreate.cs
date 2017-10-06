namespace FaceCode.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserID = c.Int(nullable: false, identity: true),
                        username = c.String(maxLength: 50),
                        password = c.String(),
                    })
                .PrimaryKey(t => t.UserID)
                .Index(t => t.username, unique: true);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.Users", new[] { "username" });
            DropTable("dbo.Users");
        }
    }
}
