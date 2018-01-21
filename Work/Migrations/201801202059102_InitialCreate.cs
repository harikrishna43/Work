namespace Work.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.WorkerModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        WorkerCategory = c.String(),
                        Description = c.String(),
                        City = c.String(),
                        HeadLine = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.WorkerModels");
        }
    }
}
