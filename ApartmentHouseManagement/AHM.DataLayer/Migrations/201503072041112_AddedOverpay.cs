namespace AHM.DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedOverpay : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.UtilitiesItems", "Overpay", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            DropColumn("dbo.UtilitiesItems", "Overpay");
        }
    }
}
