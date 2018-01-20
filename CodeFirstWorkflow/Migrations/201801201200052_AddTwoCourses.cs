namespace CodeFirstWorkflow.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTwoCourses : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Courses (Title, Description, Level, FullPrice, Author_Id) VALUES('ASP.NET MVC 5', 'ASP.NET MVC5 In depth course.', 2, 79.99, 1)");
            Sql("INSERT INTO Courses (Title, Description, Level, FullPrice, Author_Id) VALUES('Entity Framework Course', 'Entity Framework In depth course.', 2, 59.99, 1)");
        }
        
        public override void Down()
        {
        }
    }
}
