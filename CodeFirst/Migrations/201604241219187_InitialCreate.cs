namespace CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.NewTypes",
                c => new
                    {
                        NewTypeId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.NewTypeId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.NewTypes");
        }
    }
}
