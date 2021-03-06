namespace ContactWebLiveDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreatedContactEntity : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Contacts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Guid(nullable: false),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Email = c.String(),
                        PhonePrimary = c.String(),
                        PhoneSecondary = c.String(),
                        Birthday = c.DateTime(nullable: false),
                        StreetAddress1 = c.String(),
                        StreetAddress2 = c.String(),
                        City = c.String(),
                        Town = c.String(),
                        PostCode = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Contacts");
        }
    }
}
