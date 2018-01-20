namespace CodeFirstWorkflow.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTwoCourses1 : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Courses SET Author_Id = 1 WHERE Id = 1");
            Sql("INSERT INTO Courses (Title, Description, Level, FullPrice, Author_Id) VALUES('Entity Framework Course', 'Entity Framework In depth course.', 2, 59.99, 1)");
        }
        
        public override void Down()
        {
        }
    }
}
