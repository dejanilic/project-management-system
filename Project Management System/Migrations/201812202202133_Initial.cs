namespace Project_Management_System.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Projects",
                c => new
                    {
                        ProjectId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Code = c.String(),
                        UserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ProjectId)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Tasks",
                c => new
                    {
                        TaskId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Status = c.Int(nullable: false),
                        Progress = c.String(),
                        Deadline = c.String(),
                        Description = c.String(),
                        UserId = c.Int(),
                        ProjectId = c.Int(),
                    })
                .PrimaryKey(t => t.TaskId)
                .ForeignKey("dbo.Projects", t => t.ProjectId)
                .ForeignKey("dbo.Users", t => t.UserId)
                .Index(t => t.UserId)
                .Index(t => t.ProjectId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        Username = c.String(),
                        Password = c.String(),
                        Name = c.String(),
                        Surname = c.String(),
                        Email = c.String(),
                        RoleId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.UserId)
                .ForeignKey("dbo.Roles", t => t.RoleId, cascadeDelete: true)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Position = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Projects", "UserId", "dbo.Users");
            DropForeignKey("dbo.Tasks", "UserId", "dbo.Users");
            DropForeignKey("dbo.Users", "RoleId", "dbo.Roles");
            DropForeignKey("dbo.Tasks", "ProjectId", "dbo.Projects");
            DropIndex("dbo.Users", new[] { "RoleId" });
            DropIndex("dbo.Tasks", new[] { "ProjectId" });
            DropIndex("dbo.Tasks", new[] { "UserId" });
            DropIndex("dbo.Projects", new[] { "UserId" });
            DropTable("dbo.Roles");
            DropTable("dbo.Users");
            DropTable("dbo.Tasks");
            DropTable("dbo.Projects");
        }
    }
}
