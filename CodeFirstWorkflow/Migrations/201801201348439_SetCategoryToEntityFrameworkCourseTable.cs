namespace CodeFirstWorkflow.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SetCategoryToEntityFrameworkCourseTable : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Courses SET Category_Id = 1 WHERE Id = 2");
        }
        
        public override void Down()
        {
        }
    }
}
