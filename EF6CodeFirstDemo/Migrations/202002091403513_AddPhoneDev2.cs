namespace EF6CodeFirstDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPhoneDev2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "Phone", c => c.String());
            DropColumn("dbo.Students", "Email");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Students", "Email", c => c.String());
            DropColumn("dbo.Students", "Phone");
        }
    }
}
