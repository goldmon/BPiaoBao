namespace BPiaoBao.DomesticTicket.EFRepository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _201411071154 : DbMigration

    {
        public override void Up()
        {
            AddColumn("dbo.AirChange", "ProcessStatus", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AirChange", "ProcessStatus");
        }
    }
}
