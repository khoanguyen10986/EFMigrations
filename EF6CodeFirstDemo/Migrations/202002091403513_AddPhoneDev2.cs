namespace EF6CodeFirstDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPhoneDev2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "Phone", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Students", "Phone");
        }
    }
}
