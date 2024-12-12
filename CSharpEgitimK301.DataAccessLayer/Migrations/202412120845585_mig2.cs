namespace CSharpEgitimK301.DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "CustomerName", c => c.String());
            AlterColumn("dbo.Customers", "CustomerSurname", c => c.String());
            AlterColumn("dbo.Customers", "CustomerDistrict", c => c.String());
            AlterColumn("dbo.Customers", "CustomerCity", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "CustomerCity", c => c.Int(nullable: false));
            AlterColumn("dbo.Customers", "CustomerDistrict", c => c.Int(nullable: false));
            AlterColumn("dbo.Customers", "CustomerSurname", c => c.Int(nullable: false));
            AlterColumn("dbo.Customers", "CustomerName", c => c.Int(nullable: false));
        }
    }
}
