namespace CodeFirstWorkflow.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddOneAuthor : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Authors (Name) VALUES ('John Smith')");
        }
        
        public override void Down()
        {
        }
    }
}
