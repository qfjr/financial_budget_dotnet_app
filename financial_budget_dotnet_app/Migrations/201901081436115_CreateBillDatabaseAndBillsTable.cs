namespace financial_budget_dotnet_app.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateBillDatabaseAndBillsTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bills",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        billName = c.String(),
                        billPayment = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Bills");
        }
    }
}
