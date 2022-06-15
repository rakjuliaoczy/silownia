namespace Silownia.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class First : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Classes",
                c => new
                    {
                        ClassId = c.Int(nullable: false, identity: true),
                        ClassType = c.Int(nullable: false),
                        Coach = c.String(),
                        Price = c.Int(nullable: false),
                        Duration = c.Int(nullable: false),
                        ClientId = c.Int(),
                    })
                .PrimaryKey(t => t.ClassId)
                .ForeignKey("dbo.Clients", t => t.ClientId)
                .Index(t => t.ClientId);
            
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        ClientId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Surname = c.String(),
                        Email = c.String(),
                        PhoneNumber = c.Int(nullable: false),
                        GymId = c.Int(),
                    })
                .PrimaryKey(t => t.ClientId)
                .ForeignKey("dbo.Gyms", t => t.GymId)
                .Index(t => t.GymId);
            
            CreateTable(
                "dbo.Gyms",
                c => new
                    {
                        GymId = c.Int(nullable: false, identity: true),
                        GymName = c.Int(nullable: false),
                        Adress = c.String(),
                    })
                .PrimaryKey(t => t.GymId);
            
            CreateTable(
                "dbo.Schedules",
                c => new
                    {
                        ScheduleId = c.Int(nullable: false, identity: true),
                        DateStart = c.DateTime(nullable: false),
                        DateFinish = c.DateTime(nullable: false),
                        ClassId = c.Int(),
                    })
                .PrimaryKey(t => t.ScheduleId)
                .ForeignKey("dbo.Classes", t => t.ClassId)
                .Index(t => t.ClassId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Schedules", "ClassId", "dbo.Classes");
            DropForeignKey("dbo.Clients", "GymId", "dbo.Gyms");
            DropForeignKey("dbo.Classes", "ClientId", "dbo.Clients");
            DropIndex("dbo.Schedules", new[] { "ClassId" });
            DropIndex("dbo.Clients", new[] { "GymId" });
            DropIndex("dbo.Classes", new[] { "ClientId" });
            DropTable("dbo.Schedules");
            DropTable("dbo.Gyms");
            DropTable("dbo.Clients");
            DropTable("dbo.Classes");
        }
    }
}
