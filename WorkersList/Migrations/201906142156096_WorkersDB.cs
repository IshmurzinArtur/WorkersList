namespace WorkersList.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class WorkersDB : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Workers", "Name", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Workers", "Name");
        }
    }
}
