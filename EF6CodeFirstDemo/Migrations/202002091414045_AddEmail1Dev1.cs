namespace EF6CodeFirstDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddEmail1Dev1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "Email1", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Students", "Email1");
        }
    }
}
