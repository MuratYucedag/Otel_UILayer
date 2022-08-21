namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "DepartmentID", c => c.Int(nullable: false));
            CreateIndex("dbo.Employees", "DepartmentID");
            AddForeignKey("dbo.Employees", "DepartmentID", "dbo.Departments", "DepartmentID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Employees", "DepartmentID", "dbo.Departments");
            DropIndex("dbo.Employees", new[] { "DepartmentID" });
            DropColumn("dbo.Employees", "DepartmentID");
        }
    }
}
