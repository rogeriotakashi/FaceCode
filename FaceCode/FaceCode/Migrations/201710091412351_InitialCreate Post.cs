namespace FaceCode.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreatePost : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Posts",
                c => new
                    {
                        postID = c.Int(nullable: false, identity: true),
                        title = c.String(),
                        language = c.String(),
                        code = c.String(),
                    })
                .PrimaryKey(t => t.postID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Posts");
        }
    }
}
