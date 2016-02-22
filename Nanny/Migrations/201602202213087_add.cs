namespace Nanny.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ChildCares", "ChildCareName", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.ChildCares", "ChildCareAddress", c => c.String(maxLength: 128));
            CreateIndex("dbo.ChildCares", new[] { "ChildCareName", "ChildCareAddress" }, unique: true, name: "ChildCareIdentityUIX");
            CreateIndex("dbo.Users", new[] { "UserName", "UserAddress", "UserEmail" }, unique: true, clustered: true, name: "UserIdentityUIX");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Users", "UserIdentityUIX");
            DropIndex("dbo.ChildCares", "ChildCareIdentityUIX");
            AlterColumn("dbo.ChildCares", "ChildCareAddress", c => c.String());
            AlterColumn("dbo.ChildCares", "ChildCareName", c => c.String());
        }
    }
}
